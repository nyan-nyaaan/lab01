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
    public partial class Form3 : Form
    {
        Team[] teams = new Team[5];
        String[] logo = new String[]
            {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg" };
        public Form3()
        {
            Team team = new Team();
            team.setAll(1, "Miami Heat", "MIA", "1.jpg");

            teams[0] = team;

            team.setAll(2, "Orlando Magic", "ORL", "2.jpg");

            teams[1] = team;

            team.setAll(3, "Atlanta Hawks", "ATL", " 3.jpg");

            teams[2] = team;

            team.setAll(4, "Washington Wizards ", "WSH", " 4.jpg");

            teams[3] = team;

            team.setAll(4, "Charlotte Hornets", "CHA", " 4.jpg");

            teams[4] = team;

            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form2();
            adminForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button138_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Team[] teams = new Team[5];
            for (int i = 0; i < 5; i++)
                this.Controls["button" + i].Text = teams[i].name;
        }
    }
}
