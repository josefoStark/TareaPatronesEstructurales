namespace PatronBridge.PatronFactory
{
    /// <summary>
    /// Fábrica de aviones.
    /// </summary>
    /// <seealso cref="PatronBridge.PatronFactory.ITransportFactory" />
    public class AirplaneFactory : ITransportFactory
    {
        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <returns>
        /// Instancia de tipo transporte
        /// </returns>
        public ITransport CrearInstancia()
        {
            return  new Airplane();
        }
    }
}
