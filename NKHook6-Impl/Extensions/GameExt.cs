﻿using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Models.Towers;
using CGame = Assets.Scripts.Unity.Game;

namespace NKHook6_Impl.Extensions
{
    public static class GameExt 
    {
        public static BloonModel getBloonModel(this CGame game, string bloonName)
        {
            return game.model.GetBloon(bloonName);
        }
        public static List<BloonModel> getAllBloonModels(this CGame game)
        {
            return game.model.bloons.ToList<BloonModel>();
        }

        public static TowerModel getTowerModel(this CGame game, string towerID, int pathATier = 0, int pathBTier = 0, int pathCTier = 0)
        {
            return game.model.GetTower(towerID, pathATier, pathBTier, pathCTier);
        }
        public static List<TowerModel> getAllTowerModels(this CGame game)
        {
            return game.model.towers.ToList<TowerModel>();
        }
    }
}