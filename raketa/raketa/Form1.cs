using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raketa
{
    public partial class Form1 : Form
    {
        public const int N_max = 200;
        public Player player = new Player();
        public Boolean laser = false;
        public Bitmap imageeP;
        public int Result = 0;
        public Graphics g;
        public BrushColor bc = new BrushColor();
        public Enemies nlo = new Enemies(); 

        public Form1()
        {
            InitializeComponent();
        }
        //public void New_player(Form1 F)
        //{
        //    size = F.imageeP.Size;
        //    point.X = 0;
        //    point.Y = 0;
        //    Rectangle rec = new Rectangle(point, size);
        //    reg = new Regiom(rec);
        //    laser_pen = new Pen(new HatchBrush)
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void лазерToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void стопToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
