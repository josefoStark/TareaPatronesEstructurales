namespace PatronDecorador
{
    /// <summary>
    /// Operación de la cuenta.
    /// </summary>
    public interface IAccountOperation
    {
        /// <summary>
        /// Guarda los datos de la cuenta.
        /// </summary>
        /// <param name="data">Información a guardar.</param>
        void SaveData(AccountData data);
    }
}
