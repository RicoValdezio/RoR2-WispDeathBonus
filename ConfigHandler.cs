namespace WispDeathBonus
{
    internal class ConfigHandler
    {
        internal static float GlobalChance, PlayerChance, DamageChance, HealthChance, HealingChance, ExpChance, AffixChance, SpeedChance, DexChance, ArmorChance;
        internal static float DamageValue, HealthValue, HealingValue, ExpValue, SpeedValue, DexValue, ArmorValue;
        internal static bool AffixOverride;
        internal static int LesserWispOrbs, GreaterWispOrbs;

        internal static void Init()
        {
            GlobalChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("!General Settings", "Global Proc Chance", 80.00f, "% Chance for Bonus to Generate on Wisp Death").Value;
            PlayerChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("!General Settings", "Player Capture Chance", 20.00f, "% Chance for Bonus to go to Player").Value;
            LesserWispOrbs = WispDeathBonusPlugin.Instance.Config.Bind<int>("!General Settings", "Lesser Wisp Bonuses", 1, "Number of Bonuses a Lesser Wisp Creates").Value;
            GreaterWispOrbs = WispDeathBonusPlugin.Instance.Config.Bind<int>("!General Settings", "Greater Wisp Bonuses", 5, "Number of Bonuses a Greater Wisp Creates").Value;

            DamageChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("Damage Boost Settings", "Damage Boost Chance", 3.00f, "% Chance for Bonus to be a Damage Boost").Value;
            DamageValue = WispDeathBonusPlugin.Instance.Config.Bind<float>("Damage Boost Settings", "Damage Boost Amount", 3.00f, "% Increase in Damage per Damage Boost").Value;

            HealthChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("Health Boost Settings", "Health Boost Chance", 5.00f, "% Chance for Bonus to be a Health Boost").Value;
            HealthValue = WispDeathBonusPlugin.Instance.Config.Bind<float>("Health Boost Settings", "Health Boost Amount", 3.00f, "% Increase in Health per Health Boost").Value;

            HealingChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("Healing Boost Settings", "Healing Boost Chance", 35.00f, "% Chance for Bonus to be a Healing Boost").Value;
            HealingValue = WispDeathBonusPlugin.Instance.Config.Bind<float>("Healing Boost Settings", "Healing Boost Amount", 10.00f, "% Health recovered by Healing Boost").Value;

            ExpChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("Experience Boost Settings", "Experience Boost Chance", 1.00f, "% Chance for Bonus to be a Experience Boost").Value;
            ExpValue = WispDeathBonusPlugin.Instance.Config.Bind<float>("Experience Boost Settings", "Experience Boost Amount", 10.00f, "% Level gained per Experience Boost").Value;

            AffixChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("Affix Boost Settings", "Affix Boost Chance", 16.00f, "% Chance for Bonus to be an Affix Boost").Value;
            AffixOverride = WispDeathBonusPlugin.Instance.Config.Bind<bool>("Affix Boost Settings", "Affix Boost Override", false, "Affix Boost Replaces Equipment").Value;

            SpeedChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("Speed Boost Settings", "Speed Boost Chance", 18.00f, "% Chance for Bonus to be a Speed Boost").Value;
            SpeedValue = WispDeathBonusPlugin.Instance.Config.Bind<float>("Speed Boost Settings", "Speed Boost Amount", 3.00f, "% Increase in Speed per Speed Boost").Value;

            DexChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("Fire Rate Boost Settings", "Fire Rate Boost Chance", 14.00f, "% Chance for Bonus to be a Fire Rate Boost").Value;
            DexValue = WispDeathBonusPlugin.Instance.Config.Bind<float>("Fire Rate Boost Settings", "Fire Rate Boost Amount", 5.00f, "% Increase in Fire Rate per Fire Rate Boost").Value;

            ArmorChance = WispDeathBonusPlugin.Instance.Config.Bind<float>("Armor Boost Settings", "Armor Boost Chance", 8.00f, "% Chance for Bonus to be an Armor Boost").Value;
            ArmorValue = WispDeathBonusPlugin.Instance.Config.Bind<float>("Armor Boost Settings", "Armor Boost Amount", 3.00f, "% Increase in Armor per Armor Boost").Value;
        }
    }
}