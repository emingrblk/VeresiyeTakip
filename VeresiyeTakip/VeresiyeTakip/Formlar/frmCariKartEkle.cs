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
    public partial class frmCariKartEkle : DevExpress.XtraEditors.XtraForm
    {
        Mesajlar m = new Mesajlar();
        //VeresiyeDBEntities db = new VeresiyeDBEntities();
        public frmCariKartEkle()
        {
            InitializeComponent();
        }
        public void YeniKayit()
        {
            //CariKart ck = new CariKart();
            //{
            //    ck.unvani = txtUnvan.Text;
            //    ck.yetkili = txtYetkili.Text;
            //    ck.telefonNo = mtbTelefon.Text;
            //    ck.vergiDairesi = txtVergiDairesi.Text;
            //    ck.vergiNo = txtVergiNo.Text;
            //    ck.adres = txtAdres.Text;
            //    ck.ePosta = txtEPosta.Text;
            //    ck.faksNo = mtbfax.Text;
            //    ck.gsm = mtbGsm.Text;
            //    ck.webAdresi = txtWeb.Text;
            //    ck.tarih = Convert.ToDateTime(dTPTarih.Text);
            //    ck.notu = txtNot.Text;
            //    ck.ilId = db.iller.First(x => x.sehir == (cmbIl.Text)).id;
            //    ck.ilce = db.ilceler.First(x => x.ilce == (cmbIlce.Text)).id;
            //    ck.hesapId = (int)cmbHesap.SelectedValue;
            //    ck.cariLimit = int.Parse(txtCarilimit.Text);
            //    ck.firmaId = int.Parse((from s in db.Ayarlar where s.Id == 1 select s).First().Firma.ToString());
            //    db.CariKart.Add(ck);
            //    db.SaveChanges();
            //}
        }
        public void Guncelle(int id)
        {
            //CariKart ck = db.CariKart.Find(id);
            //// CariKart ck = db.CariKart.First(x => x.id == id);
            //txtUnvan.Text = ck.unvani.ToString();
            //txtYetkili.Text = ck.yetkili.ToString();
            //mtbTelefon.Text = ck.telefonNo;
            //txtVergiDairesi.Text = ck.vergiDairesi.ToString();
            //txtVergiNo.Text = ck.vergiNo;
            //txtAdres.Text = ck.adres.ToString();
            //txtEPosta.Text = ck.ePosta.ToString();
            //mtbfax.Text = ck.faksNo;
            //mtbGsm.Text = ck.gsm;
            //txtWeb.Text = ck.webAdresi.ToString();
            //dTPTarih.Text = ck.tarih.ToString();
            //txtNot.Text = ck.notu.ToString();
            //////
            ////    cmbIl.ValueMember = ck.ilId.ToString();
            ////   cmbIlce.Text = ck.ilce.ToString();

            ////cmbIl.Text = ck.iller.sehir;
            ////    cmbIlce.Text = ck.iller.ilceler.ToString();
            ////cmbHesap.Text = ck.Hesap.durum.ToString();
            //txtCarilimit.Text = ck.cariLimit.ToString();

            //cmbIl.Text = ck.iller.sehir;

            //cmbIlce.Text = db.ilceler.First(a => a.id == ck.ilce).ilce;


        }
        //void Temizle()
        //{
        //    foreach (Control ct in Controls)
        //        if (ct is TextBox || ct is ComboBox) ct.Text = "";



        //}
        void Guncelle()
        {
            //CariKart ck = db.CariKart.First(x => x.id == Uygulama.secimId);
            //{
            //    ck.unvani = txtUnvan.Text;
            //    ck.yetkili = txtYetkili.Text;
            //    ck.telefonNo = mtbTelefon.Text;
            //    ck.vergiDairesi = txtVergiDairesi.Text;
            //    ck.vergiNo = txtVergiNo.Text;
            //    ck.adres = txtAdres.Text;
            //    ck.ePosta = txtEPosta.Text;
            //    ck.faksNo = mtbfax.Text;
            //    ck.gsm = mtbGsm.Text;
            //    ck.webAdresi = txtWeb.Text;
            //    ck.tarih = Convert.ToDateTime(dTPTarih.Text);
            //    ck.notu = txtNot.Text;
            //    ck.ilId = db.iller.First(x => x.sehir == (cmbIl.Text)).id;
            //    ck.ilce = db.ilceler.First(x => x.ilce == (cmbIlce.Text)).id;
            //    ck.hesapId = (int)cmbHesap.SelectedValue;
            //    ck.cariLimit = int.Parse(txtCarilimit.Text);
            //}
            //db.SaveChanges();
            //m.Guncelle(true);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (this.Text == "Cari Kart Ekle")
            {
                YeniKayit();
            }
            else if (this.Text == "Cari Kart Değiştir")
            {
                Guncelle();
            }
        }
        #region ComboBox 
        private void CariKartEkle_Load(object sender, EventArgs e)
        {

            if (this.Text == "Cari Kart Ekle")
            {
                //cmbIl.DataSource = db.iller.ToList();
                //cmbIl.DisplayMember = "sehir";
                //cmbIl.ValueMember = "id";
                //cmbHesap.DataSource = db.Hesap.ToList();

                //cmbHesap.ValueMember = "id";
                //cmbHesap.DisplayMember = "durum";
                //int a = int.Parse((from x in db.Ayarlar where x.Id == 1 select x).First().Firma.ToString());
                //txtCarilimit.Text = (int.Parse((from s in db.Firma where s.id == a select s).First().borcLimit.ToString())).ToString();

            }
            //////cmbIl.DataSource = db.iller.ToList();
            //////cmbIl.DisplayMember = "sehir";
            //////cmbIl.ValueMember = "id";



            //////var deger = from o in db.Firma
            //////            select new
            //////            {
            //////             o.borcLimit
            //////            }.ToString();
            //////db.Firma.Select
            //////    (o => new
            //////    {
            //////        Adi = o.borcLimit,
            //////    };
            //////txtCarilimit.Text =deger;

            //////cmbHesap.DataSource = db.Hesap.ToList();
            //////cmbHesap.ValueMember = "id";
            //////cmbHesap.DisplayMember = "durum";
        }
        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {


            //if (cmbIl.SelectedIndex != -1)
            //    cmbIlce.DataSource = db.ilceler.Where(x => x.sehir == cmbIl.SelectedIndex + 1).ToList();
            //cmbIlce.DisplayMember = "ilce";
            //cmbIlce.ValueMember = "id";
        }
        #endregion
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtNot.Text = "";
        }

        private void btnYedekAlVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
