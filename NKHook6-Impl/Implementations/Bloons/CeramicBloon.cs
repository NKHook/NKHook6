using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class CeramicBloon : NBloon
    {
        public CeramicBloon() : base(CGame.instance.getBloonModel("Ceramic"))
        {
        }
        internal CeramicBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    