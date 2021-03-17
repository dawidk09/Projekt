using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class kartaUserControl : UserControl
    {
        public kartaUserControl()
        {
            InitializeComponent();
        }

      //  public Button b_Koniec { get { return b_zamow; } }
        public Button b_Wyczysc { get { return b_wyczysc_zamowienie; } }

        private void b_podsumuj_Click(object sender, EventArgs e)
        {
            tb_podsumowanie.Text = obslugaZamowien.podsumowanieZamowienia.caleZamowienie;
            tb_podsumowanie_ilosc.Text = obslugaZamowien.podsumowanieZamowienia.calaIlosc;
            tb_suma.Text = obslugaZamowien.podsumowanieZamowienia.cena.ToString() + " zł";
        }

        private void b_zamow_Click(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.Zamow();
            if(obslugaZamowien.podsumowanieZamowienia.gotowe == false)
            {
                finalizacja1.Show();
                obslugaZamowien.podsumowanieZamowienia.gotowe = true;
            }
      

        }
        
        public void Koniec()
        {
            finalizacja1.Hide();
        }

        private void b_wyczysc_zamowienie_Click(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.WyczyscZamowienie(tb_podsumowanie, tb_podsumowanie_ilosc, tb_suma);
            obslugaZamowien.podsumowanieZamowienia.calaIlosc = null;
            obslugaZamowien.podsumowanieZamowienia.caleZamowienie = null;
            obslugaZamowien.podsumowanieZamowienia.cena = 0;
        }


    }
}
