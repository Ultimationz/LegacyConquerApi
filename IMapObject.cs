namespace LegacyConquer.Api
{
    /// <summary>
    /// The interface for every object that is visible to the world.
    /// </summary>
    public interface IMapObject : IGameObject
    {
        /// <summary>
        /// The Objects current world X Coordinate
        /// </summary>
        ushort X { get; }

        /// <summary>
        /// The Objects current world Y Coordinate
        /// </summary>
        ushort Y { get; }

        /// <summary>
        /// The Objects current world MapId (this can be dynamic, check DocId for the DMap id)
        /// </summary>
        uint MapId { get; }

        /// <summary>
        /// The Objects current DMap id
        /// </summary>
        uint DocId { get; }

        /// <summary>
        /// Respawn the entity in the world. (used when equipping equipment etc to notify the players around)
        /// </summary>
        void Respawn();

        /// <summary>
        /// Teleport the object to a specific map and coordinate.
        /// </summary>
        bool Teleport(uint mapId, ushort x, ushort y, bool force = false);

        /// <summary>
        /// The mapdata the object is currently on
        /// </summary>
        IMap Map { get; }

        /// <summary>
        /// Get the distance to another object in the world.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        int DistanceTo(IMapObject target);

        /// <summary>
        /// Is the target on the same map as this object?
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        bool SameMap(IMapObject target);
    }
}