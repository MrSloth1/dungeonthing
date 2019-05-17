using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DungeonSkr
{
    
    class Map
    {
        //make it load 
        public static Cell[,] map = new Cell[2, 3];

        public static void loadMap()
        {
            map[0, 0] = new Cell();
            map[0, 0].name = "spawn";
            map[0, 0].description = "Das ist der spawn";
            map[0, 0].up = true;
            map[0, 0].right = true;

            map[1, 0] = new Cell();
            map[1, 0].name = "rechts vom spawn";
            map[1, 0].description = "Das ist der spawn aber weiter rechts";
            map[1, 0].left = true;
            

            map[0, 1] = new Cell();
            map[0, 1].name = "gang";
            map[0, 1].description = "gang vom spawn weg";
            map[0, 1].down = true;
            map[0, 1].right = true;
            
            

            map[1, 1] = new Cell();
            map[1, 1].name = "zelle";
            map[1, 1].description = "zelle am gang";
            map[1, 1].left = true;

            //map[1, 2] = new Cell("gay", "erster gegner");
            map[1, 2] = new hostileCell("gay", "erster gegner",1);
            
        }

    }

    class Cell
    {
        public string name;
        public string description;
        public NPC npc = null;
        //possible ways
        public bool left = false;
        public bool right = false;
        public bool up = false;
        public bool down = false;

        public Cell()
        {

        }
        public Cell(string name, string description,bool up = false,bool down = false, bool left = false, bool right = false)
        {
            this.name = name;
            this.description = description;
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
        }
    }

    class hostileCell : Cell
    {
        public int level;
        public int spawnChance;
        public hostileCell()
        {

        }
        public hostileCell(string name, string description,int level,int spawnChance = 30,bool up = false,bool down = false, bool left = false, bool right = false)
        {
            this.name = name;
            this.description = description;
            this.level = level;
            this.spawnChance = spawnChance;
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
        }

    }
}
