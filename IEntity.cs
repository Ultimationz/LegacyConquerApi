

namespace LegacyConquer.Api
{
    /// <summary>
    /// Interface for all game Entities
    /// </summary>
    public interface IEntity:IMapObject
    {
        /// <summary>
        /// The name of the entity.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// The level of the entity
        /// </summary>
        byte Level { get; }
        /// <summary>
        /// The current health of the entity.
        /// </summary>
        uint Health { get; }
        /// <summary>
        /// Is the entity dead?
        /// </summary>
        bool IsDead { get; }
        /// <summary>
        /// Is the entity flying?
        /// </summary>
        bool IsFlying { get; }
        /// <summary>
        /// Does the entity have a flashing name?
        /// </summary>
        bool IsBlueName { get; }
        /// <summary>
        /// Is the entity red named?
        /// </summary>
        bool IsRedName { get; }
        /// <summary>
        /// Is the entity black named?
        /// </summary>
        bool IsBlackName { get; }
        
    }
}