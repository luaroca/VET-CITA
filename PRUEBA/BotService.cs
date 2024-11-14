using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace PRUEBA
{
    public class BotService
    {
        private static TelegramBotClient botClient;
        private LogicaCliente logicaCliente = new LogicaCliente();

        private enum BotState
        {
            None,
            AwaitingID,
            AwaitingName,
            AwaitingAddress,
            AwaitingPhone
        }

        private BotState currentState = BotState.None;
        private Cliente cliente = new Cliente();

        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;

        public BotService(string token)
        {
            botClient = new TelegramBotClient(token);
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
        }

        public void Start()
        {
            botClient.StartReceiving(HandleUpdateAsync, HandleErrorAsync, cancellationToken: cancellationToken);
            Console.WriteLine("Bot iniciado. Presiona cualquier tecla para salir...");
            Console.ReadKey();
            Stop();
        }

        public void Stop()
        {
            cancellationTokenSource.Cancel();
            Console.WriteLine("Bot detenido.");
        }

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message && update.Message.Type == MessageType.Text)
            {
                var chatId = update.Message.Chat.Id;
                var messageText = update.Message.Text;

                switch (currentState)
                {
                    case BotState.None:
                        await botClient.SendMessage(chatId, "Bienvenido. Por favor, digite su identificación:", cancellationToken: cancellationToken);
                        currentState = BotState.AwaitingID;
                        break;

                    case BotState.AwaitingID:
                        if (int.TryParse(messageText, out int ccCliente))
                        {
                            cliente.CC_Cliente = ccCliente;
                            await botClient.SendMessage(chatId, "Digite el nombre del cliente:", cancellationToken: cancellationToken);
                            currentState = BotState.AwaitingName;
                        }
                        else
                        {
                            await botClient.SendMessage(chatId, "Por favor, ingrese una identificación válida.", cancellationToken: cancellationToken);
                        }
                        break;

                    case BotState.AwaitingName:
                        cliente.Nombre = messageText;
                        await botClient.SendMessage(chatId, "Digite la dirección del cliente:", cancellationToken: cancellationToken);
                        currentState = BotState.AwaitingAddress;
                        break;

                    case BotState.AwaitingAddress:
                        cliente.Direccion = messageText;
                        await botClient.SendMessage(chatId, "Digite el teléfono del cliente:", cancellationToken: cancellationToken);
                        currentState = BotState.AwaitingPhone;
                        break;

                    case BotState.AwaitingPhone:
                        cliente.Telefono = messageText;
                        cliente.Accion = "1"; // Acción para registrar cliente

                        // Guarda el cliente en la base de datos
                        string mensaje = logicaCliente.N_mantenimiento_cliente(cliente);
                        await botClient.SendMessage(chatId, mensaje, cancellationToken: cancellationToken);

                        // Reinicia el proceso
                        currentState = BotState.None;
                        cliente = new Cliente();
                        break;
                }
            }
        }

        private Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Ocurrió un error: {exception.Message}");
            return Task.CompletedTask;
        }
    }
}
