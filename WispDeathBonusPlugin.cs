using BepInEx;
using R2API;
using R2API.Utils;
using System.Reflection;
using UnityEngine;

namespace WispDeathBonus
{

    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [R2APISubmoduleDependency(new string[] { "ItemAPI", "ItemDropAPI", "ResourcesAPI", "AssetPlus", "OrbAPI", "LanguageAPI", "BuffAPI" })]
    [BepInPlugin(ModGuid, ModName, ModVer)]
    public class WispDeathBonusPlugin : BaseUnityPlugin
    {
        private const string ModVer = "1.0.0";
        private const string ModName = "WispDeathBonus";
        private const string ModGuid = "com.RicoValdezio.WispDeathBonus";
        internal static WispDeathBonusPlugin Instance;

        private void Awake()
        {
            if (Instance == null) { Instance = this; }
            AddAssetBundleProvider();
            ConfigHandler.Init();
            Tokens.Init();
            Items.Init();
            Buffs.Init();
            Hooks.Init();
        }

        private void AddAssetBundleProvider()
        {
            using (System.IO.Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WispDeathBonus.wdbp"))
            {
                AssetBundle bundle = AssetBundle.LoadFromStream(stream);
                AssetBundleResourcesProvider provider = new AssetBundleResourcesProvider("@WDBP", bundle);
                ResourcesAPI.AddProvider(provider);
            }
        }
    }
}
