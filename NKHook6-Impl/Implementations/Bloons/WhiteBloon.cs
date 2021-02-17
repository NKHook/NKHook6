using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class WhiteBloon : NBloon
    {
        public WhiteBloon() : base(CGame.instance.getBloonModel("White"))
        {
        }
        internal WhiteBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    