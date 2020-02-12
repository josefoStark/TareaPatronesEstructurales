namespace PatronBridge
{
    /// <summary>
    /// Interfaz de la compañía.
    /// </summary>
    public interface ICompany
    {
        /// <summary>
        /// Obtiene el tipo de transporte.
        /// </summary>
        /// <returns>Tipo de transporte.</returns>
        ITransport GetTransport();

        /// <summary>
        /// Nombre de la compañía.
        /// </summary>
        /// <returns>Nombre.</returns>
        string Name();
    }
}
