using System;
using Assets.Scripts.Models.Towers;
using NKHook6.API.Towers;
using NKHook6.API.Towers.Upgrades;

namespace NKHook6_Impl.Implementations.Towers
{
    public class NTower : ITower
    {
        private TowerModel towerModel;

        public NTower(TowerModel towerModel) {
            this.towerModel = towerModel;
        }

        /// <summary>
        /// The tower's type. This can be a custom type if it is a modded tower
        /// </summary>
        /// <returns>The tower's type</returns>
        new public string GetType() {
            return this.towerModel.name;
        }
        /// <summary>
        /// Returns the upgrade of the tower
        /// </summary>
        /// <param name="path">The upgrade path</param>
        /// <param name="tier">The upgrade tier</param>
        /// <returns></returns>
        public IUpgrade GetUpgrade(int path, int tier) {
            throw new NotImplementedException("NTower#getUpgrade has not been implemented");
        }
        /// <summary>
        /// Get the base cost of a tower
        /// </summary>
        /// <returns>The base cost of the tower</returns>
        public double GetCost() {
            return this.towerModel.cost;
        }
        /// <summary>
        /// Determines if the tower can be placed in water
        /// </summary>
        /// <returns>True if it can, false if not</returns>
        public bool CanPlaceOnWater() {
            return this.towerModel.IsWaterBased();
        }
        /// <summary>
        /// Determines if the tower can be placed on land
        /// </summary>
        /// <returns>True if it can, false if not</returns>
        public bool CanPlaceOnLand() {
            throw new NotImplementedException("NTower#canPlaceOnLand has not been implemented");
        }
        /// <summary>
        /// Determines if the tower can be placed on paths
        /// </summary>
        /// <returns>True if it can, false if not</returns>
        public bool CanPlaceOnPath() {
            throw new NotImplementedException("NTower#canPlaceOnLand has not been implemented");
        }
        /// <summary>
        /// Determines if the tower can target camo
        /// </summary>
        /// <returns>True if the tower should attack camo</returns>
        public bool CanTargetCamo() {
            throw new NotImplementedException("NTower#canTargetCamo has not been implemented");
        }
        /// <summary>
        /// The radius the tower can attack bloons from
        /// </summary>
        /// <returns>The size of the attack radius</returns>
        public double AttackRadius() {
            throw new NotImplementedException("NTower#attackRadius has not been implemented");
        }
        /// <summary>
        /// Makes the tower ignore the radius limit when attacking. The value of ITower#attackRadius will be the size of the circle when the tower is selected.
        /// </summary>
        /// <returns>True if the tower should have infinite range</returns>
        public bool IsInfiniteRadius() {
            throw new NotImplementedException("NTower#isInfiniteRadius has not been implemented");
        }
        /// <summary>
        /// Determines if the tower should face bloons when attacking
        /// </summary>
        /// <returns>True if the tower should face the bloons its attacking</returns>
        public bool RotateToTarget() {
            throw new NotImplementedException("NTower#rotateToTarget has not been implemented");
        }
    }
}