using Assets.Scripts.Unity;
using NKHook6.API;
using NKHook6.API.Bloons;

namespace NKHook6_Tests {
    public class ModBloon : IBloon
    {
        public string getBaseType()
        {
            return "Mod";
        }

        public float getDanger()
        {
            return 2.0f;
        }

        public string getDisplay()
        {
            return Game.instance.model.GetBloon("Green").display;
        }

        public string getIcon()
        {
            return Game.instance.model.GetBloon("Green").display;
        }

        public IBloon.Immunity[] getImmunities()
        {
            throw new System.NotImplementedException();
        }

        public float getLeakDamage()
        {
            return 2.0f;
        }

        public float getMaxHealth()
        {
            return 10.0f;
        }

        public IBloon.Modifier[] getModifiers()
        {
            throw new System.NotImplementedException();
        }

        public float getRadius()
        {
            return 2.0f;
        }

        public float getSpeed()
        {
            return 0.1f;
        }

        public float getSpeedFrames()
        {
            return 1.0f;
        }

        public string[] getTags()
        {
            throw new System.NotImplementedException();
        }

        public string getType()
        {
            return "Mod";
        }

        public bool isInvulnerable()
        {
            return false;
        }

        public bool isRotateable()
        {
            return true;
        }
    }
}