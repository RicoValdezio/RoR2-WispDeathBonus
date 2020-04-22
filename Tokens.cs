using R2API.AssetPlus;

namespace WispDeathBonus
{
    internal class Tokens
    {
        internal static void Init()
        {
            Languages.AddToken("DAMAGE_BOOST_NAME", "Aspect of Strength");
            Languages.AddToken("DAMAGE_BOOST_DESC", "Increase Damage by " + ConfigHandler.DamageValue.ToString() + "%");

            Languages.AddToken("HEALTH_BOOST_NAME", "Aspect of Vitality");
            Languages.AddToken("HEALTH_BOOST_DESC", "Increase Health by " + ConfigHandler.HealthValue.ToString() + "%");

            Languages.AddToken("SPEED_BOOST_NAME", "Aspect of Speed");
            Languages.AddToken("SPEED_BOOST_DESC", "Increase Speed by " + ConfigHandler.SpeedValue.ToString() + "%");

            Languages.AddToken("DEX_BOOST_NAME", "Aspect of Fury");
            Languages.AddToken("DEX_BOOST_DESC", "Increase Fire Rate by " + ConfigHandler.DexValue.ToString() + "%");

            Languages.AddToken("ARMOR_BOOST_NAME", "Aspect of Toughness");
            Languages.AddToken("ARMOR_BOOST_DESC", "Increase Armor by " + ConfigHandler.ArmorValue.ToString() + "%");
        }
    }
}