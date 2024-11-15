using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using ENTITY;



namespace BLL
{
    public class BotService
    {

        private static ITelegramBotClient _botClient;
        private static Dictionary<long, string> _estadoUsuario = new Dictionary<long, string>();


        public BotService()
        {
            // Inicializa el bot utilizando el token de la entidad Bot
            Bot botConfig = new Bot();
            _botClient = new TelegramBotClient(botConfig.Token);
        }

        public async Task EnviarMensajeAsync(long chatId, string mensaje)
        {
            await _botClient.SendMessage(chatId, mensaje);
        }

        public async Task EscucharActualizacionesAsync()
        {
            int offset = 0;
            string mensaje;
            while (true)
            {
                try
                {
                    var updates = await _botClient.GetUpdates(offset);
                    foreach (var update in updates)
                    {
                        if (update.Message != null)
                        {
                            //$"Mensaje recibido: {update.Message.Text")
                            await VerificarMensaje(update.Message.Text, update.Message.Chat.Id);
                        }
                        offset = update.Id + 1;
                    }
                }
                catch (Exception ex)
                {
                    mensaje = $"Error al obtener actualizaciones: {ex.Message}";

                }

                // Espera de 1 segundo para no saturar el sistema ni la API de Telegram
                await Task.Delay(1000);  // 1000 milisegundos = 1 segundo
            }
        }

        public async Task VerificarMensaje(string mensaje, long id)
        {
            // Verificamos si el diccionario ya tiene una entrada para este usuario (id)
            if (!_estadoUsuario.ContainsKey(id))
            {
                // Si no existe, lo inicializamos con el estado "inicio"
                _estadoUsuario[id] = "inicio";  // El usuario empieza en el menú principal
            }

            // Ahora, verificamos el estado de este usuario y procesamos su mensaje
            switch (_estadoUsuario[id])  // Accedemos al estado del usuario utilizando su chatId (id)
            {
                case "inicio":
                    await MenuPrincipal(id);
                    break;

                case "menu_principal":
                    // Dependiendo del mensaje recibido, movemos al usuario a un submenú específico
                    if (mensaje == "1")
                    {
                        await MenuCitas(id);
                    }
                    else if (mensaje == "2")
                    {
                        await MenuClientes(id);
                    }
                    else if (mensaje == "3")
                    {
                        await MenuVeterinarios(id);
                    }
                    break;

                case "menu_citas":
                    if (mensaje == "1")
                    {
                        await EnviarMensajeAsync(id, "Agendando una nueva cita...");
                        // Lógica para agendar una cita
                    }
                    else if (mensaje == "2")
                    {
                        await EnviarMensajeAsync(id, "Mostrando citas existentes...");
                        // Lógica para consultar citas existentes
                    }
                    else if (mensaje == "3")
                    {
                        await EnviarMensajeAsync(id, "Cancelando cita...");
                        // Lógica para cancelar una cita
                    }
                    else if (mensaje == "0")
                    {
                        await MenuPrincipal(id);
                    }
                    break;

                case "menu_clientes":
                    if (mensaje == "1")
                    {
                        await EnviarMensajeAsync(id, "Mostrando clientes registrados...");
                        // Lógica para mostrar clientes
                    }
                    else if (mensaje == "2")
                    {
                        await EnviarMensajeAsync(id, "Añadiendo nuevo cliente...");
                        // Lógica para agregar un nuevo cliente
                    }
                    else if (mensaje == "0")
                    {
                        await MenuPrincipal(id);
                    }
                    break;

                case "menu_veterinarios":
                    if (mensaje == "1")
                    {
                        await EnviarMensajeAsync(id, "Mostrando veterinarios disponibles...");
                        // Lógica para mostrar veterinarios
                    }
                    else if (mensaje == "2")
                    {
                        await EnviarMensajeAsync(id, "Añadiendo nuevo veterinario...");
                        // Lógica para agregar un nuevo veterinario
                    }
                    else if (mensaje == "0")
                    {
                        await MenuPrincipal(id);
                    }
                    break;

                default:
                    await EnviarMensajeAsync(id, "Opción no válida.");
                    break;

            }
        }

        private async Task MenuVeterinarios(long id)
        {
            await EnviarMensajeAsync(id, "Menú Veterinarios:\n" +
                                                      "1. Ver veterinarios disponibles\n" +
                                                      "2. Añadir nuevo veterinario\n" +
                                                      "0. Atras");
            _estadoUsuario[id] = "menu_veterinarios"; // Actualizamos el estado al menú de Veterinarios
        }

        private async Task MenuClientes(long id)
        {
            await EnviarMensajeAsync(id, "Menú Clientes:\n" +
                                                      "1. Ver clientes registrados\n" +
                                                      "2. Añadir nuevo cliente\n" +
                                                      "0. Atras");
            _estadoUsuario[id] = "menu_clientes"; // Actualizamos el estado al menú de Clientes
        }

        private async Task MenuCitas(long id)
        {
            await EnviarMensajeAsync(id, "Menú Citas:\n" +
                                                      "1. Agendar una nueva cita\n" +
                                                      "2. Consultar citas existentes\n" +
                                                      "3. Cancelar cita\n" +
                                                      "0. Atras");
            _estadoUsuario[id] = "menu_citas"; // Actualizamos el estado al menú de Citas
        }


        public async Task MenuPrincipal(long id)
        {
            // Enviar un mensaje de bienvenida y mostrar opciones
            await EnviarMensajeAsync(id, "¡Hola y bienvenido a Vet-Citas! Soy tu asistente. ¿A qué menú deseas acceder?\n" +
                                          "1. Menu Citas\n" +
                                          "2. Menu Clientes\n" +
                                          "3. Menu Veterinarios");
            _estadoUsuario[id] = "menu_principal"; // Actualizamos el estado del usuario al menú principal
        }

    }

}

