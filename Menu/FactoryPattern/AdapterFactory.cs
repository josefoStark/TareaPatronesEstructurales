using Menu.StrategyPattern;

namespace Menu.FactoryPattern
{
    /// <summary>
    /// Fábrica de patrón Adapter.
    /// </summary>
    /// <seealso cref="Menu.FactoryPattern.IFactory" />
    public class AdapterFactory : IFactory
    {
        /// <summary>
        /// Obtiene la instancia del patrón que se ejecutará.
        /// </summary>
        /// <returns>
        /// Patrón a ejecutarse.
        /// </returns>
        public IPattern GetInstance()
        {
            return new Adapter();
        }
    }
}
