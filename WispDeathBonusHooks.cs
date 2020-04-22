using System;

namespace WispDeathBonus
{
    internal class WispDeathBonusHooks
    {
        internal static void Init()
        {
            AddOnDeathHook();
            AddOnCalculateStatsHook();
        }

        private static void AddOnDeathHook()
        {
            //When a wisp dies, determine and give a bonus
        }

        private static void AddOnCalculateStatsHook()
        {
            //When a bonus is given, recalculate the stats
            //Also make sure that bonuses are counted on calculation
        }
    }
}