namespace PatronAdapter
{
    /// <summary>
    /// Interfaz del cliente
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Líneas de código por requerimiento.
        /// </summary>
        /// <param name="id">Id del requerimiento.</param>
        /// <returns>Líneas de código respectivas.</returns>
        int LineCodeByReq(int id);
    }
}
