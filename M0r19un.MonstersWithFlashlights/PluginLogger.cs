using BepInEx.Logging;

using System;
using System.Collections.Generic;
using System.Text;

namespace M0r19un.MonstersWithFlashlights
{
    internal static class PluginLogger
    {
        internal static ManualLogSource logSource;

        public static void Initialize(string modGUID) => PluginLogger.logSource = Logger.CreateLogSource(modGUID);

        public static void Log(object message) => PluginLogger.logSource.LogInfo(message);

        public static void LogError(object message) => PluginLogger.logSource.LogError(message);

        public static void LogWarning(object message) => PluginLogger.logSource.LogWarning(message);
    }
}
