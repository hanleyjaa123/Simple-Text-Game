﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    public class Player
    {
        Random rand = new Random();
        public string name;
        public int id;
        public int Caps = 0;
        public int health = 100;
        public int damage = 1;
        public int armorValue = 0;
        public int stims = 5;
        public int weaponValue = 1;

        public int mods = 0;

        public int GetHealth()
        {
            int upper = (2 * mods + 5);
            int lower = (mods + 2);
            return rand.Next(lower, upper);
        }
        public int GetPower()
        {
            int upper = (2 * mods + 2);
            int lower = (mods + 1);
            return rand.Next(lower, upper);
        }
        public int GetCaps()
        {
            int upper = (15 * mods + 50);
            int lower = 10 * (mods + 10);
            return rand.Next(lower, upper);

        }

    }
}
