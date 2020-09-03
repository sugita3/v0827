using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10, 11);
        int vy = rand.Next(-10, 11);

        int point=100;
        static Random rand = new Random();
        
       

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label1.Width);
            label2.Top = rand.Next(ClientSize.Height - label1.Height);

            label3.Left = rand.Next(ClientSize.Width - label1.Width);
            label3.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Left = vx;
            label1.Top = vy;

            label2.Left = vx;
            label2.Top = vy;

            label3.Left = vx;
            label3.Top = vy;

            point--;
            label3.Text = "Score" + point;

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }


            Point mp = MousePosition;
            mp = PointToClient(mp);
            label2.Text = "" + mp.X + "," + mp.Y;

            if ((mp.X >= label1.Left)
                && (mp.X < label1.Right)
                && (mp.Y >= label1.Top)
                && (mp.Y < label1.Bottom))
            {
                timer1.Enabled = false;
            }

           
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
