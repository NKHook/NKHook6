
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class ZebraBloon : NBloon
    {
        public ZebraBloon() : base(Game.instance.getBloonModel("Zebra"))
        {
        }
        internal ZebraBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}
    