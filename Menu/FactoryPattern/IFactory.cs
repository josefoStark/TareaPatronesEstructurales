using Menu.StrategyPattern;

namespace Menu.FactoryPattern
{
    /// <summary>
    /// Fábrica de patrones.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Obtiene la instancia del patrón que se ejecutará.
        /// </summary>
        /// <returns>Patrón a ejecutarse.</returns>
        IPattern GetInstance();
    }
}
