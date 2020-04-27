using RoR2;
using RoR2.Orbs;
using System.Linq;
using UnityEngine;

namespace WispDeathBonus
{
    internal class Hooks
    {
        private static float[] BoostArray;
        internal static void Init()
        {
            InitBoostArray();
            On.RoR2.CharacterMaster.OnBodyDeath += WispDeathHook;
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

        private static void WispDeathHook(On.RoR2.CharacterMaster.orig_OnBodyDeath orig, CharacterMaster self, CharacterBody body)
        {
            orig(self, body);
            try
            {
                if (ConfigHandler.GlobalChance >= Random.Range(0, 100))
                {
                    int orbsToFire = 0;
                    if (self.IsDeadAndOutOfLivesServer() && body.bodyIndex == 89)
                    {
                        orbsToFire = ConfigHandler.LesserWispOrbs;
                    }
                    else if (self.IsDeadAndOutOfLivesServer() && body.bodyIndex == 41)
                    {
                        orbsToFire = ConfigHandler.GreaterWispOrbs;
                    }

                    for (int i = 1; i <= orbsToFire; i++)
                    {
                        WispBoostOrb orb = new WispBoostOrb
                        {
                            origin = body.corePosition,
                            target = GetBonusTarget(body, i),
                            bonusType = DetermineBoostType(),
                        };
                        if (orb.bonusType == 5)
                        {
                            orb.affixType = GetAffixType(body);
                        }
                        OrbManager.instance.AddOrb(orb);
                    }
                }
            }
            catch { }
        }

        private static int GetAffixType(CharacterBody body)
        {
            if (body.HasBuff(BuffIndex.AffixBlue))
            {
                return 1;
            }
            else if (body.HasBuff(BuffIndex.AffixRed))
            {
                return 2;
            }
            else if (body.HasBuff(BuffIndex.AffixWhite))
            {
                return 3;
            }
            else if (body.HasBuff(BuffIndex.AffixHaunted))
            {
                return 4;
            }
            else if (body.HasBuff(BuffIndex.AffixPoison))
            {
                return 5;
            }
            return 0;
        }

        private static HurtBox GetBonusTarget(CharacterBody body, int relativeOrder)
        {
            BullseyeSearch search = new BullseyeSearch
            {
                searchOrigin = body.corePosition,
                teamMaskFilter = TeamMask.none,
                filterByLoS = false,
                sortMode = BullseyeSearch.SortMode.Distance,
                searchDirection = Vector3.zero
            };
            if (ConfigHandler.PlayerChance >= UnityEngine.Random.Range(0, 100))
            {
                search.teamMaskFilter.AddTeam(TeamIndex.Player);
            }
            else
            {
                search.teamMaskFilter.AddTeam(TeamIndex.Monster);
            }
            search.RefreshCandidates();
            return search.GetResults().ElementAt(relativeOrder);
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