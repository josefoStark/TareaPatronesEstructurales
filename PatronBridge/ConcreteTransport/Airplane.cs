namespace PatronBridge
{
    /// <summary>
    /// Clase avión.
    /// </summary>
    /// <seealso cref="PatronBridge.ITransport" />
    public class Airplane:ITransport
    {
        /// <summary>
        /// Tipo de transporte
        /// </summary>
        /// <returns>
        /// Tipo.
        /// </returns>
        public string Type()
        {
            return "Avión";
        }
    }
}
