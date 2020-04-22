using R2API;
using RoR2;

namespace WispDeathBonus
{
    internal class Items
    {
        internal static ItemIndex DamageBoostIndex;
        internal static ItemIndex HealthBoostIndex;
        internal static ItemIndex SpeedBoostIndex;
        internal static ItemIndex DexBoostIndex;
        internal static ItemIndex ArmorBoostIndex;

        internal static void Init()
        {
            AddDamageBoostItem();
            AddHealthBoostItem();
            //AddHealingBoostItem is a Hook
            //AddLevelBoostItem is a Hook
            //AddAffixBoostItem is a Hook
            AddSpeedBoostItem();
            AddDexBoostItem();
            AddArmorBoostItem();
        }

        private static void AddDamageBoostItem()
        {
            ItemDef Def = new ItemDef
            {
                name = "DAMAGE_BOOST_NAME",
                nameToken = "DAMAGE_BOOST_NAME",
                pickupToken = "DAMAGE_BOOST_DESC",
                descriptionToken = "DAMAGE_BOOST_DESC",
                loreToken = null,
                pickupIconPath = null,
                pickupModelPath = null,
                tier = ItemTier.NoTier,
                tags = new ItemTag[] { ItemTag.Damage }
            };
            ItemDisplayRule[] DisplayRules = new ItemDisplayRule[0];
            CustomItem Item = new CustomItem(Def, DisplayRules);
            DamageBoostIndex = ItemAPI.Add(Item);
        }

        private static void AddHealthBoostItem()
        {
            ItemDef Def = new ItemDef
            {
                name = "HEALTH_BOOST_NAME",
                nameToken = "HEALTH_BOOST_NAME",
                pickupToken = "HEALTH_BOOST_DESC",
                descriptionToken = "HEALTH_BOOST_DESC",
                loreToken = null,
                pickupIconPath = null,
                pickupModelPath = null,
                tier = ItemTier.NoTier,
                tags = new ItemTag[] { ItemTag.Damage }
            };
            ItemDisplayRule[] DisplayRules = new ItemDisplayRule[0];
            CustomItem Item = new CustomItem(Def, DisplayRules);
            HealthBoostIndex = ItemAPI.Add(Item);
        }

        private static void AddSpeedBoostItem()
        {
            ItemDef Def = new ItemDef
            {
                name = "SPEED_BOOST_NAME",
                nameToken = "SPEED_BOOST_NAME",
                pickupToken = "SPEED_BOOST_DESC",
                descriptionToken = "SPEED_BOOST_DESC",
                loreToken = null,
                pickupIconPath = null,
                pickupModelPath = null,
                tier = ItemTier.NoTier,
                tags = new ItemTag[] { ItemTag.Damage }
            };
            ItemDisplayRule[] DisplayRules = new ItemDisplayRule[0];
            CustomItem Item = new CustomItem(Def, DisplayRules);
            SpeedBoostIndex = ItemAPI.Add(Item);
        }

        private static void AddDexBoostItem()
        {
            ItemDef Def = new ItemDef
            {
                name = "DEX_BOOST_NAME",
                nameToken = "DEX_BOOST_NAME",
                pickupToken = "DEX_BOOST_DESC",
                descriptionToken = "DEX_BOOST_DESC",
                loreToken = null,
                pickupIconPath = null,
                pickupModelPath = null,
                tier = ItemTier.NoTier,
                tags = new ItemTag[] { ItemTag.Damage }
            };
            ItemDisplayRule[] DisplayRules = new ItemDisplayRule[0];
            CustomItem Item = new CustomItem(Def, DisplayRules);
            DexBoostIndex = ItemAPI.Add(Item);
        }

        private static void AddArmorBoostItem()
        {
            ItemDef Def = new ItemDef
            {
                name = "ARMOR_BOOST_NAME",
                nameToken = "ARMOR_BOOST_NAME",
                pickupToken = "ARMOR_BOOST_DESC",
                descriptionToken = "ARMOR_BOOST_DESC",
                loreToken = null,
                pickupIconPath = null,
                pickupModelPath = null,
                tier = ItemTier.NoTier,
                tags = new ItemTag[] { ItemTag.Damage }
            };
            ItemDisplayRule[] DisplayRules = new ItemDisplayRule[0];
            CustomItem Item = new CustomItem(Def, DisplayRules);
            ArmorBoostIndex = ItemAPI.Add(Item);
        }
    }
}