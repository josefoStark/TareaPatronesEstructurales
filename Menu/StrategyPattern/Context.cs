namespace Menu.StrategyPattern
{
    /// <summary>
    /// Contexto.
    /// </summary>
    public class Context
    {
        /// <summary>
        /// Patrón de diseño.
        /// </summary>
        private IPattern _strategy;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Context"/>.
        /// </summary>  
        public Context()
        {
            _strategy = new Bridge();

        }

        /// <summary>
        /// Establece el patrón de diseño a ejecutar.
        /// </summary>
        /// <param name="strategy">Patrón de diseño.</param>
        public void SetPattern(IPattern strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Ejecuta la aplicación del patrón de diseño seleccionada.
        /// </summary>
        public void ConsoleProgram()
        {
            _strategy.Execute();
        }
    }
}
