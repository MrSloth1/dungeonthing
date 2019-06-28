using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace DungeonSkr
{
    
    class Map
    {

       
        //make it load 
        static FileStream loadmap = new FileStream(Directory.GetCurrentDirectory() + "/maps/Testebene.txt", FileMode.Open, FileAccess.Read);
        static StreamReader mapreader = new StreamReader(loadmap);
        static int x = Convert.ToInt32( mapreader.ReadLine());
        static int y = Convert.ToInt32(mapreader.ReadLine());
        public static Cell[,] map = new Cell[x, y];
        
        public static void loadMap()
        {
           
            
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    
                    map[j, i] = new Cell();
                    map[j, i].name = mapreader.ReadLine();
                    map[j, i].description = mapreader.ReadLine();
                    while (mapreader.Peek()!='x')
                    {
                        switch (mapreader.Read())
                        {
                            case 'u': map[j, i].up = true;
                                break;
                            case 'r': map[j, i].right = true;
                                break;
                            case 'l': map[j, i].left = true;
                                break;
                            case 'd': map[j, i].down = true;
                                break;
                            case 'n': map[j, i].npcid.Add(mapreader.ReadLine());
                                break;
                            case 'i': map[j, i].itemid.Add(mapreader.ReadLine());
                                break;
                             
                        }
                    }
                    

                }
            }
            
            /*
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
            //map[1, 2] = new hostileCell("gay", "erster gegner",1);
            */
        }

    }

    class Cell
    {
        public string name;
        public string description;
        public List<string> npcid = new List<string>(0);
        public List<string> itemid = new List<string>(0);
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
