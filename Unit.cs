using System;
using System.Collections.Generic;
using System.Text;

namespace dungeonsDragons
{
    public class Unit
    {
        //fields for the unit class
        private string name;
        private int hp;
        private int strength;
        private int speed;
        private int defense;
        private int dexterity;
        private List<Object> inventory;
        protected bool isGood;

        //get methods
        public string getName()
        {
            return name;
        }
        public int getHP()
        {
            return hp;
        }
        public int getStr()
        {
            return strength;
        }
        public int getSpd()
        {
            return speed;
        }
        public int getDef()
        {
            return defense;
        }
        public int getDex()
        {
            return dexterity;
        }
        public List<Object> getInv()
        {
            return inventory;
        }

        //Set methods
        public void setName(string n)
        {
            name = n;
        }

        public void setHP(int h)
        {
            hp = h;
        }

        public void setDef(int d)
        {
            defense = d;
        }
        public void setDex(int d)
        {
            dexterity = d;
        }


        //checks if unit has 0 hp
        public bool isDead()
        {
            return (hp == 0);
        }

        //add item to inventory
        public void pickUp(Object i)
        {
            inventory.Add(i);
        }

    }
}