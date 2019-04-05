using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyConquer.Api
{
    public interface IItemType
    {
        uint Id { get; }
        string Name { get;  }
        ushort ReqProfession { get;  }
        ushort ReqWeaponskill { get;  }
        ushort ReqLevel { get;  }
        ushort ReqSex { get;  }
        ushort ReqForce { get;  }
        ushort ReqSpeed { get;  }
        ushort ReqHealth { get;  }
        ushort ReqSoul { get;  }
        ItemMonopoly Monopoly { get;  }
        ushort Weight { get; }
        uint Price { get;  }
        uint IdAction { get;  }
        ushort AttackMax { get;  }
        ushort AttackMin { get;  }
        ushort Defense { get;  }
        ushort Dexterity { get;  }
        ushort Dodge { get;  }
        ushort Life { get;  }
        ushort Mana { get;  }
        ushort Amount { get;  }
        ushort AmountLimit { get;  }
        ushort Ident { get;  }
        ushort Gem1 { get;  }
        ushort Gem2 { get;  }
        uint Magic1 { get;  }
        ushort Magic2 { get;  }
        ushort Magic3 { get;  }
        uint Data { get; set; }
        ushort MagicAtk { get; }
        ushort MagicDef { get; }
        ushort AtkRange { get; }
        ushort AtkSpeed { get; }
        ushort FrayMode { get; }
        ushort RepairMode { get;}
        ushort TypeMask { get;  }
        uint EmoneyPrice { get;  }
        uint EmoneyMonoPrice { get;  }
        uint SaveTime { get;  }
        ushort CriticalRate { get;  }
        ushort MagicCriticalRate { get;  }
        ushort AntiCriticalRate { get;  }
        ushort MagicPenetration { get;  }
        uint ShieldBlock { get;  }
        ushort CrashAttack { get;  }
        ushort StableDefence { get;  }
        uint AccumulateLimit { get;  }
        uint AttrMetal { get;  }
        uint AttrWood { get;  }
        uint AttrWater { get;  }
        uint AttrFire { get;  }
        uint AttrEarth { get;  }
        string TypeDesc { get;  }
        string ItemDesc { get;  }
        uint ColorIndex { get;}
        ushort Godsoullev { get;  }
        ushort MeteorCount { get;  }
        uint RecoverEnergy { get;  }
        ushort AuctionClass { get;  }
        uint AuctionDeposit { get;  }
        ushort FinalDmgAdd { get;  }
        ushort FinalDmgAddMgc { get;  }
        ushort FinalDmgReduce { get;  }
        ushort FinalDmgReduceMgc { get;  }
        ushort Sort { get;  }
        bool IsNormal { get; }
        bool IsHelment { get; }
        bool IsNecklace { get; }
        bool IsArmor { get; }
        bool IsWeapon1 { get; }
        bool IsWeapon2 { get; }
        bool IsWeapon { get; }
        bool IsShield { get; }
        bool IsRing { get; }
        bool IsHeavyRing { get; }
        bool IsBracelet { get; }
        bool IsNormalRing { get; }
        bool IsShoes { get; }
        bool IsOther { get; }
        bool IsGarment { get; }
        byte Quality { get; }
        bool IsMedicine { get; }
        bool IsDart { get; }
        bool IsArrow { get; }
        bool IsArrowSort { get; }
        bool IsNormalArrow { get; }
        bool IsSpell { get; }
        bool IsExpend { get; }
        bool IsEquipment { get; }
        bool IsBottle { get; }
        bool IsTransSpell { get; }
        bool IsActionItem { get; }
        bool IsTaskItem { get; }
        bool IsGem { get; }
        bool IsNoSuch { get; }
        bool IsHoldEnable { get; }
        bool IsEquipEnable { get; }
        bool IsPick { get; }
        bool IsDragonBall { get; }
        bool IsMeteor { get; }
        bool IsMeteorTear { get; }
        bool IsMeteorScroll { get; }
        bool IsDragonBallScroll { get; }
        bool IsDepositEnable { get; }
        bool IsEatEnable { get; }
        bool IsPileEnable { get; }
        bool IsRepairEnable { get; }
        bool IsExchangeEnable { get; }
        bool IsStorageEnable { get; }
        bool IsAccessory { get; }
        bool IsScroll { get; }
        bool IsPaidItem { get; }
        bool IsSteed { get; }
        bool IsStone { get; }
        bool IsNoobBox { get; }
        bool IsBow();
        bool IsSycthe();
        uint GetItemSubType();
        uint GetLevel();
        ItemSort GetItemSort();
        ItemTypeEnum GetItemType();
        uint GetItemValueType();
        uint GetUpValueCount();
        bool RequireDBUpgrade();
        uint GetHighQuality();
        bool IsMagicSword();
        string ToString();
    }
}
