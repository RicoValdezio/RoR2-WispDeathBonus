using BepInEx;
using R2API.Utils;
using System;

namespace WispDeathBonus
{

    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [R2APISubmoduleDependency(new string[] { "ItemAPI", "ItemDropAPI", "ResourcesAPI", "AssetPlus" })]
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
            WispDeathBonusConfig.Init();
            WispDeathBonusItems.Init();
            WispDeathBonusHooks.Init();
        }

        private void AddAssetBundleProvider()
        {
            //Does nothing right now, but will import embedded asset
            throw new NotImplementedException();
        }
    }
}
