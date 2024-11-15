using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace GUI
{
    public class lll
    {
        public static ITelegramBotClient _botClient = new TelegramBotClient("7763752688:AAEi2Z1B6Sc0g-uJ30ILEIdNBI65SLW32fE");
        
        public lll() 
        {
            
        }

        public string NombreId()
        { 
            var me = _botClient.GetMe().Result;


           return ($"Hi, I am {me.Id} and my name is: {me.FirstName} ");      
        }

        public void EncenderBot()
        {
            
        }
//        static TelegramBotClient botClient;
//        static LogicaCliente logicaCliente = new LogicaCliente();
//        static Cliente cliente = new Cliente();

//        static void Main(string[] args)
//        {
//            string token = "TU_BOT_TOKEN"; // Aquí debes poner el token de tu bot
//            botClient = new TelegramBotClient(token);

//            // Establece el manejador de eventos para mensajes entrantes
//            botClient.OnMessage += BotClient_OnMessage;

//            // Inicia el bot
//            botClient.StartReceiving();

//            Console.WriteLine("Bot en funcionamiento...");
//            Console.ReadLine(); // Mantiene el bot funcionando hasta que lo detengas
//        }

//        private static void BotClient_OnMessage(object sender, MessageEventArgs e)
//        {
//            if (e.Message.Text != null)
//            {
//                string message = e.Message.Text.ToLower();

//                // Responde al usuario
//                if (message == "/start")
//                {
//                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "¡Hola! Soy tu asistente para gestionar clientes. ¿Qué acción te gustaría realizar?\n" +
//                                                                        "1. Registrar Cliente\n" +
//                                                                        "2. Modificar Cliente\n" +
//                                                                        "3. Eliminar Cliente");
//                }
//                else if (message == "1")
//                {
//                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "Por favor, ingresa los datos del cliente (CC, Nombre, Dirección, Teléfono) separados por comas.");
//                    cliente.Accion = "1"; // Registro
//                }
//                else if (message == "2")
//                {
//                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "Por favor, ingresa los datos del cliente a modificar (CC, Nombre, Dirección, Teléfono) separados por comas.");
//                    cliente.Accion = "2"; // Modificar
//                }
//                else if (message == "3")
//                { 
//                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "Por favor, ingresa el CC del cliente a eliminar.");
//                    cliente.Accion = "3"; // Eliminar
//                }
//                else
//                {
//                    // Procesar la información de cliente
//                    ProcessClientData(e.Message.Text, e.Message.Chat.Id);
//                }
//            }
//        }

//        private static void ProcessClientData(string input, long chatId)
//        {
//            try
//            {
//                // Procesamos la entrada del cliente
//                string[] data = input.Split(',');

//                if (data.Length == 4) // Para Registro y Modificación
//                {
//                    cliente.CC_Cliente = int.Parse(data[0]);
//                    cliente.Nombre = data[1].Trim();
//                    cliente.Direccion = data[2].Trim();
//                    cliente.Telefono = data[3].Trim();

//                    // Ejecutar la lógica para mantener el cliente en la base de datos
//                    string mensaje = logicaCliente.N_mantenimiento_cliente(cliente);

//                    botClient.SendTextMessageAsync(chatId, mensaje);
//                }
//                else if (data.Length == 1) // Para Eliminar (solo CC)
//                {
//                    cliente.CC_Cliente = int.Parse(data[0].Trim());

//                    // Ejecutar la lógica para eliminar el cliente de la base de datos
//                    string mensaje = logicaCliente.N_mantenimiento_cliente(cliente);

//                    botClient.SendTextMessageAsync(chatId, mensaje);
//                }
//                else
//                {
//                    botClient.SendTextMessageAsync(chatId, "Datos incorrectos. Por favor, ingresa la información correctamente.");
//                }
//            }
//            catch (Exception ex)
//            {
//                botClient.SendTextMessageAsync(chatId, "Error: " + ex.Message);
//            }
//        }
//    }
//}

            
    }
}
