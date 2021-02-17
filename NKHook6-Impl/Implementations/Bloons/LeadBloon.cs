using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class LeadBloon : NBloon
    {
        public LeadBloon() : base(CGame.instance.getBloonModel("Lead"))
        {
        }
        internal LeadBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    