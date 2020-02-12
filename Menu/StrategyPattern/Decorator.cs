using PatronDecorador;

namespace Menu.StrategyPattern
{
    /// <summary>
    /// Patrón decorador.
    /// </summary>
    /// <seealso cref="Menu.StrategyPattern.IPattern" />
    public class Decorator : IPattern
    {
        /// <summary>
        /// Ejecuta la aplicación correspondiente al patrón de diseño .
        /// </summary>
        public void Execute()
        {
            new Cliente().Main();
        }
    }
}
