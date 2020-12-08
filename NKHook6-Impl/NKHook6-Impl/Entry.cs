using System.Collections.Generic;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using MelonLoader;
using NKHook6.API;
using NKHook6.API.Bloons;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6_Impl.Extensions;
using NKHook6_Impl.Implementations.Bloons;

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

        [EventAttribute("BloonCreatedEvent")]
        public static void onCreated(BloonEvents.CreatedEvent e)
        {
            Logger.Log("Bloon created event");
            IBloon bloonType = e.getBloon().getType();
            if (bloonType is RedBloon)
            {
                RedBloon newType = (RedBloon)bloonType;
                Logger.Log("The bloon was a red bloon");
            }
        }
        
        [EventAttribute("BloonLeakedEvent")]
        public static void onLeaked(BloonEvents.LeakedEvent e)
        {
            Logger.Log("Bloon leaked event");
        }
        
        [EventAttribute("BloonMoveEvent")]
        public static void onMove(BloonEvents.MoveEvent e)
        {
            IBloonEntity bloon = e.getBloon();
            //Logger.Log("Progress: "+bloon.getProgress());
            float[] pos = bloon.getPosition();
            //Logger.Log("Position (X,Y,Z)".Replace("X", pos[0].ToString()).Replace("Y", pos[1].ToString()).Replace("Z", pos[2].ToString()));
            if (bloon.getProgress() > 500)
            {
                e.SetCancelled(true);
            }
        }

        [EventAttribute("BloonRotateEvent")]
        public static void onRotate(BloonEvents.RotateEvent e)
        {
            IBloonEntity bloon = e.getBloon();
            Logger.Log(bloon.getRotation().ToString());
        }

        public void onModLoaded()
        {
            Game game = Game.instance;
            List<BloonModel> models = game.getAllBloonModels();
            foreach (var model in models)
            {
                Logger.Log(model.name);
            }
            EventRegistry.instance.listen(typeof(Entry));
        }
    }
}