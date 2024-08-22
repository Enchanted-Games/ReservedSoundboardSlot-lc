using System.IO;

using BepInEx;

using HarmonyLib;
using BepInEx.Logging;

using UnityEngine;

namespace ReservedSoundboardSlot
{
    public static class PluginInfo
    {
        public const string PLUGIN_ID = "ReservedSoundboardSlot";
        public const string PLUGIN_NAME = "ReservedSoundboardSlot";
        public const string PLUGIN_VERSION = "1.0.0";
        public const string PLUGIN_GUID = "games.enchanted.ReservedSoundboardSlot";
    }

    [BepInDependency("FlipMods.ReservedItemSlotCore", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }

        public ManualLogSource PluginLogger;

        private void Awake()
        {
            Instance = this;

            PluginLogger = Logger;

            // Apply Harmony patches (if any exist)
            Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll();

            // Plugin startup logic
            PluginLogger.LogInfo($"Plugin {PluginInfo.PLUGIN_NAME} ({PluginInfo.PLUGIN_GUID}) has been summoned!");

            ReservedItemSlotsCompat.AddItemsToReservedItemSlots();
        }
    }
}
