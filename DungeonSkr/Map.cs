using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonSkr
{
    enum cellType { friendly, neutral, hostile }; 
    
    class Map
    {
        //make it load 
        Cell[,] map = new Cell[1, 2];

        public void loadMap()
        {
            
        }
    }

    class Cell
    {
        string name;
        string description;
        public cellType typ;
        NPC npc;
        //possible ways
        bool left;
        bool right;
        bool up;
        bool down;

        
    }
}
