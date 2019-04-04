namespace LegacyConquer.Api
{
    public interface IMap
    {
        /// <summary>
        /// Map name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The Map Dynamic (Instance) id
        /// </summary>
        uint MapId { get; }

        /// <summary>
        /// The Map DMAp ID
        /// </summary>
        uint DocId { get; }

        /// <summary>
        /// Can the players freely pk here?
        /// </summary>
        bool IsPkField { get; }

        /// <summary>
        /// Can the players teleport from this map?
        /// </summary>
        bool IsFlyToDisable { get; }

        /// <summary>
        /// Is this map a newbie map
        /// </summary>
        bool IsNewbieMap { get; }

        /// <summary>
        /// Can this map save the players location?
        /// </summary>
        bool IsRecordDisable { get; }

        /// <summary>
        /// Can we pk on this map?
        /// </summary>
        bool IsPkDisable { get; }

        /// <summary>
        /// Can we create teams on this map?
        /// </summary>
        bool IsTeamDisable { get; }

        /// <summary>
        /// Can we teleport to this map?
        /// </summary>
        bool IsTeleportDisable { get; }

        /// <summary>
        /// Is this the guild map?
        /// </summary>
        bool IsGuildMap { get; }

        /// <summary>
        /// Is this a jail map?
        /// </summary>
        bool IsPrisonMap { get; }

        /// <summary>
        /// Is this the Training ground map?
        /// </summary>
        bool IsTrainMap { get; }

        /// <summary>
        /// Can players fly on this map?
        /// </summary>
        bool IsWingEnable { get; }

        /// <summary>
        /// Can we mine on this map?
        /// </summary>
        bool IsMineField { get; }

        /// <summary>
        /// Unknown
        /// </summary>
        bool IsCallNewbieDisable { get; }
        /// <summary>
        /// Are we in a house
        /// </summary>
        bool IsFamilyMap { get; }
        /// <summary>
        /// Can we revive here?
        /// </summary>
        bool IsRebornNowEnable { get; }
        /// <summary>
        /// Are newbies protected
        /// </summary>
        bool IsNewbieProtectMap { get; }
        /// <summary>
        /// Can we use skills here?
        /// </summary>
        bool IsTrainingDisable { get; }
        /// <summary>
        /// Can we setup market stalls here
        /// </summary>
        bool IsBoothEnable { get; }
        /// <summary>
        /// Are we one of the metzone maps?
        /// </summary>
        bool IsMetZoneMap { get; }
        /// <summary>
        /// Are we frozen grotto?
        /// </summary>
        bool IsGrotto { get; }
        /// <summary>
        /// Is this the NPC jail map?
        /// </summary>
        bool IsNpcJail { get; }
        /// <summary>
        /// Is this PKArea?
        /// </summary>
        bool IsPkArena { get; }
        /// <summary>
        /// Can we access the coordinate at a given location?
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool ValidCoordinate(ushort x, ushort y);
        /// <summary>
        /// Try to get the revive point for the map, aka when a player dies where does he revive to?
        /// </summary>
        /// <param name="map"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool TryGetRevivePoint(out uint map, out uint x, out uint y);
    }
}