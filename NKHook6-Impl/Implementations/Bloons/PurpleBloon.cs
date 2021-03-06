using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class PurpleBloon : NBloon
    {
        public PurpleBloon() : base(CGame.instance.getBloonModel("Purple"))
        {
        }
        internal PurpleBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    