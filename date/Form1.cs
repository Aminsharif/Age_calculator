using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime age = DateTime.Parse(textBox1.Text);

            DateTime current = System.DateTime.Now;
            int year = current.Year - age.Year;
            int month = current.Month - age.Month;
            int day = current.Day - age.Day;

            if (month < 0)
            {
                month += 12;
                year--;
            }
            if (day < 0)
            {
                day += DateTime.DaysInMonth(current.Year, current.Month);
                month--;
            }


            //int ag = DateTime.Now.Subtract(age).Days;
            //int ye = ag / 365;
            //int mo = ag % 365;
            //int mon = mo / 30;
            //int da = mo % 30;

            label3.Text = year.ToString();
            label5.Text = month.ToString();
            label8.Text = day.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
