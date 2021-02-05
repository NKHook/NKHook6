
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class WhiteBloon : NBloon
    {
        public WhiteBloon() : base(Game.instance.getBloonModel("White"))
        {
        }
        internal WhiteBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}
    