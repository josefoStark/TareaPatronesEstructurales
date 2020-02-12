namespace PatronBridge
{
    /// <summary>
    /// Clase tren.
    /// </summary>
    /// <seealso cref="PatronBridge.ITransport" />
    public class Train : ITransport
    {
        /// <summary>
        /// Tipo de transporte
        /// </summary>
        /// <returns>
        /// Tipo.
        /// </returns>
        public string Type()
        {
            return "Tren";
        }
    }
}
