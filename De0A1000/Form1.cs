using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De0A1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

 
        public int[] results = new int[50];
        public int min = 0;
        public int max = 51;
        int element;

        public void doRandom()
        {
            for (int i=0; i<results.Length; i++)
            {
                element = random.Next(min, max);
                while(results.Contains(element))
                {
                    element = random.Next(min, max);
                }
                results[i] = element;
            }
            Array.Sort(results);
        }

        private void do_random_Click(object sender, EventArgs e)
        {
            doRandom();
            for(int i=0; i<50; i++)
            {
                textBox1.Text += results[i].ToString() + " | ";
            }
        }
   
        

    }
}
