using System;

namespace WispDeathBonus
{
    internal class WispDeathBonusConfig
    {
        internal static decimal GlobalChance, PlayerChance, DamageChance, HealthChance, HealingChance, LevelChance, AffixChance, SpeedChance, DexChance, ArmorChance;
        internal static decimal DamageValue, HealthValue, HealingValue, AffixValue, SpeedValue, DexValue, ArmorValue;

        internal static void Init()
        {
            InitAndLoadConfig();
            ConvertChancesToArray();
        }

        private static void InitAndLoadConfig()
        {
            GlobalChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("General Settings", "Global Proc Chance", 20.00m, "% Chance for Bonus to Generate on Wisp Death").Value;
            PlayerChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("General Settings", "Player Capture Chance", 20.00m, "% Chance for Bonus to go to Player").Value;

            DamageChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Damage Boost Settings", "Damage Boost Chance", 20.00m, "% Chance for Bonus to be a Damage Boost").Value;
            DamageValue = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Damage Boost Settings", "Damage Boost Amount", 3.00m, "% Increase in Damage per Damage Boost").Value;

            HealthChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Health Boost Settings", "Health Boost Chance", 20.00m, "% Chance for Bonus to be a Health Boost").Value;
            HealthValue = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Health Boost Settings", "Health Boost Amount", 3.00m, "% Increase in Health per Health Boost").Value;

            HealingChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Healing Boost Settings", "Healing Boost Chance", 20.00m, "% Chance for Bonus to be a Healing Boost").Value;
            HealingValue = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Healing Boost Settings", "Healing Boost Amount", 10.00m, "% Health recovered by Healing Boost").Value;

            LevelChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Level Boost Settings", "Level Boost Chance", 20.00m, "% Chance for Bonus to be a Level Boost").Value;

            AffixChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Affix Boost Settings", "Affix Boost Chance", 20.00m, "% Chance for Bonus to be a Affix Boost").Value;

            SpeedChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Speed Boost Settings", "Speed Boost Chance", 20.00m, "% Chance for Bonus to be a Speed Boost").Value;
            SpeedValue = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Speed Boost Settings", "Speed Boost Amount", 3.00m, "% Increase in Speed per Speed Boost").Value;

            DexChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Fire Rate Boost Settings", "Fire Rate Boost Chance", 20.00m, "% Chance for Bonus to be a Fire Rate Boost").Value;
            DexValue = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Fire Rate Boost Settings", "Fire Rate Boost Amount", 5.00m, "% Increase in Fire Rate per Fire Rate Boost").Value;

            ArmorChance = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Armor Boost Settings", "Armor Boost Chance", 20.00m, "% Chance for Bonus to be a Armor Boost").Value;
            ArmorValue = WispDeathBonusPlugin.Instance.Config.Bind<decimal>("Armor Boost Settings", "Armor Boost Amount", 3.00m, "% Increase in Armor per Armor Boost").Value;
        }

        private static void ConvertChancesToArray()
        {
            //Convert the config values into something usable
            throw new NotImplementedException();
        }
    }
}