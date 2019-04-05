using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyConquer.Api
{
    public interface IInventory
    {
        bool IsFull { get; }
        bool IsEmpty { get; }
        bool HasSpace { get; }
        uint FreeSpace { get; }
        /// <summary>
        /// Give a item to the player.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool AddItem(ICoItem item);
        /// <summary>
        /// This will remove the whole stack, use RemoveItems if you only intend to remove one item by its type.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ICoItem RemoveItem(uint id);
        /// <summary>
        /// Remove items from the player via typeId, This will count item stacks too.
        /// </summary>
        /// <param name="itemType"></param>
        /// <param name="amount"></param>
        void RemoveItems(uint itemType,uint amount);
        ICoItem GetItem(uint id);
        ICoItem GetItemByType(uint typeId, bool bound);
        ICoItem[] GetItemsByType(uint typeId, bool bound);
        /// <summary>
        /// Count the amount of items the player has for a specific item type.
        /// </summary>
        /// <param name="itemType"></param>
        /// <param name="countStack">Count the stack value</param>
        /// <returns></returns>
        uint CountItems(uint itemType, bool countStack);
    }
}
