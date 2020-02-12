namespace PatronBridge.PatronFactory
{
    /// <summary>
    /// Fábrica de transportes.
    /// </summary>
    public interface ITransportFactory
    {
        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <returns>Instancia de tipo transporte</returns>
        ITransport CrearInstancia();
    }
}
