using System;
using System.Windows.Forms;

namespace Projekt
{
    public partial class napojeUserControl : UserControl
    {
        public napojeUserControl()
        {
            InitializeComponent();
        }

        int woda = 1;
        int sok = 1;
        int herbata = 1;
        int lemoniada = 1;
        private void b_zamow_Click(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_woda_nazwa.Text, int.Parse(tb_woda_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_lemoniada_nazwa.Text, int.Parse(tb_lemoniada_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_herbata_nazwa.Text, int.Parse(tb_herbata_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_sok_nazwa.Text, int.Parse(tb_sok_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.czySaZamowienia();
           
        }

        private void cb_woda_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_woda_nazwa.Text, 0, cb_woda, tb_woda_ilosc, b_plus_woda, b_minus_woda);
        }

        private void cb_lemoniada_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_lemoniada_nazwa.Text, 5, cb_lemoniada, tb_lemoniada_ilosc, b_plus_lemoniada, b_minus_lemoniada);
        }

        private void cb_herbata_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_herbata_nazwa.Text, 5, cb_herbata, tb_herbata_ilosc, b_plus_herbata, b_minus_herbata);
        }

        private void cb_sok_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_sok_nazwa.Text, 5, cb_sok, tb_sok_ilosc, b_plus_sok, b_minus_sok);
        }

        private void b_plus_woda_Click(object sender, EventArgs e)
        {
            woda++;
            tb_woda_ilosc.Text = woda.ToString();
        }

        private void b_minus_woda_Click(object sender, EventArgs e)
        {
            if (woda > 0)
            {
                woda--;
            }

            tb_woda_ilosc.Text = woda.ToString();
        }

        private void b_plus_lemoniada_Click(object sender, EventArgs e)
        {
            lemoniada++;
            tb_lemoniada_ilosc.Text = lemoniada.ToString();
        }

        private void b_minus_lemoniada_Click(object sender, EventArgs e)
        {
            if (lemoniada > 0)
            {
                lemoniada--;
            }

            tb_lemoniada_ilosc.Text = lemoniada.ToString();
        }

        private void b_plus_herbata_Click(object sender, EventArgs e)
        {
            herbata++;
            tb_herbata_ilosc.Text = herbata.ToString();
        }

        private void b_minus_herbata_Click(object sender, EventArgs e)
        {
            if (herbata > 0)
            {
                herbata--;
            }

            tb_herbata_ilosc.Text = herbata.ToString();
        }

        private void b_plus_sok_Click(object sender, EventArgs e)
        {
            sok++;
            tb_sok_ilosc.Text = sok.ToString();
        }

        private void b_minus_sok_Click(object sender, EventArgs e)
        {
            if (sok > 0)
            {
                sok--;
            }

            tb_sok_ilosc.Text = sok.ToString();
        }
    }
}
