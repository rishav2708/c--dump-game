using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Dump_professors : Form
    {
        int x;
        int y;
        int score = 0;
        int time = 50;
        public Dump_professors()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }


        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (e.Button == MouseButtons.Left)
            {
                c.Left += e.X - x;
                c.Top += e.Y - y;
            }
            if (c.Location == remove.Location)
            {
                c.Hide();
                score = score + 1;
            }
            textBox1.Text = score.ToString();


        }

        private void mouse_up(object sender, MouseEventArgs e)
        {
            
  
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

 

        private void hit_professors_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("throw proffessors and earn the points in the given interval!!");
            timer1.Start();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("This is copyrighted by Rishav Sharma");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                label2.Text = time.ToString();
            }
            else
            {
                timer1.Stop();
                label2.Text = "TImes...Up!!!";
                MessageBox.Show("Your score is "+textBox1.Text);
                Application.Exit();
            }

            
                    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {

        }

        private void view_score_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Form2 form = new Form2();
            form.textBox1.Text = textBox1.Text;
            form.Show();
           }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
