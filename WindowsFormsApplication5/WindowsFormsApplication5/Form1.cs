using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] dizi = new int[30];
            Random rnd= new Random[]
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int enb = notlar[0];
            for (int i = 0; i < notlar.lenght; i++)
            {
                if (enb>notlar[i])
                {
                    enb = notlar[i];
                }
                label1.Text = enb.ToString();
            }
        }
        int gecen;
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (int i in notlar)
            {
                if (i>=30)
                {
                    gecen++;
                    
                }
                label1.Text = gecen.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double oran;
            oran = (gecen / 30) * 100;
            label1.Text = oran.ToString();
        }
    }
}
