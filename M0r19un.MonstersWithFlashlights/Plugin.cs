//Based on https://github.com/EvaisaDev/LethalLib


using BepInEx;

using UnityEngine;

namespace M0r19un.MonstersWithFlashlights
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, "Monsters with flashlights mod", PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public const string ModGUID = PluginInfo.PLUGIN_GUID;
        public const string ModName = "Monsters with flashlights mod";
        public const string ModVersion = PluginInfo.PLUGIN_VERSION;

        public static BepInEx.Logging.ManualLogSource logger;
        private void Awake()
        {
            // Plugin startup logic
            PluginLogger.Initialize(ModGUID);
            PluginLogger.Log($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            Enemies.Init();
        }
    }
}