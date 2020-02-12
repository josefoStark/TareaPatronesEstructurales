namespace PatronDecorador
{
    /// <summary>
    /// Decorador Guardar histórico.
    /// </summary>
    /// <seealso cref="PatronDecorador.IAccountOperation" />
    public class SaveHistoricDecorator : IAccountOperation
    {
        /// <summary>
        /// Objeto a decorar.
        /// </summary>
        private readonly IAccountOperation _wrappee;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SaveHistoricDecorator"/>.
        /// </summary>
        /// <param name="accountOperation">Operación de la cuenta.</param>
        public SaveHistoricDecorator(IAccountOperation accountOperation)
        {
            _wrappee = accountOperation;
        }

        /// <summary>
        /// Guarda los datos de la cuenta.
        /// </summary>
        /// <param name="data">Información a guardar.</param>
        public void SaveData(AccountData data)
        {
            _wrappee.SaveData(data);
            SaveHistoric(data);
        }

        /// <summary>
        /// Guarda el histórico.
        /// </summary>
        /// <param name="data">Información a guardar en histórico.</param>
        private void SaveHistoric(AccountData data)
        {
            if (!data.lActivo)
            {
                data.ShowMessage("\nActualización 1...");
                data.ShowMessage("Se ha guardado la cuenta eliminada");
            }
        }
    }
}
