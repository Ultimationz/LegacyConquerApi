using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyConquer.Api
{
    public interface ICoItem
    {
        uint Id { get; }
        IItemType Data { get; }
        uint ItemType { get;}
        ItemPosition Slot { get; }
        ushort Plus { get; }
        ushort Amount { get;  }
        ushort AmountLimit { get; }
        byte Gem1 { get;}
        byte Gem2 { get;}
        byte Blessed { get; }
        byte Enchant { get;  }
        byte Locked { get; }
        byte Inscribed { get; }
        ulong SaveTime { get; }
        uint Dragonsoul { get;  }
        uint CompositionProgress { get; }
        uint Magic1 { get; }
        bool Bound { get; }
        uint Stack { get; }
        uint Color { get; }
        uint GetBattlePower();
        uint GetQuality();
        uint GetUpgradeQualityChance();
        uint GetUpLevelInfo();
        uint GetLevel();
        uint CalculateRepairCost();
        uint GetRequiredGradeExp();
        void AddGradeExp(uint amount);
        uint GetAddGradeExp();
        void Update();
    }
}
