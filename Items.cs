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
            AddSpeedBoostItem();
            AddDexBoostItem();
            AddArmorBoostItem();
        }

        private static void AddDamageBoostItem()
        {
            ItemDef Def = new ItemDef
            {
                name = "AspectOfStrength",
                nameToken = "DAMAGE_BOOST_NAME",
                pickupToken = "DAMAGE_BOOST_DESC",
                descriptionToken = "DAMAGE_BOOST_DESC",
                loreToken = null,
                pickupIconPath = "@WDBP:Assets/WDBP/StrengthItem.png",
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
                name = "AspectOfVitality",
                nameToken = "HEALTH_BOOST_NAME",
                pickupToken = "HEALTH_BOOST_DESC",
                descriptionToken = "HEALTH_BOOST_DESC",
                loreToken = null,
                pickupIconPath = "@WDBP:Assets/WDBP/HealthItem.png",
                pickupModelPath = null,
                tier = ItemTier.NoTier,
                tags = new ItemTag[] { ItemTag.Healing }
            };
            ItemDisplayRule[] DisplayRules = new ItemDisplayRule[0];
            CustomItem Item = new CustomItem(Def, DisplayRules);
            HealthBoostIndex = ItemAPI.Add(Item);
        }

        private static void AddSpeedBoostItem()
        {
            ItemDef Def = new ItemDef
            {
                name = "AspectOfSpeed",
                nameToken = "SPEED_BOOST_NAME",
                pickupToken = "SPEED_BOOST_DESC",
                descriptionToken = "SPEED_BOOST_DESC",
                loreToken = null,
                pickupIconPath = "@WDBP:Assets/WDBP/SpeedItem.png",
                pickupModelPath = null,
                tier = ItemTier.NoTier,
                tags = new ItemTag[] { ItemTag.Utility }
            };
            ItemDisplayRule[] DisplayRules = new ItemDisplayRule[0];
            CustomItem Item = new CustomItem(Def, DisplayRules);
            SpeedBoostIndex = ItemAPI.Add(Item);
        }

        private static void AddDexBoostItem()
        {
            ItemDef Def = new ItemDef
            {
                name = "AspectOfFury",
                nameToken = "DEX_BOOST_NAME",
                pickupToken = "DEX_BOOST_DESC",
                descriptionToken = "DEX_BOOST_DESC",
                loreToken = null,
                pickupIconPath = "@WDBP:Assets/WDBP/DexItem.png",
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
                name = "AspectOfToughness",
                nameToken = "ARMOR_BOOST_NAME",
                pickupToken = "ARMOR_BOOST_DESC",
                descriptionToken = "ARMOR_BOOST_DESC",
                loreToken = null,
                pickupIconPath = "@WDBP:Assets/WDBP/ArmorItem.png",
                pickupModelPath = null,
                tier = ItemTier.NoTier,
                tags = new ItemTag[] { ItemTag.Utility }
            };
            ItemDisplayRule[] DisplayRules = new ItemDisplayRule[0];
            CustomItem Item = new CustomItem(Def, DisplayRules);
            ArmorBoostIndex = ItemAPI.Add(Item);
        }
    }
}