namespace LegacyConquer.Api
{
    /// <summary>
    /// The interface for every object in the world.
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// The unique identifier for every object in the world.
        /// </summary>
        uint Id { get; set; }
        /// <summary>
        /// Is the object a Player?
        /// </summary>
        bool IsPlayer { get; }
        /// <summary>
        /// Is the object a Monster?
        /// </summary>
        bool IsMonster { get; }
        /// <summary>
        /// Is the object a Npc?
        /// </summary>
        bool IsNpc { get; }
        /// <summary>
        /// Is the object a Item?
        /// </summary>
        bool IsItem { get; }
        /// <summary>
        /// Is the object a Pet?
        /// </summary>
        bool IsPet { get; }
        /// <summary>
        /// Is the object an Attackable Npc?
        /// </summary>
        bool IsSob { get; }
        /// <summary>
        /// Is the object attackable?
        /// </summary>
        bool IsEntity { get; }
    }
}