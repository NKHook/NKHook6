using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class GreenBloon : NBloon
    {
        public GreenBloon() : base(Game.instance.getBloonModel("Green"))
        {
        }
        internal GreenBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}