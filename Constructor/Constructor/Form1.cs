using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Adi = "Mikayil";
            Personel p1 = new Personel("Mikayil");
            p.KayitTarihi=DateTime.Now;
            Personel p2 = new Personel("Mikayil", "Sadigzade", "22121212", DateTime.Now);

            Personel p3 = new Personel
            {
                Adi = "Mikayil",
                Soyadi = "Sadigzade",
                TCKN = "1212121212",
                KayitTarihi = DateTime.Now,
                DogumTarihi = DateTime.Now
            

            };
        }
    }
}
