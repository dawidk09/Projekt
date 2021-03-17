using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Projekt
{
    public class obslugaZamowien
    {
        public Dictionary<string, int> zamowienie = new Dictionary<string, int>();
        public Dictionary<string, int> iloscPotraw = new Dictionary<string, int>();
        public bool gotowe = false;
        public static obslugaZamowien podsumowanieZamowienia = new obslugaZamowien();
        public string caleZamowienie;
        public string calaIlosc;
        string temp;
        public double suma;
        public string sciezka_do_zamowien = @"zamowienia\\zamowienia.txt";
        public string sciezka_do_kwoty = @"ZAROBKI RESTAURACJI\\kwota.txt";
        public double cena;



        public void Wirtualny_Kelner(string potrawa, int cena, CheckBox cb, TextBox pokazIlosc, Button plus, Button minus)
        {
            if (!zamowienie.ContainsKey(potrawa))
            {
             zamowienie.Add(potrawa, cena);
                pokazIlosc.Visible = true;
                plus.Visible = true;
                minus.Visible = true;
            }
            
            if (cb.Checked == false)
            {
                zamowienie.Remove(potrawa);
                pokazIlosc.Visible = false;
                plus.Visible = false;
                minus.Visible = false;

            }
        }
        public void ZbierzIlosc(string potrawa, int ilosc)
        {
            if (!iloscPotraw.ContainsKey(potrawa))
            {
                iloscPotraw.Add(potrawa, ilosc);
            }
            else if (zamowienie.ContainsKey(potrawa))
             {
                iloscPotraw.Remove(potrawa);
                iloscPotraw.Add(potrawa, ilosc);
             }

        }
        public void Zamow()
        {

            FileInfo f = new FileInfo(sciezka_do_kwoty);
            sciezka_do_kwoty = f.FullName ;
            
            using (TextReader reader = File.OpenText(sciezka_do_kwoty))
            {
                double x = double.Parse(reader.ReadLine());
                suma += x + cena;
            }
            using (StreamWriter sw = new StreamWriter(sciezka_do_kwoty))
                {
                        sw.WriteLine(suma);
                }
        }

        public void Wydrukuj()
        {
            FileInfo f = new FileInfo(sciezka_do_zamowien);
            sciezka_do_zamowien = f.FullName;
            using (StreamWriter sw = File.AppendText(sciezka_do_zamowien))
            {

                for (int i = 0; i < zamowienie.Count; i++)
                {
                    temp = zamowienie.ElementAt(i).Key;
                    caleZamowienie += zamowienie.ElementAt(i).Key + " " + zamowienie.ElementAt(i).Value + " zł \r\n";
                    
                    if (iloscPotraw.ContainsKey(temp))
                    {
                        sw.WriteLine(zamowienie.ElementAt(i).Key + " " + zamowienie.ElementAt(i).Value + " zł x" + iloscPotraw[temp]);
                    }
                    
                }
                
            }
        }

        public void WyczyscZamowienie(TextBox jeden, TextBox dwa, TextBox trzy)
        {
            zamowienie.Clear();
            iloscPotraw.Clear();
            jeden.Text = "";
            dwa.Text = "";
            trzy.Text = "";
        }
   
      
        public void czySaZamowienia()
        {
            if (zamowienie.Count == 0)
            {
                MessageBox.Show("Nic nie wybrałeś", "", MessageBoxButtons.OK);
            }
            calaIlosc = "";
            caleZamowienie = "";
            cena = 0;
        
            for(int i = 0; i < zamowienie.Count; i++)
            {
                temp = zamowienie.ElementAt(i).Key;
                caleZamowienie += zamowienie.ElementAt(i).Key + " " + zamowienie.ElementAt(i).Value + " zł \r\n";
                if (iloscPotraw.ContainsKey(temp))
                {
                    calaIlosc += iloscPotraw[temp] + "\r\n";
                    cena += iloscPotraw[temp] * zamowienie.ElementAt(i).Value;
                }
                
                if(cena > 50)
                {
                    cena = (cena * 0.9) ;
                }
            }
            cena = Math.Ceiling(cena);

        }
    }
}









