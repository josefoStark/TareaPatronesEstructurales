using PatronAdapter;

namespace Menu.StrategyPattern
{
    /// <summary>
    /// Patrón adaptador.
    /// </summary>
    /// <seealso cref="Menu.StrategyPattern.IPattern" />
    public class Adapter : IPattern
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
