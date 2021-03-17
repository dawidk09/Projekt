using System;
using System.Windows.Forms;

namespace Projekt
{
    public partial class potrawyUserControl : UserControl
    {
        public potrawyUserControl()
        {
            InitializeComponent();
        }

        // zmienne do ilosci
        int pizza = 1;
        int burger = 1;
        int rosol = 1;
        int schabowe = 1;
        int spaghetti = 1;
        int zapiekanka = 1;

        
        private void cb_pizza_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_pizza_nazwa.Text, 25, cb_pizza, tb_pizza_ilosc, b_plus_pizza, b_minus_pizza);
        }

        private void cb_burger_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_burger_nazwa.Text, 10, cb_burger, tb_burger_ilosc, b_plus_burger, b_minus_burger);
        }

        private void cb_zapiekanka_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_zapiekanka_nazwa.Text, 15, cb_zapiekanka, tb_zapiekana_ilosc, b_plus_zapiekanka, b_minus_zapiekanka);
        }

        private void cb_schabowy_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_schabowe_nazwa.Text, 15, cb_schabowy, tb_schabowe_ilosc, b_plus_schabowe, b_minus_schabowe);
        }

        private void cb_rosol_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_rosol_nazwa.Text, 5, cb_rosol, tb_rosol_ilosc, b_plus_rosol, b_minus_rosol);
        }

        private void cb_spaghetti_CheckedChanged(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Wirtualny_Kelner(l_spagheti_nazwa.Text, 10, cb_spaghetti, tb_spaghetti_ilosc, b_plus_spaghetti, b_minus_spaghetti);
        }

        private void b_zamow_potrawy_Click(object sender, EventArgs e)
        {
            
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_pizza_nazwa.Text, int.Parse(tb_pizza_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_burger_nazwa.Text, int.Parse(tb_burger_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_schabowe_nazwa.Text, int.Parse(tb_schabowe_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_rosol_nazwa.Text, int.Parse(tb_rosol_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_zapiekanka_nazwa.Text, int.Parse(tb_zapiekana_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.ZbierzIlosc(l_spagheti_nazwa.Text, int.Parse(tb_spaghetti_ilosc.Text));
            obslugaZamowien.podsumowanieZamowienia.czySaZamowienia();

        }

        private void b_plus_pizza_Click(object sender, EventArgs e)
        {
            pizza++;
            tb_pizza_ilosc.Text = pizza.ToString();
        }

        private void b_minus_pizza_Click_1(object sender, EventArgs e)
        {
            if(pizza > 0)
            {
                pizza--;
            }
            
            tb_pizza_ilosc.Text = pizza.ToString();
        }

        private void b_plus_rosol_Click(object sender, EventArgs e)
        {
            rosol++;
            tb_rosol_ilosc.Text = rosol.ToString();   
        }

        private void b_minus_rosol_Click(object sender, EventArgs e)
        {
            if (rosol > 0)
            {
                rosol--;
            }

            tb_rosol_ilosc.Text = rosol.ToString();
        }
        private void b_plus_schabowe_Click(object sender, EventArgs e)
        {
            schabowe++;
            tb_schabowe_ilosc.Text = schabowe.ToString();
        }

        private void b_minus_schabowe_Click(object sender, EventArgs e)
        {
            if (schabowe > 0)
            {
                schabowe--;
            }

            tb_schabowe_ilosc.Text = schabowe.ToString();
        }

        private void b_plus_burger_Click(object sender, EventArgs e)
        {
            burger++;
            tb_burger_ilosc.Text = burger.ToString();
        }

        private void b_minus_burger_Click(object sender, EventArgs e)
        {
            if (burger > 0)
            {
                burger--;
            }

            tb_burger_ilosc.Text = burger.ToString();
        }

        private void b_plus_zapiekanka_Click(object sender, EventArgs e)
        {
            zapiekanka++;
            tb_zapiekana_ilosc.Text = zapiekanka.ToString();
        }

        private void b_minus_zapiekanka_Click(object sender, EventArgs e)
        {
            if (zapiekanka > 0)
            {
                zapiekanka--;
            }

            tb_zapiekana_ilosc.Text = zapiekanka.ToString();
        }

        private void b_plus_spaghetti_Click(object sender, EventArgs e)
        {
            spaghetti++;
            tb_spaghetti_ilosc.Text = spaghetti.ToString();
        }

        private void b_minus_spaghetti_Click(object sender, EventArgs e)
        {
            if (spaghetti > 0)
            {
                spaghetti--;
            }

            tb_spaghetti_ilosc.Text = spaghetti.ToString();
        }


    }
}
