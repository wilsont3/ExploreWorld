﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreWorld
{
    class Tile
    {
        //This class is used for the different tiles in the world
        private string terrain; // This will tell what the type of terrain is
        private float speedModifer; // This will be used as a multiplier
        private int healthModifer; // This will be used to add to the health (a negative number will reduce health)
        private bool isPassable; // This will be used to determine whether you can occupy this tile

        //Class constructor
        public Tile(string myTerrain, float mySpeedModifer, int myHealthModifer, bool myIsPassable)
        {
            terrain = myTerrain;
            speedModifer = mySpeedModifer;
            healthModifer = myHealthModifer;
            isPassable = myIsPassable;
        }

        public string getTerrain()
        {
            return terrain;
        }

        public bool getIsPassable()
        {
            return isPassable;
        }

        public int getHealthModifer()
        {
            return healthModifer;
        }
    }
}
