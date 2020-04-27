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
                        if (boostType == 5)
                        {
                            int affixType = 0;
                            if (body.HasBuff(BuffIndex.AffixBlue)) affixType = 1;
                            else if (body.HasBuff(BuffIndex.AffixRed)) affixType = 2;
                            else if (body.HasBuff(BuffIndex.AffixWhite)) affixType = 3;
                            else if (body.HasBuff(BuffIndex.AffixHaunted)) affixType = 4;
                            else if (body.HasBuff(BuffIndex.AffixPoison)) affixType = 5;
                            orb.affixType = affixType;
                        }
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
    }
}