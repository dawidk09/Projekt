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
    public partial class oNas : UserControl
    {
        public oNas()
        {
            InitializeComponent();
        }

        private void b_sprawdz_Click(object sender, EventArgs e)
        {
            using (TextReader reader = File.OpenText(obslugaZamowien.podsumowanieZamowienia.sciezka_do_kwoty))
            {
                double x = double.Parse(reader.ReadLine());
                tb_kwota.Visible = true;
                tb_kwota.Text = x.ToString() + " zł";
            }
        }
    }
}
