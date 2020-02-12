namespace PatronBridge.PatronFactory
{
    /// <summary>
    /// Fábrica de Estafeta.
    /// </summary>
    /// <seealso cref="PatronBridge.PatronFactory.ICompanyFactory" />
    public class EstafetaFactory : ICompanyFactory
    {
        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <returns>
        /// Instancia de tipo compañía
        /// </returns>
        public ICompany CrearInstancia()
        {
            return  new Estafeta();
        }
    }
}
