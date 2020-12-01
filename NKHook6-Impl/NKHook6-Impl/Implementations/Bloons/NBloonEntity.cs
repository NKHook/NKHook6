using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Simulation.SMath;
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
            return this.theBloon.distanceTraveled;
        }

        public float[] getPosition()
        {
            Vector3Boxed pos = this.theBloon.Position;
            float[] posF = new[] {pos.X, pos.Y, pos.Z};
            return posF;
        }
    }
}