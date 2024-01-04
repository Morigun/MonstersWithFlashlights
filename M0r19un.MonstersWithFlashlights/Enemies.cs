using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace M0r19un.MonstersWithFlashlights
{
    public class Enemies
    {
        public static void Init()
        {
            On.StartOfRound.Awake += StartOfRound_Awake;
            PluginLogger.Log("Enemies inited!");
        }

        private static void StartOfRound_Awake(On.StartOfRound.orig_Awake orig, StartOfRound self)
        {
            PluginLogger.Log("StartOfRound_Awake");
            orig(self);
            
            foreach(var level in self.levels)
            {
                var name = level.name;
                PluginLogger.Log($"Level:{name}");

                foreach (var enemy in level.Enemies)
                {
                    var enemyName = enemy.enemyType.enemyName;
                    enemy.enemyType.enemyPrefab.AddComponent<Light>();
                    enemy.enemyType.enemyPrefab.GetComponent<Light>().intensity = 200f;

                    PluginLogger.Log($"Level:{name}, enemy:{enemyName}");
                }
            }
        }
    }
}
