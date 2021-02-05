using Assets.Scripts.Models.Bloons;
using NKHook6.API.Bloons;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class NBloon : IBloon
    {
        private BloonModel bloonModel;
        public NBloon()
        {
        }
        public NBloon(BloonModel bloonModel)
        {
            this.bloonModel = bloonModel;
        }
        public virtual string getType()
        {
            return this.bloonModel.name;
        }

        public virtual string getBaseType()
        {
            return this.bloonModel.baseId;
        }

        public virtual IBloon.Modifier[] getModifiers()
        {
            throw new System.NotImplementedException();
        }

        public virtual IBloon.Immunity[] getImmunities()
        {
            throw new System.NotImplementedException();
        }

        public virtual float getMaxHealth()
        {
            return this.bloonModel.maxHealth;
        }

        public virtual float getLeakDamage()
        {
            return this.bloonModel.leakDamage;
        }

        public virtual bool isInvulnerable()
        {
            return this.bloonModel.isInvulnerable;
        }

        public virtual float getSpeed()
        {
            return this.bloonModel.speed;
        }

        public virtual float getSpeedFrames()
        {
            return this.bloonModel.speedFrames;
        }

        public virtual float getRadius()
        {
            return this.bloonModel.radius;
        }

        public virtual float getDanger()
        {
            return this.bloonModel.danger;
        }

        public virtual bool isRotateable()
        {
            return this.bloonModel.rotate;
        }

        public virtual string getIcon()
        {
            throw new System.NotImplementedException();
        }

        public virtual string getDisplay()
        {
            throw new System.NotImplementedException();
        }

        public virtual string[] getTags()
        {
            return this.bloonModel.tags;
        }
    }
}