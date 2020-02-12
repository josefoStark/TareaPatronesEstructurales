namespace PatronBridge
{
    /// <summary>
    /// Clase barco.
    /// </summary>
    /// <seealso cref="PatronBridge.ITransport" />
    public class Ship : ITransport
    {
        /// <summary>
        /// Tipo de transporte
        /// </summary>
        /// <returns>
        /// Tipo.
        /// </returns>
        public string Type()
        {
            return "Barco";
        }
    }
}
