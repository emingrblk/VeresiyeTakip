using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VeresiyeTakip.Forms;

namespace VeresiyeTakip
{
    public partial class Uygulama : DevExpress.XtraEditors.XtraForm
    {
        VeresiyeDBEntities db = new VeresiyeDBEntities();
        Mesajlar m = new Mesajlar();
        public static int secimId;
        public static int yenile = -1;// Firma seçildikten sonra dataGridwiev içerisini doldurmak için 

        public static int deger = -1;
        public Uygulama()
        {
            InitializeComponent();

        }
        private void Uygulama_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        void sayi()
        {
            Count.Text = "Bulunan Kayıt= " + txtHesap.RowCount.ToString();
        }

  
       void ListeleUygulama()
        {      
            txtHesap.Rows.Clear();
            int i = 0;



            //if (cmbSorgu.Text=="Unvan ile Sorgu")
            //{
            //    var lst = (from x in db.CariKart
            //               where x.firmaId == db.Ayarlar.FirstOrDefault().FirmaId
            //               where x.unvani.Contains(txtArama.Text)
           //                where x.Firma.iller.sehir.Contains(txtArama.Text)
            //               select new
            //               {
            //                   Kodu = x.id,
            //                   Ünvanı = x.unvani,
            //                   Yetkili = x.yetkili,
            //                   Telefon = x.telefonNo,
            //                   Şehir = x.Firma.iller.sehir,
            //                   işlem = x.tarih,
            //                   Bakiye = x.cariLimit - x.Borc.tutar
            //               }).Distinct();
            //    foreach (var k in lst)
            //    {
            //        DgwListele.Rows.Add();
            //        DgwListele.Rows[i].Cells[0].Value = k.Kodu;
            //        DgwListele.Rows[i].Cells[1].Value = k.Ünvanı;
            //        DgwListele.Rows[i].Cells[2].Value = k.Yetkili;
            //        DgwListele.Rows[i].Cells[3].Value = k.Telefon;
            //        DgwListele.Rows[i].Cells[4].Value = k.Şehir;
            //        DgwListele.Rows[i].Cells[5].Value = k.işlem;
            //        DgwListele.Rows[i].Cells[6].Value = k.Bakiye;
            //        i++;
            //    } 
            //}
            //else 
            //{

            var lst = (from x in db.CariKart
                           where x.firmaId ==db.Ayarlar.FirstOrDefault().Firma
                           //where x.iller.sehir.Contains(txtArama.Text)
                           where x.unvani.Contains(txt2.Text)
                          // where x.Hesap.durum.Contains(txtHesap.Text)
                           //where x.id==txtFiltre.Text.ToString()
                       select new
                           {
                               
                               Kodu = x.id,
                               Ünvanı = x.unvani,
                               Yetkili = x.yetkili,
                               Telefon = x.telefonNo,
                               Şehir = x.iller.sehir,
                               işlem = x.tarih,
                               Bakiye = x.cariLimit - x.Borc.tutar
                           }).Distinct();
                foreach (var k in lst)
                {
                    txtHesap.Rows.Add();
                    txtHesap.Rows[i].Cells[0].Value = k.Kodu;
                    txtHesap.Rows[i].Cells[1].Value = k.Ünvanı;
                    txtHesap.Rows[i].Cells[2].Value = k.Yetkili;
                    txtHesap.Rows[i].Cells[3].Value = k.Telefon;
                    txtHesap.Rows[i].Cells[4].Value = k.Şehir;
                    txtHesap.Rows[i].Cells[5].Value = k.işlem;
                    txtHesap.Rows[i].Cells[6].Value = k.Bakiye;
                    i++;
                }
            //}
            txtHesap.AllowUserToAddRows = false;
            txtHesap.AllowUserToDeleteRows = false;

        }
        
    private void Sec()
        {
            try
            {
                secimId = int.Parse(txtHesap.CurrentRow.Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                secimId = -1;
            }
        }



        #region Ayarlar
        private void aciklamalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ayarlar ayar = new Ayarlar();
            ayar.ShowDialog();
        }
        private void genelAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ayarlar ayar = new Ayarlar();
            ayar.ShowDialog();
        }
        private void sifreDegistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ayarlar ayar = new Ayarlar();
            ayar.ShowDialog();
        }
        #endregion

        #region Yedekleme 
        private void yedekAl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YedeklemeSistemi yedek = new YedeklemeSistemi();
            yedek.ShowDialog();
        }

        private void geriYukle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YedeklemeSistemi yedek = new YedeklemeSistemi();
            yedek.ShowDialog();
        }
        #endregion 
        private void firmaHesaplari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFirmaİslemleri frm = new frmFirmaİslemleri();
            frm.ShowDialog();
            ListeleUygulama();
           


        }

        private void yilSonuDevirIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void hareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }





        private void yardim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Hakkinda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hakkinda h = new Hakkinda();
            h.ShowDialog();
        }
        
        private void Uygulama_Load(object sender, EventArgs e)
        {
           
            ListeleUygulama();
            sayi();
            pnlCariHareket.Visible = false;
            pnlGoster.Visible = true;
            btnCariHareket.Text = "Cari Hareketleri Aç";
            

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CariKartEkle ck = new CariKartEkle();
            ck.Text = "Cari Kart Ekle";
            ck.ShowDialog();
            ListeleUygulama();
            sayi();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtHesap.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in txtHesap.SelectedRows)
                {
                    int id = Convert.ToInt32(item.Cells[0].Value);
                    db.CariKart.Remove(db.CariKart.Find(id));
                }
                if (m.Sil() == DialogResult.Yes)
                {
                  
                    db.SaveChanges();
                    ListeleUygulama();
                    sayi();
                }
                else
                {
                    return;
                }


            }
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {  
            CariKartEkle ck = new CariKartEkle();
            Sec();
            if (secimId > 0)
            {
                ck.Guncelle(secimId);
                ck.Text = "Cari Kart Değiştir";
                ck.ShowDialog();

                ListeleUygulama();
            }

        }

        private void btnCariHareket_Click(object sender, EventArgs e)
        {

            if(btnCariHareket.Text=="Cari Hareketleri Aç")
            {
                
                pnlCariHareket.Visible = true;
                pnlGoster.Visible = false;
                btnCariHareket.Text = "Geri";
            }
            else
            {
                pnlCariHareket.Visible = false;
                pnlGoster.Visible = true;
                btnCariHareket.Text = "Cari Hareketleri Aç";
            }




        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            frmYazdir frm = new frmYazdir();
            frm.HangiListe = "CariKart";
            frm.ShowDialog();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            frmListeToplamları frm = new frmListeToplamları();
            frm.ShowDialog();
        }



        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtArama.Text))
            {
                ListeleUygulama();
            }
            else
                ListeleUygulama();
        }

        private void pnlCariHareket_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btNot_Click(object sender, EventArgs e)
        {
            CariKartEkle ck = new CariKartEkle();
            
            Sec();
            if (secimId > 0)
            {
                ck.Guncelle(secimId);
                ck.Text = "Cari Kart Değiştir";
                ck.tabControl.SelectedIndex = 1;
                ck.ShowDialog();
                ListeleUygulama();
            }
        }

        private void btnCariHareketYazdir_Click(object sender, EventArgs e)
        {
            frmYazdir frm = new frmYazdir();
            frm.HangiListe = "CariKartHareket";
            frm.ShowDialog();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {

        }

        private void cmbSorgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSorgu.SelectedIndex==1)
            {
                txtArama.Visible = true;
                txt1.Visible = false;
                txt2.Visible = false;
            }
            else if(cmbSorgu.SelectedIndex==2)
            {
                txtArama.Visible = false;
                txt1.Visible = true;
                txt2.Visible = false;
            }
            else
            {
                txtArama.Visible = false;
                txt1.Visible = false;
                txt2.Visible = true;
            }
        }
    }
}
