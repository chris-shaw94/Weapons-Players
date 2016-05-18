﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsPlayers
{
    public class playerObject
    {
        public string name;
        int lives;
        public List<weaponObject> inventory; 
        public playerObject(string name, int lives, List<weaponObject> inventory)
        {
            this.name = name;
            this.lives = lives;
            this.inventory = inventory;
        }

        public void makeInv( weaponObject weap1, weaponObject weap2, weaponObject weap3)
        {
            this.inventory.Add(weap1);
            this.inventory.Add(weap2);
            this.inventory.Add(weap3);
        }
    }
}
