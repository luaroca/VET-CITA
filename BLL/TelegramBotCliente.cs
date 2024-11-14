using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class TelegramBotCliente
    {
        //private readonly string token;
        //private readonly TelegramBotClient botClient;

        //public TelegramBotCliente(string token)
        //{
        //    this.token = token;
        //    this.botClient = new TelegramBotClient(this.token);
        //}

        //public void Iniciar()
        //{
        //    // Suscribirse al evento de mensaje
        //    botClient.OnMessage += BotClient_OnMessage;

        //    // Iniciar la recepción de mensajes con opciones
        //    botClient.StartReceiving(new Telegram.Bot.Polling.ReceiverOptions(), default);
        //}

        //// Maneja los mensajes recibidos
        //private async void BotClient_OnMessage(object sender, MessageEventArgs e)
        //{
        //    if (e.Message.Text != null)
        //    {
        //        Console.WriteLine($"Recibido mensaje: {e.Message.Text}");

        //        // Aquí podrías agregar lógica para manejar el mensaje recibido
        //        // y registrar los datos en la base de datos
        //        await RegistrarCliente(e.Message.Text);  // Asumiendo que el mensaje es un nombre de cliente
        //    }
        //}

        //// Método para registrar los datos del cliente en la base de datos
        //private async Task RegistrarCliente(string mensaje)
        //{
        //    // Conexión a la base de datos
        //    string connectionString = "server=LAPTOP-CHO7PHK5\\SQLEXPRESS;integrated security=true;database=DBVeterinaria"; // Asegúrate de usar tu cadena de conexión correcta

        //    string query = "INSERT INTO Cliente (Nombre) VALUES (@Nombre)"; // Asumiendo que tienes una tabla Cliente con un campo Nombre

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            await connection.OpenAsync();

        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                // Parámetros para evitar SQL Injection
        //                command.Parameters.AddWithValue("@Nombre", mensaje); // Utilizando el mensaje como nombre del cliente

        //                int filasAfectadas = await command.ExecuteNonQueryAsync();

        //                if (filasAfectadas > 0)
        //                {
        //                    Console.WriteLine("Cliente registrado correctamente.");
        //                    // Aquí puedes enviar un mensaje al usuario para confirmar que se registró correctamente
        //                    await botClient.SendTextMessageAsync(e.Message.Chat, "Cliente registrado correctamente.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("No se pudo registrar al cliente.");
        //                    // Aquí puedes enviar un mensaje de error al usuario
        //                    await botClient.SendTextMessageAsync(e.Message.Chat, "No se pudo registrar el cliente.");
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error al registrar cliente: {ex.Message}");
        //            // Mensaje de error en caso de que ocurra una excepción
        //            await botClient.SendTextMessageAsync(e.Message.Chat, "Hubo un error al registrar el cliente. Inténtalo nuevamente.");
        //        }
        //    }
        //}
    }
}
