using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LegacyConquer.Api
{
    /// <summary>
    /// The players interface
    /// </summary>
    public interface IGameClient : IEntity
    {
        /// <summary>
        /// Give player some money, also you can use a negative value to check if the player has money before subtracting it. I.e if (AwardMoney(-100)) 
        /// </summary>
        /// <param name="amount">The amount of money to give or take away</param>
        /// <returns></returns>
        bool AwardMoney(int amount);

        /// <summary>
        /// Sets the players record location to their current location. (Used when returning from market) 
        /// </summary>
        void SetRecordLocation();

        /// <summary>
        /// Sets the players record location to a specific position. (Used when calling ReturnToRecordLocation())
        /// </summary>
        /// <param name="mapId">MapId</param>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        void SetRecordLocation(uint mapId, ushort x, ushort y);

        /// <summary>
        /// Return the player to their last saved record location.
        /// </summary>
        void ReturnToRecordLocation();

        /// <summary>
        /// The amount of money the player currently has
        /// </summary>
        ulong Money { get; }

        /// <summary>
        /// The amount of cps the player currently has
        /// </summary>
        uint Cps { get; }

        /// <summary>
        /// Client Exp manager, Easy access to alot of fun :p
        /// </summary>
        IClientExp Exp { get; }

        /// <summary>
        /// The amount of Agility points the player currently has assigned.
        /// </summary>
        ushort Agility { get; }

        /// <summary>
        /// The amount of Vitality points the player currently has assigned.
        /// </summary>
        ushort Vitality { get; }

        /// <summary>
        /// The amount of Spirit points the player currently has assigned.
        /// </summary>
        ushort Spirit { get; }

        /// <summary>
        /// The amount of Strength points the player currently has assigned.
        /// </summary>
        ushort Strength { get; }

        /// <summary>
        /// The amount of unused stat points the player currently has.
        /// </summary>
        ushort StatPoints { get; }

        /// <summary>
        /// The Players mana
        /// </summary>
        uint Mana { get; }

        /// <summary>
        /// The players current PKPoints
        /// </summary>
        ushort PkPoints { get; }

        /// <summary>
        /// The players current profession
        /// </summary>
        byte Profession { get; }

        /// <summary>
        /// The players current profession level 0 - 5
        /// </summary>
        uint ProfessionLevel { get; }

        /// <summary>
        /// The players current profession, i.e 1,2,4,10
        /// </summary>
        ProfessionType ProfessionSort { get; }

        /// <summary>
        /// The players profession after first rebirth. This rotates with Reincarnation
        /// </summary>
        byte Profession1 { get; }

        /// <summary>
        /// The players profession after second rebirth. This rotates with Reincarnation
        /// </summary>
        byte Profession2 { get; }

        /// <summary>
        /// Change the players profession
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        void SetProfession(ProfessionType type, byte level);

        /// <summary>
        /// The amount of times the player has reborned.
        /// </summary>
        byte Rebirth { get; }

        /// <summary>
        /// The players current vip level
        /// </summary>
        ushort Vip { get; }

        /// <summary>
        /// The players flag next to their name.
        /// </summary>
        ushort Nationality { get; }

        /// <summary>
        /// The level the player was when they first reborned. (This will rotate with reincarnation)
        /// </summary>
        byte RebirthLevel1 { get; }

        /// <summary>
        /// The level the player was when they second reborned. (This will rotate with reincarnation)
        /// </summary>
        byte RebirthLevel2 { get; }

        /// <summary>
        /// The players current stamina (0 - 100) or (0 - 150 if blessed)
        /// </summary>
        byte Stamina { get; }

        /// <summary>
        /// The The players current XpCircle (0-100)
        /// </summary>
        byte XpCircle { get; }

        /// <summary>
        /// Create a new item, (The new item wil not have an owner, you should add it to the clients inventory once created)
        /// </summary>
        /// <param name="itemType">The identifier for the item from itemtype.dat</param>
        /// <param name="plus"></param>
        /// <param name="bound"></param>
        /// <returns></returns>
        ICoItem CreateNewItem(uint itemType, byte plus, bool bound = false);

        /// <summary>
        /// access the players inventory
        /// </summary>
        IInventory Inventory { get; }

        /// <summary>
        /// Access the clients skill manager.
        /// </summary>
        ISkillManager SkillManager { get; }
        
    }
}
