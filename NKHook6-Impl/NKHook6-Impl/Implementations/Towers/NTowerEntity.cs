using System;
using System.Linq;
using System.Reflection;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Simulation.SMath;
using Assets.Scripts.Simulation.Towers;
using NKHook6.API.Bloons;
using NKHook6.API.Towers;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class NTowerEntity : ImplementationInstanceBase<Tower, NTower, TowerModel>, IBloonEntity
    {
        public NTowerEntity(Tower theTower) : base(theTower)
        {
            
        }

        public ITower getType()
        {
            string className = theTower.towerModel.name+"Tower";
            var types = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.Namespace.StartsWith("NKHook6_Impl.Implementations.Bloons"));

            foreach (Type classType in types)
            {
                if (classType.Name == className)
                {
                    NTower towerWithType = (NTower)Activator.CreateInstance(classType);
                    return towerWithType;
                }
            }

            return new NTower(theBloon.bloonModel);
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
        
        public float getRotation()
        {
            return this.theBloon.Rotation;
        }
    }
}