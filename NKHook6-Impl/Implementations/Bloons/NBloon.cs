using CGame = Assets.Scripts.Unity.Game;
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
        new public virtual string GetType()
        {
            return this.bloonModel.name;
        }

        public virtual string GetBaseType()
        {
            return this.bloonModel.baseId;
        }

        public virtual IBloon.Modifier[] GetModifiers()
        {
            throw new System.NotImplementedException();
        }

        public virtual IBloon.Immunity[] GetImmunities()
        {
            throw new System.NotImplementedException();
        }

        public virtual float GetMaxHealth()
        {
            return this.bloonModel.maxHealth;
        }

        public virtual float GetLeakDamage()
        {
            return this.bloonModel.leakDamage;
        }

        public virtual bool IsInvulnerable()
        {
            return this.bloonModel.isInvulnerable;
        }

        public virtual float GetSpeed()
        {
            return this.bloonModel.speed;
        }

        public virtual float GetSpeedFrames()
        {
            return this.bloonModel.speedFrames;
        }

        public virtual float GetRadius()
        {
            return this.bloonModel.radius;
        }

        public virtual float GetDanger()
        {
            return this.bloonModel.danger;
        }

        public virtual bool IsRotateable()
        {
            return this.bloonModel.rotate;
        }

        public virtual string GetIcon()
        {
            throw new System.NotImplementedException();
        }

        public virtual string GetDisplay()
        {
            throw new System.NotImplementedException();
        }

        public virtual string[] GetTags()
        {
            return this.bloonModel.tags;
        }
    }
}