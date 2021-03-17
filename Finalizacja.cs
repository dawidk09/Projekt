using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt
{
    public partial class Finalizacja : UserControl
    {
        public Finalizacja()
        {
            InitializeComponent();

        }

     //   public string karta = "Karta";
    //    public string gotowka = "Gotówka";
     //   public string na_miejscu = "Na miejscu";
     //   public string na_wynos = "Na wynos";
     //   public string dowoz = "Dowóz";
        public bool bool_karta = false;
        public bool bool_gotowka = false;
        public bool bool_na_miejscu = false;
        public bool bool_na_wynos = false;
        public bool bool_dowoz = false;
        


        private void b_karta_Click(object sender, EventArgs e)
        {
            
            bool_karta = true;
            b_karta.BackColor = Color.Red;
            b_gotowka.Enabled = false;
        }

        private void b_gotowka_Click(object sender, EventArgs e)
        {
            bool_gotowka = true;
            b_gotowka.BackColor = Color.Red;
            b_karta.Enabled = false;
        }

        private void b_namiejscu_Click(object sender, EventArgs e)
        {
            bool_na_miejscu = true;
            b_nawynos.Enabled = false;
            b_dowoz.Enabled = false;
            b_namiejscu.BackColor = Color.Red;

        }

        private void b_nawynos_Click(object sender, EventArgs e)
        {
            bool_na_wynos = true;
            b_dowoz.Enabled = false;
            b_namiejscu.Enabled = false;
            b_nawynos.BackColor = Color.Red;
        }

        private void b_dowoz_Click(object sender, EventArgs e)
        {
            b_dowoz.BackColor = Color.Red;
            bool_dowoz = true;
            b_nawynos.Enabled = false;
            b_namiejscu.Enabled = false;
            tb_ulica.Visible = true;
            tb_numer.Visible = true;
            tb_miasto.Visible = true;
            l_ulica.Visible = true;
            l_numertelefonu.Visible = true;
            l_miasto.Visible = true;
        }

        private void b_gotowe_Click(object sender, EventArgs e)
        {
            obslugaZamowien.podsumowanieZamowienia.gotowe = false;
            if (bool_karta == false && bool_gotowka == false)
            {
                MessageBox.Show("Wybierz sposób zapłąty", "", MessageBoxButtons.OK);
            }
            else if (bool_dowoz == false && bool_na_miejscu == false && bool_na_wynos == false)
            {
                MessageBox.Show("Wybierz odbiór", "", MessageBoxButtons.OK);
            }
            else if (bool_dowoz == true && string.IsNullOrWhiteSpace(tb_ulica.Text) == true)
            {
                MessageBox.Show("Podaj poprawne dane adresowe", "", MessageBoxButtons.OK);
            }
            else if (bool_dowoz == true && string.IsNullOrWhiteSpace(tb_miasto.Text) == true)
            {
                MessageBox.Show("Podaj poprawne dane adresowe", "", MessageBoxButtons.OK);
            }
            else if (bool_dowoz == true && string.IsNullOrWhiteSpace(tb_numer.Text) == true)
            {
                MessageBox.Show("Podaj poprawne dane adresowe", "", MessageBoxButtons.OK);
            }
            //else if(bool_dowoz == true && string.IsNullOrWhiteSpace(tb_numer.Text) == true && string.IsNullOrWhiteSpace(tb_miasto.Text) == true && string.IsNullOrWhiteSpace(tb_ulica.Text) == true)
               //     {
             //   MessageBox.Show("Podaj poprawne dane adresowe", "", MessageBoxButtons.OK);
           // }
            else
            {
                  //  bool_karta = false;
                   // bool_gotowka = false;
                   // bool_na_miejscu = false;
                   // bool_na_wynos = false;
                  //  bool_dowoz = false;
                  //  b_dowoz.BackColor = Color.FromArgb(255, 224, 192);
                  //  b_namiejscu.BackColor = Color.FromArgb(255, 224, 192);
                  //  b_nawynos.BackColor = Color.FromArgb(255, 224, 192);
                  //  b_karta.BackColor = Color.FromArgb(255, 224, 192);
                  //  b_gotowka.BackColor = Color.FromArgb(255, 224, 192);
                  //  b_dowoz.Enabled = true;
                   // b_namiejscu.Enabled = true;
                   // b_nawynos.Enabled = true;
                   // b_karta.Enabled = true;
                  //  b_gotowka.Enabled = true;
                  //  tb_ulica.Text = "";
                  //  tb_numer.Text = "";
                   // tb_miasto.Text = "";
                using (StreamWriter sw = File.AppendText(obslugaZamowien.podsumowanieZamowienia.sciezka_do_zamowien))
                {
                    sw.WriteLine("");
                    sw.WriteLine("Nowe zamowienie");
                    if (bool_karta == true)
                    {
                        sw.WriteLine("Płatność kartą");
                    }
                    else
                        sw.WriteLine("Płatność gotówką");
                   


                     if (bool_na_miejscu == true)
                    {
                        sw.WriteLine("Odbiór: na miejscu");
                    }
                     else if (bool_na_wynos == true)
                    {
                        sw.WriteLine("Odbiór: na wynos");
                    }
                    else if (bool_dowoz == true)
                    {
                        sw.WriteLine("Odbiór: dowóz");
                        sw.WriteLine("Miasto: " + tb_miasto.Text);
                        sw.WriteLine("Ulica: " + tb_ulica.Text);
                        sw.WriteLine("Numer telefonu: " + tb_numer.Text);
                    }
                    sw.WriteLine("Cena: " + obslugaZamowien.podsumowanieZamowienia.cena);
                }
                obslugaZamowien.podsumowanieZamowienia.Wydrukuj();
                Application.Restart();
                


            }
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
          bool_karta = false;
          bool_gotowka = false;
          bool_na_miejscu = false;
          bool_na_wynos = false;
          bool_dowoz = false;
            b_dowoz.BackColor = Color.FromArgb(255, 224, 192);
            b_namiejscu.BackColor = Color.FromArgb(255, 224, 192);
            b_nawynos.BackColor = Color.FromArgb(255, 224, 192);
            b_karta.BackColor = Color.FromArgb(255, 224, 192);
            b_gotowka.BackColor = Color.FromArgb(255, 224, 192);
            b_dowoz.Enabled = true;
            b_namiejscu.Enabled = true;
            b_nawynos.Enabled = true;
            b_karta.Enabled = true;
            b_gotowka.Enabled = true;
            tb_ulica.Text = "";
            tb_numer.Text = "";
            tb_miasto.Text = "";
            
        }
    }
}
