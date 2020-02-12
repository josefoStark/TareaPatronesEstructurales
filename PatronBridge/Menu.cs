using System;

namespace PatronBridge
{
    /// <summary>
    /// Clase menú.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Compañía.
        /// </summary>
        private readonly ICompany _company;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Menu"/>.
        /// </summary>
        /// <param name="company">La compañía.</param>
        public Menu(ICompany company)
        {
            _company = company;
        }

        /// <summary>
        /// Selecciona el transporte.
        /// </summary>
        /// <returns>Tipo de transporte.</returns>
        public ITransport SelectTransport()
        {
            Console.WriteLine($"\nHa elegido enviar su paquete por {_company.Name().ToUpperInvariant()}");
            Console.WriteLine("Seleccione el transporte disponible para su envío:");
            return _company.GetTransport();
        }
    }
}
