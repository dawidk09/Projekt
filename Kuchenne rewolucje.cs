using System;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public  Form1()
        {
            InitializeComponent();
        }

        
        private void b_potrawy_Click(object sender, EventArgs e)
        {
            pb_start.Visible = false;
            potrawyUserControl.Show();
            napojeUserControl.Hide();
            kartaUserControl1.Hide();
            oNas1.Hide();

        }

        private void b_napoje_Click(object sender, EventArgs e)
        {
            pb_start.Visible = false;
            napojeUserControl.Show();
            potrawyUserControl.Hide();
            kartaUserControl1.Hide();
            oNas1.Hide();

        }

        private void b_start_Click(object sender, EventArgs e)
        {
            pb_start.Visible = true;
            potrawyUserControl.Hide();
            napojeUserControl.Hide();
            kartaUserControl1.Hide();
            oNas1.Hide();

        }

        private void b_twojaKarta_Click(object sender, EventArgs e)
        {
            pb_start.Visible = false;
            kartaUserControl1.Show();
            potrawyUserControl.Hide();
            napojeUserControl.Hide();
            oNas1.Hide();
            kartaUserControl1.Koniec();
            


        }

        private void b_oNas_Click(object sender, EventArgs e)
        {
            pb_start.Visible = false;
            kartaUserControl1.Hide();
            potrawyUserControl.Hide();
            napojeUserControl.Hide();
            oNas1.Show();

        }
    }
}
