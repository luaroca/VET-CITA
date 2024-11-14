using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using System.Threading;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace PRUEBA
{
    public class TelegramBotCliente
    {
        private readonly TelegramBotClient botClient;
        private readonly LogicaCliente logicaCliente;

        // Diccionario para almacenar el estado de registro de cada usuario
        private readonly Dictionary<long, Cliente> clientesEnProceso = new Dictionary<long, Cliente>();
        private readonly Dictionary<long, int> estadosRegistro = new Dictionary<long, int>();

        public TelegramBotCliente(string token)
        {
            botClient = new TelegramBotClient(token);
            logicaCliente = new LogicaCliente();
        }

        public void Iniciar()
        {
            var cts = new CancellationTokenSource();
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = new[] { UpdateType.Message }
            };

            botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken: cts.Token
            );

            Console.WriteLine("Bot de Telegram iniciado. Presiona cualquier tecla para salir...");
        }

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message is Message message && message.Type == MessageType.Text)
            {
                if (message.Text.ToLower() == "/registrar")
                {
                    await ComenzarRegistro(message.Chat.Id);
                }
                else if (clientesEnProceso.ContainsKey(message.Chat.Id))
                {
                    await ProcesarPasoRegistro(message.Chat.Id, message.Text);
                }
                else
                {
                    await botClient.SendMessage(message.Chat.Id, "Comando no reconocido. Usa /registrar para comenzar el proceso de registro.");
                }
            }
        }

        private async Task ComenzarRegistro(long chatId)
        {
            // Inicia el proceso de registro para el usuario
            clientesEnProceso[chatId] = new Cliente();
            estadosRegistro[chatId] = 1; // 1 es el primer paso

            await botClient.SendMessage(chatId, "Vamos a registrar un nuevo cliente.");
            await botClient.SendMessage(chatId, "Por favor, ingresa el número de cédula del cliente:");
        }

        private async Task ProcesarPasoRegistro(long chatId, string mensaje)
        {
            var cliente = clientesEnProceso[chatId];
            var estado = estadosRegistro[chatId];

            switch (estado)
            {
                case 1: // Paso 1: Solicitar cédula
                    cliente.CC_Cliente = int.Parse(mensaje);
                    estadosRegistro[chatId] = 2;
                    await botClient.SendMessage(chatId, "Ahora, ingresa el nombre del cliente:");
                    break;

                case 2: // Paso 2: Solicitar nombre
                    cliente.Nombre = mensaje;
                    estadosRegistro[chatId] = 3;
                    await botClient.SendMessage(chatId, "Ingresa la dirección del cliente:");
                    break;

                case 3: // Paso 3: Solicitar dirección
                    cliente.Direccion = mensaje;
                    estadosRegistro[chatId] = 4;
                    await botClient.SendMessage(chatId, "Por último, ingresa el teléfono del cliente:");
                    break;

                case 4: // Paso 4: Solicitar teléfono y finalizar registro
                    cliente.Telefono = mensaje;
                    cliente.Accion = "1"; // Acción para insertar en la base de datos

                    string resultado = logicaCliente.N_mantenimiento_cliente(cliente);
                    await botClient.SendMessage(chatId, $"Registro completado: {resultado}");

                    // Limpiar los datos después del registro
                    clientesEnProceso.Remove(chatId);
                    estadosRegistro.Remove(chatId);
                    break;
            }
        }

        private Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Ocurrió un error: {exception.Message}");
            return Task.CompletedTask;
        }
    }
}
