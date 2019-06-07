using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonSkr
{
    public abstract class NPC
    {
        public string name;

    }

    public class Combatant : NPC
    {
        public int health;
        public int level;
        public int dmg;
        public int defense;
        public int evasion;
        public int precision;
        Weapons weapon;
        Wearables armor;
    }
    public class Enemy : Combatant
    {
        


        public Enemy(string name, int health,int level)
        {
            this.name = name;
            this.health = health;
            this.level = level;

        }
    }





}
