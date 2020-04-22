using RoR2;
using UnityEngine;

namespace WispDeathBonus
{
    internal class Hooks
    {
        internal static void Init()
        {
            On.RoR2.CharacterMaster.OnBodyDeath += WispDeathCheckHook;
            On.RoR2.CharacterBody.RecalculateStats += WispBonusRecalculate;
        }

        private static void WispDeathCheckHook(On.RoR2.CharacterMaster.orig_OnBodyDeath orig, CharacterMaster self, CharacterBody body)
        {
            orig(self, body);
            try
            {
                //89 is the bodyIndex for Lesser Wisp
                if (self.IsDeadAndOutOfLivesServer() && body.bodyIndex == 89)
                {

                }
            }
            catch { }
        }

        private static void WispBonusRecalculate(On.RoR2.CharacterBody.orig_RecalculateStats orig, CharacterBody self)
        {
            orig(self);
            try
            {

            }
            catch { }
        }
    }
}