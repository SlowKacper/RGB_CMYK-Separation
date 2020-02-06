using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj3
{
    public partial class Form2 : Form
    {
        public Form2(Bitmap Magenta, Bitmap Yellow, Bitmap Cyan, Bitmap Black)
        {

            InitializeComponent();
            Magenta = new Bitmap(Magenta, pictureBox2.Width, pictureBox2.Height);
            Yellow = new Bitmap(Yellow, pictureBox3.Width, pictureBox3.Height);
            Cyan = new Bitmap(Cyan, pictureBox1.Width, pictureBox1.Height);
            Black = new Bitmap(Black, pictureBox4.Width, pictureBox4.Height);
            pictureBox1.Image = Cyan;
            pictureBox2.Image = Magenta;
            pictureBox3.Image = Yellow;
            pictureBox4.Image = Black;
        }
    }
}
