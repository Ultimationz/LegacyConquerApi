using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyConquer.Api
{
    [Flags]
    public enum ItemMonopoly : ushort
    {
        Monopoly = 1,
        Storage = 2,
        Ident = 3,
        NeverDropWhenDead = 0x10
    }
    public enum ItemTypeEnum
    {
        Invalid = -1,
        Medicine = 0,
        Poison = 10000,
        Dart = 20000,
        Book = 30000,
        NotUse = 40000,
        Arrow = 50000,
        Spell = 60000,
        NotDirectUse = 70000,
        Ex0 = 080000,
        Ex1 = 90000,
        Gem = 0,
        TaskItem = 10000,
        ActionItem = 20000,
        Necklace = 0,
        Sachet = 10000,
        Amulet = 20000,
        Ring = 0,
        ThumbRing = 10000,
        Bangle = 20000,
        Bow = 0,
        Blade = 10000,
        Axe = 20000,
        Hammer = 30000,
        Hook = 40000,
        Staff = 50000,
        Shovel = 60000,
        Halberd = 70000,
        Fork = 80000,
        Spear = 90000
    }
    public enum ItemSort
    {
        Invalid = -1,
        Expend = 0,
        Helment = 1,
        Necklace = 2,
        Armor = 3,
        Weapon1 = 4,
        Weapon2 = 5,
        Shield = 6,
        Ring = 7,
        Shoes = 8,
        Garment = 9,
        Bottle = 10,
        Other = 11,
        Mount,
        Accessory1,
        Accessory2,
        AccessoryBow,
        AccessoryShield,
        Bracelet,
        HeavyRing

    }
    public enum ItemPosition : ulong
    {
        //Inventory = 0,
        //EquipBegin = 1,
        //Helmet = 1,
        //Necklace = 2,
        //Armor = 3,
        //WeaponR = 4,
        //WeaponL = 5,
        //Ring = 6,
        //Bottle = 7,
        //Shoes = 8,
        //Mount = 9,
        //Sprite = 10,
        //Mantle = 11,
        //EquipEnd = 18,
        Inventory = 0,
        Head = 1,
        Necklace = 2,
        Armor = 3,
        Right = 4,
        Left = 5,
        Ring = 6,
        Bottle = 7,
        Boots = 8,
        Garment = 9,
        AttackTalisman = 10,
        DefenceTalisman = 11,
        Steed = 12,
        MountArmor = 17,
        LeftAccessory = 16,
        RightAccessory = 15,
        EquipEnd = 17,
        EquipBegin = 1,
        MainEnd = 20,
        AltEnd = 40

    }
}
