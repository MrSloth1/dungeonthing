using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonSkr
{
    class Player : Combatant
    {
        TextBox descBox;
        public bool inCombat = false;
        Inventory PlayerInventory;
        static int x = 0;
        static int y = 0;

        double experience = 0;

        



        public Player(TextBox tbox)
        {
            descBox = tbox;
            
        }
        
        public void moveRight()
        {
            
            if (Map.map[x, y].right && !inCombat)
            {
                x++;
                renderCell(x, y, descBox);
                scanEnemies(x, y);
            }
        }
        public void moveLeft()
        {
            if (Map.map[x, y].left && !inCombat)
            {
                x--;
                renderCell(x, y, descBox);
                scanEnemies(x, y);
            }
        }
        public void moveUp()
        {
            if (Map.map[x, y].up && !inCombat)
            {
                y++;
                renderCell(x, y, descBox);
                scanEnemies(x, y);
            }
        }
        public void moveDown()
        {
            if (Map.map[x, y].down && !inCombat)
            {
                y--;
                renderCell(x, y, descBox);
                scanEnemies(x, y);
            }
        }


        public void renderCell(int x, int y, TextBox tbox)
        {
            tbox.Text = Map.map[x, y].description;
        }

        public void render(string text)
        {
            descBox.Text = text;
        }

        public void scanEnemies(int x,int y)
        {
           if (Map.map[x, y] is hostileCell)
           {
               hostileCell hc = Map.map[x, y] as hostileCell;
               Random r = new Random();
               if(r.Next(100) <= hc.spawnChance)
               {
                   Combat com = new Combat(this);

               }
           }
                
        }
    }
}
