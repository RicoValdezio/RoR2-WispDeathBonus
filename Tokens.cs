using R2API;

namespace WispDeathBonus
{
    internal class Tokens
    {
        internal static void Init()
        {
            LanguageAPI.Add("DAMAGE_BOOST_NAME", "Aspect of Strength");
            LanguageAPI.Add("DAMAGE_BOOST_DESC", "Increase Damage by " + ConfigHandler.DamageValue.ToString() + "%");
            
            LanguageAPI.Add("HEALTH_BOOST_NAME", "Aspect of Vitality");
            LanguageAPI.Add("HEALTH_BOOST_DESC", "Increase Health by " + ConfigHandler.HealthValue.ToString() + "%");
            
            LanguageAPI.Add("SPEED_BOOST_NAME", "Aspect of Speed");
            LanguageAPI.Add("SPEED_BOOST_DESC", "Increase Speed by " + ConfigHandler.SpeedValue.ToString() + "%");
            
            LanguageAPI.Add("DEX_BOOST_NAME", "Aspect of Fury");
            LanguageAPI.Add("DEX_BOOST_DESC", "Increase Fire Rate by " + ConfigHandler.DexValue.ToString() + "%");
            
            LanguageAPI.Add("ARMOR_BOOST_NAME", "Aspect of Toughness");
            LanguageAPI.Add("ARMOR_BOOST_DESC", "Increase Armor by " + ConfigHandler.ArmorValue.ToString() + "%");
        }
    }
}