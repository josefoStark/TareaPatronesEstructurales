namespace PatronBridge.PatronFactory
{
    /// <summary>
    /// Fábrica de Fedex.
    /// </summary>
    /// <seealso cref="PatronBridge.PatronFactory.ICompanyFactory" />
    public class FedexFactory : ICompanyFactory
    {
        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <returns>
        /// Instancia de tipo compañía
        /// </returns>
        public ICompany CrearInstancia()
        {
            return new Fedex();
        }
    }
}
