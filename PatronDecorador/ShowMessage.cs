using System;

namespace PatronDecorador
{
    /// <summary>
    /// Servicio de consola.
    /// </summary>
    /// <seealso cref="PatronDecorador.IService" />
    public class ConsoleService : IService
    {
        /// <summary>
        /// Muestra el mensaje.
        /// </summary>
        /// <param name="message">Mensaje a desplegar.</param>
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
