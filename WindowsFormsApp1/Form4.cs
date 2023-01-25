using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int multiplyBy;
        int sum;

        public void setValue(int temporary)
        {
            multiplyBy = temporary;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
            // times table calculation
            // for (int i = loopStart; i <= loopEnd; i++)
            for (int i = 1; i <= 12; i++)
            {
               sum = i * multiplyBy;
            
               textBox4.Text += i + " times " + multiplyBy + " = " + sum + "\r\n";
            }

             
        }
    }
}
