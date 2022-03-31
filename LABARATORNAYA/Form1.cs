using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABARATORNAYA
{
    public partial class Form1 : Form
    {
        String[] imglist = new String[]
                     {"0.jpg","1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg"};
        int index = 0;
        Country[] countries = new Country[5];


        public Form1()
                     {
            InitializeComponent();

            Country country = new Country();
            country.setCountryCode("ARG");
            country.setCountryName("Argentina");
            countries[0] = country;



            country.setCountryCode("AT");
            country.setCountryName("Austria");
            countries[1] = country;


            country.setCountryCode("AUS");
            country.setCountryName("Australia");
            countries[2] = country;


            country.setCountryCode("BI");
            country.setCountryName("Bosnia");
            countries[3] = country;


            country.setCountryCode("BIH");
            country.setCountryName("Bosnia Herzegovina");
            countries[4] = country;


                     }
             {
        








             }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form2();
            adminForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            pictureBox1.Load("../../../Picture/" + imglist[0]);
            pictureBox2.Load("../../../Picture/" + imglist[1]);
            pictureBox3.Load("../../../Picture/" + imglist[2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 3 > imglist.Length) index = 0;
            pictureBox1.Load("../../Picture/" + imglist[index + 0]);
            pictureBox2.Load("../../Picture/" + imglist[index + 1]);
            pictureBox3.Load("../../Picture/" + imglist[index + 2]);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            index = index - 1;
            if (index + 0 < imglist.Length) index = 0;
            pictureBox1.Load("../../Picture/" + imglist[index + 0]);
            pictureBox2.Load("../../Picture/" + imglist[index + 1]);
            pictureBox3.Load("../../Picture/" + imglist[index + 2]);
        }
    }
}
