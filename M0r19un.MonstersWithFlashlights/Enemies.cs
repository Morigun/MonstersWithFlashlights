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
            LC_Lib.M0r19unLogger.Log("Enemies inited!");
        }

        private static void StartOfRound_Awake(On.StartOfRound.orig_Awake orig, StartOfRound self)
        {
            LC_Lib.M0r19unLogger.Log("StartOfRound_Awake");
            orig(self);
            
            foreach(var level in self.levels)
            {
                var name = level.name;
                LC_Lib.M0r19unLogger.Log($"Level:{name}");

                foreach (var enemy in level.Enemies)
                {
                    var enemyName = enemy.enemyType.enemyName;
                    enemy.enemyType.enemyPrefab.AddComponent<Light>();
                    enemy.enemyType.enemyPrefab.GetComponent<Light>().intensity = 200f;

                    LC_Lib.M0r19unLogger.Log($"Level:{name}, enemy:{enemyName}");
                }
            }
        }
    }
}
