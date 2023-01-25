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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "999")
            {
                Form2 form2 = new Form2();
                form2.guestName(textBox1.Text);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect details. Please Try Again.");
               
               
            }
            
        }
    }
}
