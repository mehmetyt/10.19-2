using KafeOnline6.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            InitializeComponent();

            MasalariYukle();

            OrnekUrunleriYukle();
        }

        private void OrnekUrunleriYukle()
        {
            if (db.Urunler.Count == 0)
            {
                db.Urunler.Add(new Urun { UrunAd = "Çay", BirimFiyat = 20.00m });
                db.Urunler.Add(new Urun { UrunAd = "Kola", BirimFiyat = 35.00m });
                db.Urunler.Add(new Urun { UrunAd = "Gözleme", BirimFiyat = 120.00m });
                db.Urunler.Add(new Urun { UrunAd = "Omlet", BirimFiyat = 70.00m });
            }
        }

        private void MasalariYukle()
        {
            for (int i = 0; i < db.MasaAdet; i++)
            {
                ListViewItem lvi = new ListViewItem();
                int masaNo = i + 1;
                lvi.Text = "Masa" + masaNo;
                lvi.Tag = masaNo;
                lvi.ImageKey = "bos";
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            lvi.ImageKey = "dolu";
            int masaNo = (int)lvi.Tag;


            Siparis? siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);

            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }

            SiparisForm siparisForm = new SiparisForm(db, siparis);
            siparisForm.ShowDialog();

            if (siparis.Durumu != SiparisDurum.Aktif)
                lvi.ImageKey = "bos";
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }
    }
}
