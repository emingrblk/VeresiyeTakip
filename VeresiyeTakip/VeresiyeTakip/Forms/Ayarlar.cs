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

namespace VeresiyeTakip
{
    public partial class Ayarlar : DevExpress.XtraEditors.XtraForm
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        string kullanici_usr = Giris.usr;

        #region Onayla Button Click
        private void btnOnaylaSifre_Click(object sender, EventArgs e)
        {
            if (txtEskiSifre.Text == "" || txtYeniSifre.Text == "" || txtYeniSifre.Text == "")
            {
                errorProvider1.SetError(lblerror, "Lütfen boş alan bırakmayınız!");
            }
            else
            {
                if (kullanici_usr != txtEskiSifre.Text)
                {
                    MessageBox.Show("Şifreniz Yanlış!");
                }
                else
                {
                    if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                    {
                        if (kullanici_usr == txtEskiSifre.Text)
                        {
                            //var guncellenecekSifre = db.Sifre.Where(w => w.sifre1 == txtEskiSifre.Text).FirstOrDefault();
                            //guncellenecekSifre.sifre1 = txtYeniSifre.Text;

                            //kullanici_usr = guncellenecekSifre.sifre1;
                            //db.SaveChanges();
                            //lblerror.Text = "Şifre Değiştirildi.";

                            //txtEskiSifre.Text = txtYeniSifre.Text = txtYeniSifreTekrar.Text = "";

                        }
                        else
                        {

                            lblerror.Text = "Şifre Değiştirilemedi!";
                        }
                    }
                    else
                    {

                        lblerror.Text = "Şifreler Uyumuşmuyor!";
                    }
                }
            }
        }

        #endregion
        #region Vazgeç Button Click
        private void btnVazgecSifre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVazgecAciklama_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVazgecAyar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        #region Silme  Button Click


        private void btnTumSil_Click(object sender, EventArgs e)
        {

        }
        private void btnSecileniSil_Click(object sender, EventArgs e)
        {

        }

        #endregion
       
    }
}