using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class BadBloon : NBloon
    {
        public BadBloon() : base(CGame.instance.getBloonModel("Bad"))
        {
        }
        internal BadBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    