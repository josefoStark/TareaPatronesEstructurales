using System;

namespace PatronBridge
{
    /// <summary>
    /// Servicio de paquetería.
    /// </summary>
    public class ParcelService
    {
        /// <summary>
        /// El transporte.
        /// </summary>
        private readonly ITransport _transport;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ParcelService"/>.
        /// </summary>
        /// <param name="transport">El transporte.</param>
        public ParcelService(ITransport transport)
        {
            _transport = transport;
        }

        /// <summary>
        /// Envía el producto.
        /// </summary>
        /// <param name="product">El producto.</param>
        public void SendProduct(string product)
        {
            string typeTransport = _transport.Type();
            Console.WriteLine($"Su paquete será enviado en {typeTransport.ToUpperInvariant()}");
            Console.WriteLine("\nProcesando su solicitud...");
            Console.WriteLine($"El producto {product} se ha recolectado.");
            Console.WriteLine($"El paquete se ha cargado en {typeTransport}.");
            Console.WriteLine($"El producto {product} se ha enviado.");
            Console.WriteLine($"El {typeTransport} ha salido con el paquete.");
            Console.WriteLine($"El {typeTransport} ha llegado al destino y se ha descargado.");
            Console.WriteLine($"El producto {product} está en camino de ser entregado.");
            Console.WriteLine($"El producto {product} se ha entregado.");
        }
    }
}
