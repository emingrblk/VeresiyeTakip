using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VeresiyeTakip.Metodlar;

namespace VeresiyeTakip.Formlar
{
    public partial class frmFirmaIslemleri : DevExpress.XtraEditors.XtraForm
    {
        Mesajlar m = new Mesajlar();
        int secimId;
        public frmFirmaIslemleri()
        {
            InitializeComponent();
        }
        #region DataGridwievden  satırdan Id seçmek için
        private void Sec()
        {
            try
            {
                secimId = int.Parse(Listele.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }
        #endregion
        void FirmaSec()
        {
            try
            {
                frmAnasayfa.deger = int.Parse(Listele.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                frmAnasayfa.deger = -1;
            }
        }
        #region Listele 
        public void Liste()
        {
            //    Listele.DataSource = db.Firma.Select(x => new
            //    {
            //        x.id,
            //        x.kod,
            //        x.firmaUnvani,
            //        x.donem,
            //        x.paraBirimi
            //    }).ToList();

            //    Listele.AllowUserToAddRows = false;
            //    Listele.AllowUserToDeleteRows = false;
        }
        #endregion
        #region Yeni firma oluşturma,Firma hesaplarını yönetme sayfasına geçiş yapma
        private void FirmaHesaplarıAc()
        {
            firmaUstLabel.Text = "Firma Hesapları";
            btnEkle.Text = "Ekle";
            pnlfirma.Visible = true;
            pnlKayit.Visible = false;
            btnDegistir.Visible = true;
            btnSil.Visible = true;
            btnCariHesabiAc.Text = "Cari Firma Aç";
        }
        private void YeniFirmaOluşturAc()
        {
            firmaUstLabel.Text = "Yeni Firma Oluştur";
            btnEkle.Text = "Geri";
            pnlfirma.Visible = false;
            pnlKayit.Visible = true;
            btnDegistir.Visible = false;
            btnSil.Visible = false;
            btnCariHesabiAc.Text = "Kaydet";
        }
        #endregion
        private void btnCariHesabiAc_Click(object sender, EventArgs e)
        {
            if (btnCariHesabiAc.Text == "Cari Firma Aç")
            {
                Sec();
                //// Aktif firmaId değiştirme
                //var g = db.Ayarlar.Where(x => x.Id == 1).FirstOrDefault();
                //{
                //    g.Firma = secimId;
                //}
                //db.SaveChanges();
                //// FirmaSec();
                Close();
            }
            else if (btnCariHesabiAc.Text == "Kaydet")
            {
                YeniKayit();
                FirmaHesaplarıAc();
                Liste();
            }
            else
            {
                Guncelle();
                FirmaHesaplarıAc();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Listele.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in Listele.SelectedRows)
                {
                    //int id = Convert.ToInt32(item.Cells[0].Value);
                    //db.Firma.Remove(db.Firma.Find(id));
                }
                if (m.Sil("Seçili firma hesabı silinecektir.\n Silme işlemini onaylıyor musunuz?") == DialogResult.Yes)
                {
                    //db.SaveChanges();
                    //Liste();
                }
                else
                {
                    return;
                }
            }
        }
        #region Yeni Kayıt ekleme
        public void YeniKayit()
        {
            //    Firma frm = new Firma();
            //    {
            //        frm.kod = "FirmaKod";
            //        frm.firmaUnvani = txtFirmaUnvani.Text;
            //        frm.borcLimit = int.Parse(txtVarsayılanBorcLimit.Text);
            //        frm.telefonNo = mtbTelefon.Text;
            //        frm.faksNo = mtbFaks.Text;
            //        frm.vergiDairesi = txtVergiDairesi.Text;
            //        frm.vergiNo = txtVergiNo.Text;
            //        frm.adres = txtAdres.Text;
            //        frm.donem = DateTime.Now.Year;
            //        frm.il = db.iller.First(x => x.sehir == (cmbIl.Text)).id;
            //        frm.ilce = db.ilceler.First(x => x.ilce == (cmbIlce.Text)).id;
            //        frm.paraBirimi = (int)cmbParaBirimi.SelectedValue;
            //        db.Firma.Add(frm);
            //        db.SaveChanges();
            //    }
        }
        #endregion

        #region Seçili id'ye göre verileri getirmek
        public void Guncelle(int id)
        {

            //    Firma frm = db.Firma.Find(id);
            //    // Firma frm = db.Firma.First(x=>x.id==id);
            //    //CariKart ck = db.CariKart.First(x => x.firmaId == id);
            //    //iller il = db.iller.First(x => x.id == db.CariKart.FirstOrDefault(y => y.firmaId == id).ilId);
            //    txtFirmaUnvani.Text = frm.firmaUnvani.ToString();
            //    txtVarsayılanBorcLimit.Text = frm.borcLimit.ToString();
            //    mtbTelefon.Text = frm.telefonNo;
            //    mtbFaks.Text = frm.faksNo;
            //    txtVergiDairesi.Text = frm.vergiDairesi.ToString();
            //    txtVergiNo.Text = frm.vergiNo;
            //    txtAdres.Text = frm.adres.ToString();
            //    // Hatalı kod ??

            //    //cmbIl.Text = frm.CariKart.First(x => x.ilId == frm.il).iller.sehir;
            //    //cmbIlce.Text =frm.iller.ilceler.First(x => x.sehir == frm.id).ilce;

            //    ///
            //    //var d = db.CariKart.FirstOrDefault(x => x.firmaId == id).iller;
            //    //var f = d.ilceler.FirstOrDefault(x => x.sehir == d.id);
            //    //cmbIl.Text = f.iller.sehir;
            //    ////cmbIlce.Text = f.ilce;
            //    cmbIl.Text = frm.iller.sehir;

            //    cmbIlce.Text = db.ilceler.First(a => a.id == frm.ilce).ilce;   // Sonunda yaptı anasını satayımmm

            //    cmbParaBirimi.Text = frm.ParaBirimi1.birim;
            //    //Liste();
        }
        #endregion
        #region Seçili id'yi güncelle 
        void Guncelle()
        {
            //    Firma frm = db.Firma.First(x => x.id == secimId);
            //    {
            //        frm.kod = "FirmaKod";
            //        frm.firmaUnvani = txtFirmaUnvani.Text;
            //        frm.borcLimit = int.Parse(txtVarsayılanBorcLimit.Text);
            //        frm.telefonNo = mtbTelefon.Text;
            //        frm.faksNo = mtbFaks.Text;
            //        frm.vergiDairesi = txtVergiDairesi.Text;
            //        frm.vergiNo = txtVergiNo.Text;
            //        frm.adres = txtAdres.Text;
            //        frm.donem = DateTime.Now.Year;

            //        frm.il = db.iller.First(x => x.sehir == (cmbIl.Text)).id;
            //        frm.ilce = db.ilceler.First(x => x.ilce == (cmbIlce.Text)).id;
            //        frm.paraBirimi = (int)cmbParaBirimi.SelectedValue;
            //    }
            //    db.SaveChanges();
            //    m.Guncelle(true);
            //    Liste();
        }
        #endregion
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                firmaUstLabel.Text = "Yeni Firma Oluştur";
                btnEkle.Text = "Geri";
                pnlfirma.Visible = false;
                pnlKayit.Visible = true;
                btnDegistir.Visible = false;
                btnSil.Visible = false;
                btnCariHesabiAc.Text = "Guncelle";
                Guncelle(secimId);
                Liste();
            }
        }

   

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Ekle")
            {
                YeniFirmaOluşturAc();
            }
            else if (btnEkle.Text == "Geri")
            {
                FirmaHesaplarıAc();
            }
        }
    }
}