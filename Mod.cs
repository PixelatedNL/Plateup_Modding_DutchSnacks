﻿global using Kitchen;
global using KitchenLib.References;
global using KitchenLib;
global using KitchenLib.Event;
global using KitchenMods;
global using KitchenData;
global using KitchenLib.Customs;
global using KitchenLib.Utils;
global using UnityEngine;
global using System.Reflection;
global using ApplianceLib.Api.References;
global using static KitchenData.ItemGroup;
global using static KitchenLib.Utils.GDOUtils;
global using System.Linq;
using KitchenDutchSnacks.Mains;
using System.Net.Security;

// Namespace should have "Kitchen" in the beginning
namespace KitchenDutchSnacks
{
    public class Mod : BaseMod, IModSystem
    {
        // GUID must be unique and is recommended to be in reverse domain name notation
        // Mod Name is displayed to the player and listed in the mods menu
        // Mod Version must follow semver notation e.g. "1.2.3"
        public const string MOD_GUID = "Pixelated.PlateUp.DutchSnacks";
        public const string MOD_NAME = "Dutch Snacks";
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = "Pixelated";
        public const string MOD_GAMEVERSION = ">=1.1.4";
        // Game version this mod is designed for in semver
        // e.g. ">=1.1.3" current and all future
        // e.g. ">=1.1.3 <=1.2.3" for all from/until

        // Boolean constant whose value depends on whether you built with DEBUG or RELEASE mode, useful for testing
#if DEBUG
        public const bool DEBUG_MODE = true;
#else
        public const bool DEBUG_MODE = false;
#endif

        public static AssetBundle Bundle;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        protected override void OnInitialise()
        {
            LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        private void AddGameData()
        {
            LogInfo("Attempting to register game data...");

            AddGameDataObject<DutchSnacksDish>();

            // Bitterballen
            AddGameDataObject<BitterballenUnmixed>();
            AddGameDataObject<BitterballenUncooked>();
            AddGameDataObject<BitterballenPotCooked>();
            AddGameDataObject<BitterballenPotUncooked>();
            AddGameDataObject<BitterballenCooked>();
            AddGameDataObject<BitterballenSingle>();
            AddGameDataObject<PlatedBiBiBiBi>();

            // Bamihapjes

            LogInfo("Done loading game data.");
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            // TODO: Uncomment the following if you have an asset bundle.
            // TODO: Also, make sure to set EnableAssetBundleDeploy to 'true' in your ModName.csproj

            LogInfo("Attempting to load asset bundle...");
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).First();
            LogInfo("Done loading asset bundle.");

            // Register custom GDOs
            AddGameData();

            // Perform actions when game data is built
            Events.BuildGameDataEvent += delegate (object s, BuildGameDataEventArgs args)
            {
            };
        }
        #region Logging
        public static void LogInfo(string _log) { Debug.Log($"[{MOD_NAME}] " + _log); }
        public static void LogWarning(string _log) { Debug.LogWarning($"[{MOD_NAME}] " + _log); }
        public static void LogError(string _log) { Debug.LogError($"[{MOD_NAME}] " + _log); }
        public static void LogInfo(object _log) { LogInfo(_log.ToString()); }
        public static void LogWarning(object _log) { LogWarning(_log.ToString()); }
        public static void LogError(object _log) { LogError(_log.ToString()); }
        #endregion
    }
}
