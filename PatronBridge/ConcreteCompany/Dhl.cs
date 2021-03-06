﻿using System;
using PatronBridge.PatronFactory;

namespace PatronBridge
{
    /// <summary>
    /// Compañía DHL.
    /// </summary>
    /// <seealso cref="PatronBridge.ICompany" />
    public class Dhl : ICompany
    {
        /// <summary>
        /// Obtiene el tipo de transporte.
        /// </summary>
        /// <returns>
        /// Tipo de transporte.
        /// </returns>
        public ITransport GetTransport()
        {
            Console.WriteLine("1-Barco \n2-Avión ");
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
            return "Dhl";
        }

        /// <summary>
        /// Selecciona la fábrica de transporte.
        /// </summary>
        /// <param name="option">Opción seleccionada.</param>
        /// <returns>Fábrica de transporte.</returns>
        private ITransportFactory SelectTransport(int option)
        {
            if (option == 1)
                return new ShipFactory();

            return new AirplaneFactory();
        }
    }
}
