using RoR2;
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
                ConfigHandler.LevelChance,
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
                        switch (boostType)
                        {
                            case 1: //Damage Boost
                                Chat.AddMessage("Damage Boost");
                                break;
                            case 2: //Health Boost
                                Chat.AddMessage("Health Boost");
                                break;
                            case 3: //Healing Boost
                                Chat.AddMessage("Healing Boost");
                                break;
                            case 4: //Level Boost
                                Chat.AddMessage("Level Boost");
                                break;
                            case 5: //Affix Boost
                                Chat.AddMessage("Affix Boost");
                                break;
                            case 6: //Speed Boost
                                Chat.AddMessage("Speed Boost");
                                break;
                            case 7: //Dex Boost
                                Chat.AddMessage("Dex Boost");
                                break;
                            case 8: //Armor Boost
                                Chat.AddMessage("Armor Boost");
                                break;
                        }
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
            return search.GetResults().First();
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