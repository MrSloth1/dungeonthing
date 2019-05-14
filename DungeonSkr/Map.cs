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
        public static Cell[,] map = new Cell[2, 2];

        public static void loadMap()
        {
            map[0, 0] = new Cell();
            map[0, 0].name = "spawn";
            map[0, 0].description = "Das ist der spawn";
            map[0, 0].typ = cellType.friendly;
            map[0, 0].up = true;
            map[0, 0].right = true;

            map[1, 0] = new Cell();
            map[1, 0].name = "rechts vom spawn";
            map[1, 0].description = "Das ist der spawn aber weiter rechts";
            map[1, 0].typ = cellType.friendly;
            map[1, 0].left = true;
            

            map[0, 1] = new Cell();
            map[0, 1].name = "gang";
            map[0, 1].description = "gang vom spawn weg";
            map[0, 1].typ = cellType.friendly;
            map[0, 1].down = true;
            map[0, 1].right = true;

            map[1, 1] = new Cell();
            map[1, 1].name = "zelle";
            map[1, 1].description = "zelle am gang";
            map[1, 1].typ = cellType.friendly;
            map[1, 1].left = true;

            
        }
    }

    class Cell
    {
        public string name;
        public string description;
        public cellType typ;
        public NPC npc = null;
        //possible ways
        public bool left = false;
        public bool right = false;
        public bool up = false;
        public bool down = false;

        
    }
}
