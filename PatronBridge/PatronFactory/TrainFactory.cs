namespace PatronBridge.PatronFactory
{
    /// <summary>
    /// Fábrica de trenes.
    /// </summary>
    /// <seealso cref="PatronBridge.PatronFactory.ITransportFactory" />
    public class TrainFactory : ITransportFactory
    {
        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <returns>
        /// Instancia de tipo transporte
        /// </returns>
        public ITransport CrearInstancia()
        {
            return new Train();
        }
    }
}
