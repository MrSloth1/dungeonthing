using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonSkr
{
    public partial class Form1 : Form
    {
        Player p;
        public Form1()
        {
            InitializeComponent();
            Map.loadMap();
            p = new Player(descriptionBox);
            p.renderCell(0, 0,descriptionBox);
            p.scanEnemies();
        }



        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxBitchFuerAlles.Text = e.KeyChar.ToString();
            
        }

        public string descBox
        {
            get
            {
                return descriptionBox.Text;
            }
            set
            {
                descriptionBox.Text = value;
            }
        }

        private void UpButt_Click(object sender, EventArgs e)
        {
            p.moveUp();
        }

        private void DownButt_Click(object sender, EventArgs e)
        {
            p.moveDown();
        }

        private void RightButt_Click(object sender, EventArgs e)
        {
            p.moveRight();
        }

        private void LeftButt_Click(object sender, EventArgs e)
        {
            p.moveLeft();
        }
    }
}
