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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int multiplyBy;
        int rnum;
        int userAns;
        int numOfCorrectAnswers = 0;

        public void guestName(string user)  // The 'user' variable is only used inside the method and receives the variable value from Form 1
        {
            label2.Text = user;  //Finally we display the value to a label
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();   //uses built in function Random()
            rnum = rnd.Next(1, 12);  // creates a number between 1 and 12
            textBox2.Text = Convert.ToString(rnum);

            multiplyBy = int.Parse(textBox1.Text);

            textBox2.Text = " What is " + multiplyBy + " times " + rnum + "?\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userAns = int.Parse(textBox3.Text);

            if (userAns == multiplyBy*rnum)
            {

                Form3 form3 = new Form3();
                form3.Show();
                //this.Hide();

                numOfCorrectAnswers = numOfCorrectAnswers + 1;
                correctCounter.Text = numOfCorrectAnswers.ToString() + " correct";
                
            }
            else
            {
                Form4 form4 = new Form4();
                form4.setValue(multiplyBy);
                form4.Show();
                //this.Hide();

            }
        }
    }
}
