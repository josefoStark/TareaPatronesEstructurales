namespace PatronDecorador
{
    /// <summary>
    /// Operaciones de la cuenta.
    /// </summary>
    /// <seealso cref="PatronDecorador.IAccountOperation" />
    public class AccountOperation : IAccountOperation
    {
        /// <summary>
        /// Guardar datos.
        /// </summary>
        /// <param name="data">La información.</param>
        public void SaveData(AccountData data)
        {
            data.ShowMessage("\n\nSe han guardado los siguientes datos:");
            data.ShowMessage($"Cuenta por Pagar: {data.iIdCuentaXPagar}");
            data.ShowMessage($"Importe: {data.dImporte}");
            data.ShowMessage($"Unidad Admin: {data.cIdUnidadAdministrativa}");
            data.ShowMessage($"Activo: {data.lActivo}");
            data.ShowMessage($"Naturaleza: {data.lNaturaleza}");
        }
    }
}
