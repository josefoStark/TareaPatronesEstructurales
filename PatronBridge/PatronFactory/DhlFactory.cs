namespace PatronBridge.PatronFactory
{
    /// <summary>
    /// Fábrica de DHL.
    /// </summary>
    /// <seealso cref="PatronBridge.PatronFactory.ICompanyFactory" />
    public class DhlFactory : ICompanyFactory
    {
        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <returns>
        /// Instancia de tipo compañía
        /// </returns>
        public ICompany CrearInstancia()
        {
            return new Dhl();
        }
    }
}
