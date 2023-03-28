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
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

            NorthwindEntities db = new NorthwindEntities();
        private void buttonurunsatis_Click(object sender, EventArgs e)
        {
            /* 
             -- Herbir üründen toplam kaç liralık ve kaç adet satış yapılmıştır?

            SELECT U.UrunID, SUM(sd.BirimFiyati*sd.Miktar*(1-sd.İndirim)) ToplamTutar, SUM(sd.Miktar) ToplamAdet
            FROM Urunler u
            INNER JOIN [Satis Detaylari] sd
            ON sd.UrunID = u.UrunID
            GROUP BY U.UrunID
             
             */
          var sonuc= db.Urunler.Join(db.Satis_Detaylari,u=> u.UrunID, s=> s.UrunID,
              (urn,sd) => new {urn.UrunAdi,sd.BirimFiyati,sd.Miktar, sd.İndirim} )
                .GroupBy(x => x.UrunAdi)
                .Select(x => new                
                {  x.Key //Urun Adı = x.Key
                ,ToplamTutar = x.Sum(y => (float)y.BirimFiyati*y.Miktar*(1-(float)y.İndirim)) 
                ,ToplamAdet = x.Sum(y=>y.Miktar)
                } );

            dataGridViewrapor.DataSource = sonuc.ToList();
            dataGridViewrapor.Columns["Key"].HeaderText = "Ürün Adı";




        }

        private void button_ted_kad_rapor_Click(object sender, EventArgs e)
        {
       var sonuc = db.Urunler.Join(db.Satis_Detaylari, u => u.UrunID, s => s.UrunID
      ,(urn, sd) => new { urn.Kategoriler,urn.Tedarikciler, sd.BirimFiyati, sd.Miktar, sd.İndirim })
      .GroupBy(x => new {  x.Kategoriler.KategoriAdi, x.Tedarikciler.SirketAdi} )
      .Select(x => new
      {
        TedarikciAdı = x.Key.SirketAdi
      , KategoriAdı= x.Key.KategoriAdi
      , ToplamTutar = x.Sum(y => (float)y.BirimFiyati * y.Miktar * (1 - (float)y.İndirim))
      , ToplamAdet = x.Sum(y => y.Miktar)
      });

            dataGridViewrapor.DataSource = sonuc.ToList();
            dataGridViewrapor.Columns["KategoriAdı"].HeaderText="Kategori Adı";
            dataGridViewrapor.Columns["TedarikciAdı"].HeaderText ="Tedarikçi Adı";

        }

        private void button_msatis_Click(object sender, EventArgs e)
        {
            var sonuc = from urun in db.Urunler
                        join sd in db.Satis_Detaylari
                        on urun.UrunID equals sd.UrunID

                        join satis in db.Satislar
                        on sd.SatisID equals satis.SatisID

                        join musteri in db.Musteriler
                        on satis.MusteriID equals musteri.MusteriID

                        group new {urun,musteri } by new { urun.UrunAdi, musteri.SirketAdi } into grup
                        orderby grup.Key.UrunAdi
                        select new
                        {
                            UrunAdı= grup.Key.UrunAdi
                           ,SirketAdı= grup.Key.SirketAdi
                           ,ToplamSatis= grup.Sum(x=> x.urun.BirimFiyati)
                           ,ToplamAdet=grup.Count()
                        };
                        dataGridViewrapor.DataSource = sonuc.ToList();
        }
    }
}
