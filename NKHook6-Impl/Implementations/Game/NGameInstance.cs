using System;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.API.Game;

namespace KHook6_Impl.Implementations.Game
{
    public class NGameInstance : IGameInstance
    {
        private static NGameInstance gameInstance;
        public static NGameInstance GetGame()
        {
            if(gameInstance == null)
            {
                InGame inGame = InGame.instance;
                if(inGame == null)
                {
                    throw new("Cannot get NGameInstance without being in a game!");
                }
                gameInstance = new(inGame);
            }
            return gameInstance;
        }


        private InGame inGame;
        private NGameInstance(InGame inGame)
        {
            this.inGame = inGame;
        }

        public InGame GetNative()
        {
            return inGame;
        }


        public double GetHealth()
        {
            return inGame.bridge.GetHealth();
        }

        public IMap GetMap()
        {
            throw new System.NotImplementedException();
        }

        public IPlayer GetPlayer()
        {
            throw new System.NotImplementedException();
        }

        public IPlayer GetPlayer(int index)
        {
            throw new System.NotImplementedException();
        }

        public void Lose()
        {
            inGame.Loose();
        }

        public void SetHealth(double value) {
            inGame.bridge.simulation.health.Value = value;
        }
    }
}