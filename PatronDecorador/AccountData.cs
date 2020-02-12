namespace PatronDecorador
{
    /// <summary>
    /// Datos de la cuenta.
    /// </summary>
    public class AccountData
    {
        /// <summary>
        /// Servicio de impresión de mensajes.
        /// </summary>
        private IService _service;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="AccountData"/>.
        /// </summary>
        /// <param name="service">Servicio de impresión de mensajes..</param>
        public AccountData(IService service)
        {
            _service = service;
        }

        /// <summary>
        /// Id de la cuenta por pagar.
        /// </summary>
        public int iIdCuentaXPagar { get; set; }

        /// <summary>
        /// Importe.
        /// </summary>
        public double dImporte { get; set; }

        /// <summary>
        /// Id de la unidad administrativa.
        /// </summary>
        public string cIdUnidadAdministrativa { get; set; }

        /// <summary>
        /// Estado activo.
        /// </summary>
        public bool lActivo { get; set; }

        /// <summary>
        /// Naturaleza de la cuenta.
        /// </summary>
        public bool lNaturaleza { get; set; }

        /// <summary>
        /// Muestra el mensaje.
        /// </summary>
        /// <param name="message">Mensaje a mostrar.</param>
        public void ShowMessage(string message)
        {
            _service.ShowMessage(message);
        }
    }
}
