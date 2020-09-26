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
using VeresiyeTakip.Formlar;

namespace VeresiyeTakip
{
    public partial class frmAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        public static int secimId;
        internal static int deger;

        public frmAnasayfa()
        {
            InitializeComponent();
        }
        void sayi()
        {
            Count.Text = "Bulunan Kayıt= " + DgwListele.RowCount.ToString();
        }
        private void Sec()
        {
            try
            {
                secimId = int.Parse(DgwListele.CurrentRow.Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void btnCariHareket_Click(object sender, EventArgs e)
        {
            if (btnCariHareket.Text == "Cari Hareketleri Aç")
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (DgwListele.SelectedRows.Count > 0)
            {
                //foreach (DataGridViewRow item in txtHesap.SelectedRows)
                //{
                //    int id = Convert.ToInt32(item.Cells[0].Value);
                //    db.CariKart.Remove(db.CariKart.Find(id));
                //}
                //if (m.Sil() == DialogResult.Yes)
                //{

                //    db.SaveChanges();
                //    ListeleUygulama();
                //    sayi();
                }
                else
                {
                    return;
                }
            }

        private void btnDegistir_Click(object sender, EventArgs e)
        {

            frmCariKartEkle ck = new frmCariKartEkle();
            Sec();
            if (secimId > 0)
            {
                //ck.Guncelle(secimId);
                //ck.Text = "Cari Kart Değiştir";
                //ck.ShowDialog();

                //ListeleUygulama();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmCariKartEkle ck = new frmCariKartEkle();
            ck.Text = "Cari Kart Ekle";
            ck.ShowDialog();
           // ListeleUygulama();
            sayi();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            frmYazdir frm = new frmYazdir();
            //frm.HangiListe = "CariKart";
            frm.ShowDialog();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            frmListeToplamlari frm = new frmListeToplamlari();
            frm.ShowDialog();
        
         }

        private void frmAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Firmalar
        private void btnFirmaHesaplari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFirmaIslemleri frm = new frmFirmaIslemleri();
            frm.ShowDialog();
            //ListeleUygulama();
        }

        private void btnYilSonuDevir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        #region Yedekleme
        private void btnYedekAl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYedeklemeSistemi yedek = new frmYedeklemeSistemi();
            yedek.ShowDialog();
        }

        private void btnGeriYükle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYedeklemeSistemi yedek = new frmYedeklemeSistemi();
            yedek.ShowDialog();
        } 
        #endregion
        #region Ayarlar
        private void btnAciklamalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAyarlar ayar = new frmAyarlar();
            ayar.ShowDialog();
        }


        private void btnSifreDegistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAyarlar ayar = new frmAyarlar();
            ayar.ShowDialog();
        }

        private void btnGenelAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAyarlar ayar = new frmAyarlar();
            ayar.ShowDialog();
        }
        #endregion

        private void btnYardim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHakkinda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHakkinda hakkinda = new frmHakkinda();
            hakkinda.ShowDialog();
        }

        private void btnCariHareketYazdir_Click(object sender, EventArgs e)
        {
            //frmYazdir frm = new frmYazdir();
            //frm.HangiListe = "CariKartHareket";
            //frm.ShowDialog();
        }

        private void btNot_Click(object sender, EventArgs e)
        {
            frmCariKartEkle ck = new frmCariKartEkle();

            Sec();
            if (secimId > 0)
            {
               
                //ck.Guncelle(secimId);
                ck.Text = "Cari Kart Değiştir";
                ck.tabControl.SelectedIndex = 1;
                ck.ShowDialog();
                //ListeleUygulama();
            }
        }

        int i = -1;
        private void btnSonraki_Click(object sender, EventArgs e)
        {

            if (i < DgwListele.Rows.Count - 1)
            {
                if (i == -1)
                    i = DgwListele.CurrentCell.RowIndex;

                i += 1;
                DgwListele.Rows[i].Selected = true;
                //secimId = int.Parse(DgwListele.Rows[i].Cells[0].Value.ToString());
                //btnCariHesapAc.Text = db.CariKart.First(x => x.id == secimId).unvani;
            }
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            //int i = -1;
            if (i == -1)
                i = DgwListele.CurrentCell.RowIndex;

            if (i > 0)
                i -= 1;
            DgwListele.Rows[i].Selected = true;
            //secimId = int.Parse(DgwListele.Rows[i].Cells[0].Value.ToString());
            //btnCariHesapAc.Text = db.CariKart.First(x => x.id == secimId).unvani;
        }
        private void btnCariHesapAc_Click(object sender, EventArgs e)
        {

        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {

        }

    
    }
}