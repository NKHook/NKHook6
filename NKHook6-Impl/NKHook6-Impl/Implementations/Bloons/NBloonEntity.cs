using System;
using System.Linq;
using System.Reflection;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Simulation.SMath;
using Mono.CSharp;
using NKHook6.API.Bloons;

namespace NKHook6_Impl.Implementations.Bloons
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
            string className = theBloon.bloonModel.name+"Bloon";
            var types = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.Namespace.StartsWith("NKHook6_Impl.Implementations.Bloons"));

            foreach (Type classType in types)
            {
                if (classType.Name == className)
                {
                    NBloon bloonWithType = (NBloon)Activator.CreateInstance(classType);
                    return bloonWithType;
                }
            }

            return new NBloon(theBloon.bloonModel);
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