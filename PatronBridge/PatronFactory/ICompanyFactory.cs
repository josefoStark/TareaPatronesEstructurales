namespace PatronBridge.PatronFactory
{
    /// <summary>
    /// Fábrica de compañías.
    /// </summary>
    public interface ICompanyFactory
    {
        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <returns>Instancia de tipo compañía</returns>
        ICompany CrearInstancia();
    }
}
