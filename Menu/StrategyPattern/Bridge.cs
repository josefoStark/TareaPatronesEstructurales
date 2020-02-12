using PatronBridge;

namespace Menu.StrategyPattern
{
    /// <summary>
    /// Patrón bridge.
    /// </summary>
    /// <seealso cref="Menu.StrategyPattern.IPattern" />
    public class Bridge : IPattern
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
