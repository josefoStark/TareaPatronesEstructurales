namespace PatronBridge.PatronFactory
{
    /// <summary>
    /// Fábrica de barcos.
    /// </summary>
    /// <seealso cref="PatronBridge.PatronFactory.ITransportFactory" />
    public class ShipFactory : ITransportFactory
    {
        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <returns>
        /// Instancia de tipo transporte
        /// </returns>
        public ITransport CrearInstancia()
        {
            return new Ship();
        }
    }
}
