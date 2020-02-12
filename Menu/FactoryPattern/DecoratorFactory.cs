using Menu.StrategyPattern;

namespace Menu.FactoryPattern
{
    /// <summary>
    /// Fabrica de patrón decorador.
    /// </summary>
    /// <seealso cref="Menu.FactoryPattern.IFactory" />
    public class DecoratorFactory : IFactory
    {
        /// <summary>
        /// Obtiene la instancia del patrón que se ejecutará.
        /// </summary>
        /// <returns>
        /// Patrón a ejecutarse.
        /// </returns>
        public IPattern GetInstance()
        {
            return new Decorator();
        }
    }
}
