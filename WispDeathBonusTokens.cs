using R2API.AssetPlus;

namespace WispDeathBonus
{
    internal class WispDeathBonusTokens
    {
        internal static void Init()
        {
            Languages.AddToken("DAMAGE_BOOST_NAME", "Infusion of Increased Damage");
            Languages.AddToken("DAMAGE_BOOST_DESC", "Increase Damage by " + WispDeathBonusConfig.DamageValue.ToString() + "%");

            Languages.AddToken("HEALTH_BOOST_NAME", "Infusion of Increased Health");
            Languages.AddToken("HEALTH_BOOST_DESC", "Increase Health by " + WispDeathBonusConfig.HealthValue.ToString() + "%");

            Languages.AddToken("SPEED_BOOST_NAME", "Infusion of Increased Speed");
            Languages.AddToken("SPEED_BOOST_DESC", "Increase Speed by " + WispDeathBonusConfig.SpeedValue.ToString() + "%");

            Languages.AddToken("DEX_BOOST_NAME", "Infusion of Increased Fire Rate");
            Languages.AddToken("DEX_BOOST_DESC", "Increase Fire Rate by " + WispDeathBonusConfig.DexValue.ToString() + "%");

            Languages.AddToken("ARMOR_BOOST_NAME", "Infusion of Increased Armor");
            Languages.AddToken("ARMOR_BOOST_DESC", "Increase Armor by " + WispDeathBonusConfig.ArmorValue.ToString() + "%");
        }
    }
}