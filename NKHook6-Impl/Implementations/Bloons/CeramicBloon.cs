
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class CeramicBloon : NBloon
    {
        public CeramicBloon() : base(Game.instance.getBloonModel("Ceramic"))
        {
        }
        internal CeramicBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}
    