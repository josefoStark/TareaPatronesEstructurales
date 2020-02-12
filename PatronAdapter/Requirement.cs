namespace PatronAdapter
{
    /// <summary>
    /// Requerimiento.
    /// </summary>
    public class Requirement
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Líneas de código estimadas.
        /// </summary>
        public int EstimatedLineCode { get; set; }

        /// <summary>
        /// Líneas reales de código.
        /// </summary>
        public int RealLineCode { get; set; }
    }
}
