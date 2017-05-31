using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiyimMagazaOtomasyonu
{
    public partial class Personel : Form
    {
        Fonksiyonlar fonk = new Fonksiyonlar();

        DataTable tablo = new DataTable();

        int sonuc;
        public Personel()
        {
            InitializeComponent();
        }

        //stok kontrol
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
                tablo = fonk.StokKontrol(textBox16.Text);

            if (tablo != null)
            {
                MessageBox.Show("Urun stok kontrolü için Listelendi");
                dataGridView4.DataSource = tablo;
            }
            else
            {
                MessageBox.Show("hata");
            }
        }

        //ürün satış
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                tablo = fonk.UrunSat(textBox1.Text);
            if (tablo != null)
            {
                MessageBox.Show("Urun  Listelendi");
                dataGridView1.DataSource = tablo;
            }
            else
            {
                MessageBox.Show("hata");
            }
        }
    }
}
