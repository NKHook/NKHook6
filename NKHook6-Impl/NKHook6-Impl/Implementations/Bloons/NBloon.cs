using Assets.Scripts.Models.Bloons;
using NKHook6.API.Bloons;

namespace NKHook6_Impl.Implementations
{
    public class NBloon : IBloon
    {
        private BloonModel bloonModel;
        public NBloon(BloonModel bloonModel)
        {
            this.bloonModel = bloonModel;
        }
        public string getType()
        {
            return this.bloonModel.name;
        }

        public string getBaseType()
        {
            return this.bloonModel.baseId;
        }

        public IBloon.Modifier[] getModifiers()
        {
            throw new System.NotImplementedException();
        }

        public IBloon.Immunity[] getImmunities()
        {
            throw new System.NotImplementedException();
        }

        public float getMaxHealth()
        {
            return this.bloonModel.maxHealth;
        }

        public float getLeakDamage()
        {
            return this.bloonModel.leakDamage;
        }

        public bool isInvulnerable()
        {
            return this.bloonModel.isInvulnerable;
        }

        public float getSpeed()
        {
            return this.bloonModel.speed;
        }

        public float getSpeedFrames()
        {
            return this.bloonModel.speedFrames;
        }

        public float getRadius()
        {
            return this.bloonModel.radius;
        }

        public float getDanger()
        {
            return this.bloonModel.danger;
        }

        public bool isRotateable()
        {
            return this.bloonModel.rotate;
        }

        public string getIcon()
        {
            throw new System.NotImplementedException();
        }

        public string getDisplay()
        {
            throw new System.NotImplementedException();
        }

        public string[] getTags()
        {
            return this.bloonModel.tags;
        }
    }
}