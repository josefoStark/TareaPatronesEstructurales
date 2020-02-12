namespace PatronDecorador
{
    /// <summary>
    /// Decorador Notificación.
    /// </summary>
    /// <seealso cref="PatronDecorador.IAccountOperation" />
    public class NotificationDecorator : IAccountOperation
    {
        /// <summary>
        /// Objeto a decorar.
        /// </summary>
        private readonly IAccountOperation _wrappee;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="NotificationDecorator"/>.
        /// </summary>
        /// <param name="accountOperation">Operación de la cuenta.</param>
        public NotificationDecorator(IAccountOperation accountOperation)
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
            SendNotification(data);
        }

        /// <summary>
        /// Envía la notificación.
        /// </summary>
        /// <param name="data">Información para notificar.</param>
        private void SendNotification(AccountData data)
        {
            if (!data.lNaturaleza)
            {
                data.ShowMessage("\nActualización 2..");
                data.ShowMessage("Se le ha enviado un correo electrónico con la CXP de gasto ");
            }
        }
    }
}
