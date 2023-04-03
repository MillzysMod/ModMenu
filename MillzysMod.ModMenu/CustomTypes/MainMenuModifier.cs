using System;
using MelonLoader;
using UnityEngine;

namespace MillzysMod.ModMenu.CustomTypes
{
    [RegisterTypeInIl2Cpp]
    public class MainMenuModifier : MonoBehaviour
    {
        public static void Begin()
        {
            var go = new GameObject("MillzysMod.ModMenu MenuModifier");
            go.AddComponent<MainMenuModifier>();
        }
        
        private void Start()
        {
            // TODO: Add new button
            // TODO: Add asset bundle screen and add components
        }
    }
}