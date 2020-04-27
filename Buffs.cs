using R2API;
using RoR2;
using UnityEngine;

namespace WispDeathBonus
{
    class Buffs
    {
        internal static BuffIndex DamageBoostIndex;
        internal static BuffIndex HealthBoostIndex;
        internal static BuffIndex SpeedBoostIndex;
        internal static BuffIndex DexBoostIndex;
        internal static BuffIndex ArmorBoostIndex;

        internal static void Init()
        {
            AddDamageBoostBuff();
            AddHealthBoostBuff();
            AddSpeedBoostBuff();
            AddDexBoostBuff();
            AddArmorBoostBuff();
        }

        private static void AddDamageBoostBuff()
        {
            BuffDef def = new BuffDef
            {
                name = "Aspect of Strength",
                canStack = true,
                isDebuff = false,
                iconPath = "@WDBP:Assets/WDBP/StrengthIcon.png"
            };
            CustomBuff buff = new CustomBuff(def);
            DamageBoostIndex = BuffAPI.Add(buff);
        }

        private static void AddHealthBoostBuff()
        {
            BuffDef def = new BuffDef
            {
                name = "Aspect of Vitality",
                canStack = true,
                isDebuff = false,
                iconPath = "@WDBP:Assets/WDBP/HealthItem.png"
            };
            CustomBuff buff = new CustomBuff(def);
            HealthBoostIndex = BuffAPI.Add(buff);
        }

        private static void AddSpeedBoostBuff()
        {
            BuffDef def = new BuffDef
            {
                name = "Aspect of Speed",
                canStack = true,
                isDebuff = false,
                iconPath = "@WDBP:Assets/WDBP/SpeedItem.png"
            };
            CustomBuff buff = new CustomBuff(def);
            SpeedBoostIndex = BuffAPI.Add(buff);
        }

        private static void AddDexBoostBuff()
        {
            BuffDef def = new BuffDef
            {
                name = "Aspect of Fury",
                canStack = true,
                isDebuff = false,
                iconPath = "@WDBP:Assets/WDBP/DexItem.png"
            };
            CustomBuff buff = new CustomBuff(def);
            DexBoostIndex = BuffAPI.Add(buff);
        }

        private static void AddArmorBoostBuff()
        {
            BuffDef def = new BuffDef
            {
                name = "Aspect of Toughness",
                canStack = true,
                isDebuff = false,
                iconPath = "@WDBP:Assets/WDBP/ArmorItem.png"
            };
            CustomBuff buff = new CustomBuff(def);
            ArmorBoostIndex = BuffAPI.Add(buff);
        }
    }
}
