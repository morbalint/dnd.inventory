using System;

namespace dnd.inventory.api.Model
{
    [Flags]
    public enum ItemType
    {
        Misc = 0,
        Money = 1 << 0,
        Wearable = 1 << 1,
        Consumable = 1 << 2,
        Weapon = 1 << 3,
        Armor = 1 << 4,
        Ranged = 1 << 5,
        Melee = 1 << 6,
        Ammo = 1 << 7,
        Magical = 1 << 8,
        RequiresAttunement = 1 << 9,
        HasCharges = 1 << 10,
    }
}
