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
        bool AddItem(ICoItem item);
        ICoItem RemoveItem(uint id);
        ICoItem GetItem(uint id);
        ICoItem GetItemByType(uint typeId, bool bound);
        ICoItem[] GetItemsByType(uint typeId, bool bound);
    }
}
