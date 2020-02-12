using System;
using PatronBridge.PatronFactory;

namespace PatronBridge
{
    /// <summary>
    /// Compañía Estafeta.
    /// </summary>
    /// <seealso cref="PatronBridge.ICompany" />
    public class Estafeta : ICompany
    {
        /// <summary>
        /// Obtiene el tipo de transporte.
        /// </summary>
        /// <returns>
        /// Tipo de transporte.
        /// </returns>
        public ITransport GetTransport()
        {
            Console.WriteLine("1-Tren \n2-Barco \n3-Avión");
            int option = Convert.ToInt32(Console.ReadLine());
            ITransportFactory factory = SelectTransport(option);
            ITransport transport = factory.CrearInstancia();
            return transport;
        }

        /// <summary>
        /// Nombre de la compañía.
        /// </summary>
        /// <returns>
        /// Nombre.
        /// </returns>
        public string Name()
        {
            return "Estafeta";
        }

        /// <summary>
        /// Selecciona la fábrica de transporte.
        /// </summary>
        /// <param name="option">Opción seleccionada.</param>
        /// <returns>Fábrica de transporte.</returns>
        private ITransportFactory SelectTransport(int option)
        {
            switch (option)
            {
                case 1:
                    return new TrainFactory();
                case 2:
                    return new ShipFactory();
                default:
                    return new AirplaneFactory();
            }
        }
    }
}
