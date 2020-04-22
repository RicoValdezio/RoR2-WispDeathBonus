using RoR2;
using System;

namespace WispDeathBonus
{
    internal class WispDeathBonusItems
    {
        internal static ItemIndex DamageBoostIndex;
        internal static ItemIndex HealthBoostIndex;
        internal static ItemIndex SpeedBoostIndex;
        internal static ItemIndex DexBoostIndex;
        internal static ItemIndex ArmorBoostIndex;

        internal static void Init()
        {
            AddDamageBoostItem();
            AddHealthBoostItem();
            //AddHealingBoostItem is a Hook
            //AddLevelBoostItem is a Hook
            //AddAffixBoostItem is a Hook
            AddSpeedBoostItem();
            AddDexBoostItem();
            AddArmorBoostItem();
        }

        private static void AddDamageBoostItem()
        {
            throw new NotImplementedException();
        }

        private static void AddHealthBoostItem()
        {
            throw new NotImplementedException();
        }

        private static void AddSpeedBoostItem()
        {
            throw new NotImplementedException();
        }

        private static void AddDexBoostItem()
        {
            throw new NotImplementedException();
        }

        private static void AddArmorBoostItem()
        {
            throw new NotImplementedException();
        }
    }
}