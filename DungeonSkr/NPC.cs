using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonSkr
{
    abstract class NPC
    {
        string name;

    }

    abstract class Enemy : NPC
    {
        int health;
        int level;
        Weapons weapon;
        Wearables armor;


        //TODO: stats
        
    }


}
