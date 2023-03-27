using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDbFirst
{
    /*
     Bir ORM aracıdır
    Db First te önce db der. İlk databse 
     
     
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridViewUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        NorthwindEntities db = new NorthwindEntities(); //Db contexten misra alan classı

        private void Urunlistesi()
        {
            var sonuc1 = db.Urunler.Join(db.Kategoriler,u=> u.KategoriID,k => k.KategoriID,(urn, kat) => new {urn.UrunID,urn.UrunAdi,urn.BirimFiyati,urn.HedefStokDuzeyi,kat.KategoriID, kat.KategoriAdi});

            var sonuc2 = db.Urunler.Join(db.Tedarikciler, u => u.TedarikciID, t => t.TedarikciID ,(urn, ted) => new {urn.UrunID, urn.UrunAdi,urn.BirimFiyati,urn.HedefStokDuzeyi,ted.TedarikciID,ted.SirketAdi});

            var sonuc3 = db.Urunler.Join(db.Kategoriler, u => u.KategoriID, k => k.KategoriID, (urn, kat) => new { urn, kat.KategoriAdi }).Join(db.Tedarikciler, prd => prd.urn.TedarikciID, t=> t.TedarikciID,(birincitablo,ikincitablo) => new {birincitablo.urn.UrunID, birincitablo.urn.UrunAdi, birincitablo.urn.BirimFiyati, birincitablo.urn.HedefStokDuzeyi, birincitablo.urn.TedarikciID, birincitablo.urn.KategoriID, birincitablo.KategoriAdi, ikincitablo.SirketAdi  } );


            // dataGridViewUrunler.DataSource = sonuc1.ToList();
            //dataGridViewUrunler.DataSource = sonuc2.ToList();
            dataGridViewUrunler.DataSource = sonuc3.ToList();

            // dataGridViewUrunler.DataSource = db.Urunler.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Urunlistesi();
            comboBoxKategoriler.DataSource = db.Kategoriler.ToList();
            comboBoxKategoriler.DisplayMember = "KategoriAdi";
            comboBoxKategoriler.ValueMember = "KategoriID";

            comboBoxTedarikciler.DataSource = db.Tedarikciler.ToList();
            comboBoxTedarikciler.DisplayMember = "SirketAdi";
            comboBoxTedarikciler.ValueMember = "TedarikciID";

            radioButtonArtan.Enabled = false;
            radioButtonAzalan.Enabled = false;
            textBoxUrunarama.Enabled = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAdi = textBoxadi.Text;
            u.HedefStokDuzeyi   = (short)numericUpdFiyat.Value;
            u.BirimFiyati       = (short)numericUpdStok.Value;
            u.KategoriID        = (int)comboBoxKategoriler.SelectedValue;
            u.TedarikciID       = (int)comboBoxTedarikciler.SelectedValue;

            db.Urunler.Add(u);
            db.SaveChanges();//bunu demessek eklenmez.
            Urunlistesi();

        }

        private void dataGridViewUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxadi.Text = dataGridViewUrunler.CurrentRow.Cells["UrunAdi"].Value.ToString();
            numericUpdFiyat.Value = (decimal)dataGridViewUrunler.CurrentRow.Cells["BirimFiyati"].Value;
            numericUpdStok.Value = (short)dataGridViewUrunler.CurrentRow.Cells["HedefStokDuzeyi"].Value;
            comboBoxKategoriler.SelectedValue = dataGridViewUrunler.CurrentRow.Cells["KategoriID"].Value;
            comboBoxTedarikciler.SelectedValue = dataGridViewUrunler.CurrentRow.Cells["TedarikciID"].Value;
            textBoxadi.Tag = dataGridViewUrunler.CurrentRow.Cells["UrunID"].Value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id =(int)textBoxadi.Tag;
           Urunler u= db.Urunler.FirstOrDefault(i => i.UrunID == id);
            if (u!=null)
            {

                u.UrunAdi = textBoxadi.Text;
                u.BirimFiyati = numericUpdFiyat.Value;
                u.HedefStokDuzeyi = (short) numericUpdStok.Value;
                u.KategoriID = (int) comboBoxKategoriler.SelectedValue;
                u.TedarikciID = (int) comboBoxTedarikciler.SelectedValue;

                db.SaveChanges();/***********/
                Urunlistesi();
                


            }
        }

        private void textBoxUrunarama_TextChanged(object sender, EventArgs e)
        {
            dataGridViewUrunler.DataSource = db.Urunler.Where(x => x.UrunAdi.Contains(textBoxUrunarama.Text)).ToList();
        }

        private void radioButtonArtan_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewUrunler.DataSource = db.Urunler.OrderBy(x => x.BirimFiyati).ToList();

        }

        private void radioButtonAzalan_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewUrunler.DataSource = db.Urunler.OrderByDescending(x=> x.BirimFiyati).ToList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radioButtonArtan.Enabled = true;
                radioButtonAzalan.Enabled = true;
                textBoxUrunarama.Enabled = true;
            }
            else
            {
                Urunlistesi();
                radioButtonArtan.Enabled = false;
                radioButtonAzalan.Enabled = false;
                textBoxUrunarama.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridViewUrunler.DataSource = db.Urunler.Take(10).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridViewUrunler.DataSource = db.Urunler.Take(10).OrderByDescending(x=> x.UrunID).ToList();
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewUrunler.CurrentRow.Cells["UrunID"].Value);
            Urunler u = db.Urunler.FirstOrDefault(i => i.UrunID == id);
            if (u!=null)
            {
                db.Urunler.Remove(u);
                db.SaveChanges();

            }
            dataGridViewUrunler.DataSource = db. Urunler.ToList();
        }
    }
}
