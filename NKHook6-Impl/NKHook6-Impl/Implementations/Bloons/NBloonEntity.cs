using Assets.Scripts.Simulation.Bloons;
using NKHook6.API.Bloons;

namespace NKHook6_Impl.Implementations
{
    public class NBloonEntity : IBloonEntity
    {
        private Bloon theBloon;
        public NBloonEntity(Bloon theBloon)
        {
            this.theBloon = theBloon;
        }

        public IBloon getType()
        {
            throw new System.NotImplementedException();
        }

        public float getProgress()
        {
            throw new System.NotImplementedException();
        }

        public float[] getPosition()
        {
            throw new System.NotImplementedException();
        }
    }
}