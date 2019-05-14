using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonSkr
{
    class Player
    {
        TextBox descBox;
        public Player(TextBox tbox)
        {
            descBox = tbox;
        }
        Inventory PlayerInventory;

        static int x = 0;
        static int y = 0;

        public void moveRight()
        {
            if (Map.map[x, y].right)
            {
                x++;
                renderCell(x, y, descBox);
                
            }
        }
        public void moveLeft()
        {
            if (Map.map[x, y].left)
            {
                x--;
                renderCell(x, y, descBox);

            }
        }
        public void moveUp()
        {
            if (Map.map[x, y].up)
            {
                y++;
                renderCell(x, y, descBox);

            }
        }
        public void moveDown()
        {
            if (Map.map[x, y].down)
            {
                y--;
                renderCell(x, y, descBox);

            }
        }


        public void renderCell(int x, int y, TextBox tbox)
        {


            tbox.Text = Map.map[x, y].description;
        }
    }
}
