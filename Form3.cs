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
        Team[] teams = new Team[30];
        String[] logo = new String[]
            {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg", "6.jpg","7.jpg","8.jpg","9.jpg","10.jpg" , "11.jpg","12.jpg","13.jpg","14.jpg","15.jpg","16.jpg","17.jpg","18.jpg","19.jpg","20.jpg" , "21.jpg","22.jpg","23.jpg","24.jpg","25.jpg","26.jpg","27.jpg","28.jpg","29.jpg","30.jpg"};

        public Form3()
        {
            this.teams[0] = new Team();
            this.teams[0].setAll(1, "Miami Heat", "MIA", "1.jpg");
            this.teams[1] = new Team();
            this.teams[1].setAll(2, "Orlando Magic", "ORL", "2.jpg");
            this.teams[2] = new Team();
            this.teams[2].setAll(3, "Atlanta Hawks", "ATL", " 3.jpg");
            this.teams[3] = new Team();
            this.teams[3].setAll(4, "Washington Wizards ", "WSH", " 4.jpg");
            this.teams[4] = new Team();
            this.teams[4].setAll(5, "Charlotte Hornets", "CHA", " 5.jpg");
            this.teams[5] = new Team();
            this.teams[5].setAll(6, "Detroit Pistons", "DET", " 6.jpg");
            this.teams[6] = new Team();
            this.teams[6].setAll(7, "Indiana Pacers", "IND", " 7.jpg");
            this.teams[7] = new Team();
            this.teams[7].setAll(8, "Cleveland Cavaliers", "CLE", " 8.jpg"); 
            this.teams[8] = new Team();
            this.teams[8].setAll(9, "Chicago Bulls", "CHI", " 9.jpg");
            this.teams[9] = new Team();
            this.teams[9].setAll(10, "Milwaukee Bucks", "MIL", " 10.jpg");
            this.teams[10] = new Team();
            this.teams[10].setAll(11, "Boston Celtics", "BOS", " 11.jpg");
            this.teams[11] = new Team();
            this.teams[11].setAll(12, "Philadelphia 76ers", "PHI", " 12.jpg");
            this.teams[12] = new Team();
            this.teams[12].setAll(13, "New York Knicks", "NY ", " 13.jpg");
            this.teams[13] = new Team();
            this.teams[13].setAll(14, "Brooklyn Nets", "BKN", " 14.jpg");
            this.teams[14] = new Team();
            this.teams[14].setAll(15, "Toronto Raptors", "TOR", " 15.jpg");
            this.teams[15] = new Team();
            this.teams[15].setAll(16, "San Antonio Spurs", "SA ", " 16.jpg");
            this.teams[16] = new Team();
            this.teams[16].setAll(17, "Memphis Grizzlies", "MEM ", " 17.jpg");
            this.teams[17] = new Team();
            this.teams[17].setAll(18, "Dallas Mavericks", "DAL ", " 18.jpg");
            this.teams[18] = new Team();
            this.teams[18].setAll(19, "Houston Rockets", "HOU", " 19.jpg");
            this.teams[19] = new Team();
            this.teams[19].setAll(20, "New Orleans Pelicans", "NO ", " 20.jpg");
            this.teams[20] = new Team();
            this.teams[20].setAll(21, "Minnesota Timberwolves", "MIN ", " 21.jpg");
            this.teams[21] = new Team();
            this.teams[21].setAll(22, "Denver Nuggets", "DEN ", " 22.jpg");
            this.teams[22] = new Team();
            this.teams[22].setAll(23, "Utah Jazz", "UTA ", " 23.jpg");
            this.teams[23] = new Team();
            this.teams[23].setAll(24, "Portland Trail Blazers", "POR ", " 24.jpg");
            this.teams[24] = new Team();
            this.teams[24].setAll(25, "Oklahoma City Thunder", "OKC", " 25.jpg");
            this.teams[25] = new Team();
            this.teams[25].setAll(26, "Sacramento Kings", "SAC ", " 26.jpg");
            this.teams[26] = new Team();
            this.teams[26].setAll(27, "Phoenix Suns", "PHX", " 27.jpg");
            this.teams[27] = new Team();
            this.teams[27].setAll(28, "L.A. Lakers", "LAL", " 28.jpg");
            this.teams[28] = new Team();
            this.teams[28].setAll(29, "Los Angeles Clippers", "LAC ", " 29.jpg");
            this.teams[29] = new Team();
            this.teams[29].setAll(30, "Golden State Warriors", "GS  ", " 30.jpg");
       

            InitializeComponent();
            pictureBox2.Load("../../Teams/" + logo[0]);
            pictureBox3.Load("../../Teams/" + logo[1]);
            pictureBox4.Load("../../Teams/" + logo[2]);
            pictureBox5.Load("../../Teams/" + logo[3]);
            pictureBox6.Load("../../Teams/" + logo[4]);
            pictureBox7.Load("../../Teams/" + logo[5]);
            pictureBox8.Load("../../Teams/" + logo[6]);
            pictureBox9.Load("../../Teams/" + logo[7]);
            pictureBox10.Load("../../Teams/" + logo[8]);
            pictureBox11.Load("../../Teams/" + logo[9]);
            pictureBox12.Load("../../Teams/" + logo[10]);
            pictureBox13.Load("../../Teams/" + logo[11]);
            pictureBox14.Load("../../Teams/" + logo[12]);
            pictureBox15.Load("../../Teams/" + logo[13]);
            pictureBox16.Load("../../Teams/" + logo[14]);
            pictureBox17.Load("../../Teams/" + logo[15]);
            pictureBox18.Load("../../Teams/" + logo[16]);
            pictureBox19.Load("../../Teams/" + logo[17]);
            pictureBox20.Load("../../Teams/" + logo[18]);
            pictureBox21.Load("../../Teams/" + logo[19]);
            pictureBox22.Load("../../Teams/" + logo[20]);
            pictureBox23.Load("../../Teams/" + logo[21]);
            pictureBox24.Load("../../Teams/" + logo[22]);
            pictureBox25.Load("../../Teams/" + logo[23]);
            pictureBox26.Load("../../Teams/" + logo[24]);
            pictureBox27.Load("../../Teams/" + logo[25]);
            pictureBox28.Load("../../Teams/" + logo[26]);
            pictureBox29.Load("../../Teams/" + logo[27]);
            pictureBox30.Load("../../Teams/" + logo[28]);
            pictureBox31.Load("../../Teams/" + logo[29]);

             this.p1.Controls["linkLabel1"].Text = teams[0].name;
            this.p2.Controls["linkLabel2"].Text = teams[1].name;
            this.p3.Controls["linkLabel3"].Text = teams[2].name;
            this.p4.Controls["linkLabel4"].Text = teams[3].name;
            this.p5.Controls["linkLabel5"].Text = teams[4].name;
            this.p6.Controls["linkLabel6"].Text = teams[5].name;
            this.p7.Controls["linkLabel7"].Text = teams[6].name;
            this.p8.Controls["linkLabel8"].Text = teams[7].name;
            this.p9.Controls["linkLabel9"].Text = teams[8].name;
            this.p10.Controls["linkLabel10"].Text = teams[9].name;
            this.p11.Controls["linkLabel11"].Text = teams[10].name;
            this.p12.Controls["linkLabel12"].Text = teams[11].name;
            this.p13.Controls["linkLabel13"].Text = teams[12].name;
            this.p14.Controls["linkLabel14"].Text = teams[13].name; 
            this.p15.Controls["linkLabel15"].Text = teams[14].name;
            this.p16.Controls["linkLabel16"].Text = teams[15].name;
            this.p17.Controls["linkLabel17"].Text = teams[16].name;
            this.p18.Controls["linkLabel18"].Text = teams[17].name;
            this.p19.Controls["linkLabel19"].Text = teams[18].name;
            this.p20.Controls["linkLabel20"].Text = teams[19].name;
            this.p21.Controls["linkLabel21"].Text = teams[20].name;
            this.p22.Controls["linkLabel22"].Text = teams[21].name;
            this.p23.Controls["linkLabel23"].Text = teams[22].name;
            this.p24.Controls["linkLabel24"].Text = teams[23].name;
            this.p25.Controls["linkLabel25"].Text = teams[24].name;
            this.p26.Controls["linkLabel26"].Text = teams[25].name;
            this.p27.Controls["linkLabel27"].Text = teams[26].name;
            this.p28.Controls["linkLabel28"].Text = teams[27].name;
            this.p29.Controls["linkLabel29"].Text = teams[28].name;
            this.p30.Controls["linkLabel30"].Text = teams[29].name;








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
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
