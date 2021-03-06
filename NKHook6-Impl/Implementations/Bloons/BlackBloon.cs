using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class BlackBloon : NBloon
    {
        public BlackBloon() : base(CGame.instance.getBloonModel("Black"))
        {
        }
        internal BlackBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    