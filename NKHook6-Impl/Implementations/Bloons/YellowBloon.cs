using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class YellowBloon : NBloon
    {
        public YellowBloon() : base(Game.instance.getBloonModel("Yellow"))
        {
        }
        internal YellowBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}