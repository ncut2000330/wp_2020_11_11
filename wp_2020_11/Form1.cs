using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wp_2020_11.Properties;

namespace wp_2020_11
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        int a , b ;
        int player1 = 0, player2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(Resources._2);
            list.Add(Resources._3);
            list.Add(Resources._4);
            list.Add(Resources._6);
            list.Add(Resources._5);
            list.Add(Resources._7);
            list.Add(Resources._8);
            list.Add(Resources._9);
            list.Add(Resources._10);
            list.Add(Resources._11);
            list.Add(Resources._12);
            list.Add(Resources._13);
            list.Add(Resources._14);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            int index = new Random().Next(13);//模擬隨機產生 一個值;
            pictureBox1.Image = list[index];
            a = index+1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index2 = new Random().Next(13);//模擬隨機產生 一個值;
            pictureBox2.Image = list[index2];
            b = index2+1;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            

            if (a > b)
            {
                MessageBox.Show($"{a}>{b}", "P1贏了", MessageBoxButtons.OK);
                player1 = player1 + 1;
            }
            else if (a < b)
            {
                MessageBox.Show($"{b}>{a}", "P2贏了", MessageBoxButtons.OK);
                player2 = player2 + 1;
            }
            else if (a == b)
            {
                MessageBox.Show($"{b}={a}", "平手", MessageBoxButtons.OK);
            }
            richTextBox1.Text = "player1贏的次數" + player1 ;
            richTextBox2.Text = "player2贏的次數" + player2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player1 = 0;
            player2 = 0;
            richTextBox1.Text = "player1贏的次數" + player1;
            richTextBox2.Text = "player2贏的次數" + player2;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
