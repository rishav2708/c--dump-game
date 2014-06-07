using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private OleDbConnection gameconn;
        private OleDbCommand gameCmd = new OleDbCommand();
        private string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\TOSHIBA\Desktop\game_data.mdb;Persist Security Info=False";
        public Form2()

        {
            gameconn = new OleDbConnection(conn);
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            gameconn.Open();
            gameCmd.Connection = gameconn;
            gameCmd.CommandText = "insert into record([names],[score]) values('" + this.textBox2.Text + "','" + this.textBox1.Text + "');";
            int temp = gameCmd.ExecuteNonQuery();
            if (temp > 0)
            {
                MessageBox.Show("Successfully Registered!!");
            }
            else
                MessageBox.Show("Sorry!!!");
            gameconn.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
