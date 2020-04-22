using System;

namespace WispDeathBonus
{
    internal class WispDeathBonusItems
    {
        internal static void Init()
        {
            AddDamageBoon();
            AddHealthBoon();
            //AddHealingBoon is a Hook
            //AddLevelBoon is a Hook
            //AddAffixBoon is a Hook
            AddSpeedBoon();
            AddDexBoon();
            AddArmorBoon();
        }

        private static void AddDamageBoon()
        {
            throw new NotImplementedException();
        }

        private static void AddHealthBoon()
        {
            throw new NotImplementedException();
        }

        private static void AddSpeedBoon()
        {
            throw new NotImplementedException();
        }

        private static void AddDexBoon()
        {
            throw new NotImplementedException();
        }

        private static void AddArmorBoon()
        {
            throw new NotImplementedException();
        }
    }
}