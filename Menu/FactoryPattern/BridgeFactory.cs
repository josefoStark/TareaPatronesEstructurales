using Menu.StrategyPattern;

namespace Menu.FactoryPattern
{
    /// <summary>
    /// Fábrica de patrón Bridge.
    /// </summary>
    /// <seealso cref="Menu.FactoryPattern.IFactory" />
    public class BridgeFactory : IFactory
    {
        /// <summary>
        /// Obtiene la instancia del patrón que se ejecutará.
        /// </summary>
        /// <returns>
        /// Patrón a ejecutarse.
        /// </returns>
        public IPattern GetInstance()
        {
            return new Bridge();
        }
    }
}
