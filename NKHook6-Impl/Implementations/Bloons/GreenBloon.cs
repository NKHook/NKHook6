using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class GreenBloon : NBloon
    {
        public GreenBloon() : base(CGame.instance.getBloonModel("Green"))
        {
        }
        internal GreenBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    