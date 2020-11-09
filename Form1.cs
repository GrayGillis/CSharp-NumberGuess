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
        theServiceReference.ServiceClient proxy = new theServiceReference.ServiceClient();
        private int lower;
        private int upper;
        private string userNum;
        private int secretNum;
        public int count;
        public Form1()
        {
            InitializeComponent(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//lower limit
        {
            lower = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//upper limit
        {
            upper = Int32.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//guess
        {
            userNum = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)//generates a #
        {
            secretNum = proxy.SecretNumber(lower, upper);
            count = 0;
            label5.Text = "Attempts: 0";
        }

        private void button2_Click(object sender, EventArgs e)//play
        {
            int guess = Convert.ToInt32(userNum);
            count++;
            string answer = proxy.checkNumber(guess, secretNum);
            label6.Text = "The answer is " + answer;
            label5.Text = "Attempts: " + count;
        }

        private void label5_Click(object sender, EventArgs e)// # of attempts
        {
           
        }

        private void label6_Click(object sender, EventArgs e)// random #
        {
            
        }
    }
}
