﻿using Assets.Scripts.Unity;
using MelonLoader;
using NKHook6.API;
using NKHook6.API.Events;

namespace NKHook6_Impl
{
    public class Entry : MelonMod, BTDModStart
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Logger.Log("Starting NKHook6 API Implementation");

            new EventRegistry(); //Initialize EventRegistry

            Logger.Log("Google translate of NKHook6 API to TARGET has begun".Replace("TARGET", "BloonsTD6"));
        }

        public void onModLoaded()
        {
            EventRegistry.instance.listen(typeof(Entry));
            foreach(var bloon in Game.instance.model.bloons) {
                Logger.Log(bloon.name);
            }
        }
    }
}