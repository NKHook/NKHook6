using System;
using System.Linq;
using System.Reflection;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Simulation.SMath;
using Assets.Scripts.Simulation.Towers;
using NKHook6.API.Towers;

namespace NKHook6_Impl.Implementations.Towers
{
    public class NTowerEntity : ITowerEntity
    {
        private Tower theTower;
        public NTowerEntity(Tower theTower)
        {
            this.theTower = theTower;
        }

        public ITower GetTower()
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

            return new NTower(this.theTower.towerModel);
        }

        public float[] GetPosition()
        {
            Vector3Boxed pos = this.theTower.Position;
            float[] posF = new[] {pos.X, pos.Y, pos.Z};
            return posF;
        }

        public bool IsUpgradePurchased(int path, int tier) {
            return theTower.GetUpgrade(path).tier >= tier;
        }
    }
}