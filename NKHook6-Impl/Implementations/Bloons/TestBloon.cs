
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class TestBloon : NBloon
    {
        public TestBloon() : base(Game.instance.getBloonModel("TestBloon"))
        {
        }
    }
}
    