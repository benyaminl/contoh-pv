using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contoh
{
    public partial class Form1 : Form
    {
        List<Rectangle> buttons = new List<Rectangle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Blue;
            Random r = new Random();
            int i = r.Next(0, buttons.Count);
            Rectangle b = buttons[i];
            //buttons[i].X += 10;
            b.X += 10;
            b.Y += 10;
            buttons[i] = b;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i= 0; i< 10; i++)
            {
                Button b = new Button();
                buttons.Add(b);
                b.Top = 5 * r.Next(10, 200);
                b.Left = 5 * r.Next(10, 200);
                b.Parent = this;
            }
        }


    }
}
