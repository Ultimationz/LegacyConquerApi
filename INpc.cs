using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LegacyConquer.Api
{
    /// <summary>
    /// Npc Interface
    /// </summary>
    public interface INpcApi : IMapObject
    {
        /// <summary>
        /// The id of the current object owner, its either 1 for server or 2 for another player. (This will become an enum eventually)
        /// </summary>
        uint OwnerId { get; }

        /// <summary>
        /// The player that owns the object, only used if the OwnerId is 2
        /// </summary>
        uint PlayerId { get; }

        /// <summary>
        /// The current mesh the npc uses.
        /// </summary>
        ushort Lookface { get; }

        /// <summary>
        /// The name of the npc
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The npc Task Data, 7 UInts.
        /// </summary>
        uint[] Tasks { get; }

        /// <summary>
        /// The npc store data, 4 UInts.
        /// </summary>
        uint[] Data { get; }
    }
}
