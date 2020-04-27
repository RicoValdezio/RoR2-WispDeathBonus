using RoR2;
using RoR2.Orbs;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace WispDeathBonus
{
    internal class Hooks
    {
        private static float[] BoostArray;
        internal static void Init()
        {
            InitBoostArray();
            On.RoR2.CharacterMaster.OnBodyDeath += WispDeathCheckHook;
            On.RoR2.CharacterBody.RecalculateStats += WispBonusRecalculate;
        }

        private static void InitBoostArray()
        {
            BoostArray = new float[8]
            {
                ConfigHandler.DamageChance,
                ConfigHandler.HealthChance,
                ConfigHandler.HealingChance,
                ConfigHandler.ExpChance,
                ConfigHandler.AffixChance,
                ConfigHandler.SpeedChance,
                ConfigHandler.DexChance,
                ConfigHandler.ArmorChance
            };
        }

        private static void WispDeathCheckHook(On.RoR2.CharacterMaster.orig_OnBodyDeath orig, CharacterMaster self, CharacterBody body)
        {
            orig(self, body);
            try
            {
                //89 is the bodyIndex for Lesser Wisp
                if (self.IsDeadAndOutOfLivesServer() && body.bodyIndex == 89)
                {
                    if (ConfigHandler.GlobalChance >= Random.Range(0, 100))
                    {
                        int boostType = DetermineBoostType();
                        HurtBox target = GetBonusTarget(self, body);
                        WispBoostOrb orb = new WispBoostOrb
                        {
                            origin = body.corePosition,
                            target = target,
                            bonusType = boostType,
                        };
                        OrbManager.instance.AddOrb(orb);
                    }
                }
            }
            catch { }
        }

        private static HurtBox GetBonusTarget(CharacterMaster self, CharacterBody body)
        {
            BullseyeSearch search = new BullseyeSearch
            {
                searchOrigin = body.corePosition,
                teamMaskFilter = TeamMask.none,
                filterByLoS = false,
                sortMode = BullseyeSearch.SortMode.Distance,
                searchDirection = Vector3.zero
            };
            if (ConfigHandler.PlayerChance >= Random.Range(0, 100))
            {
                search.teamMaskFilter.AddTeam(TeamIndex.Player);
            }
            else
            {
                search.teamMaskFilter.AddTeam(TeamIndex.Monster);
            }
            search.RefreshCandidates();
            return search.GetResults().ElementAt(1);
        }

        private static int DetermineBoostType()
        {
            float roll = UnityEngine.Random.Range(0, BoostArray.Sum());
            for (int i = 1; i <= BoostArray.Length; i++)
            {
                roll -= BoostArray[i - 1];
                if (roll < 0)
                {
                    return i;
                }
            }
            return BoostArray.Length;
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