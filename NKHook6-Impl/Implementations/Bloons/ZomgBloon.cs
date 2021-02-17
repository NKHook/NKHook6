using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class ZomgBloon : NBloon
    {
        public ZomgBloon() : base(CGame.instance.getBloonModel("Zomg"))
        {
        }
        internal ZomgBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    