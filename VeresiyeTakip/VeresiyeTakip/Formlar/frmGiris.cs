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

namespace VeresiyeTakip.Formlar
{
    public partial class frmGiris : DevExpress.XtraEditors.XtraForm
    {
        public static string usr;
       // VeresiyeDBEntities db = new VeresiyeDBEntities();
        public frmGiris()
        {
            InitializeComponent();
        }
        #region Button Giriş Çıkış Click
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Sifre sifre = db.Sifre.Where(x => x.sifre1 == txtSifre.Text).SingleOrDefault();
            //if (sifre == null)
            //{
            //    MessageBox.Show("Kullanıcı şifresi yanlış lütfen tekrar deneyiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //else if (sifre != null)
            //{
            //    this.Hide();
            //    usr = txtSifre.Text;
            //    frmAnasayfa u = new frmAnasayfa();
            //    u.ShowDialog();

            //}
        }
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formun Çıkış ekranına basınca, programı tamamen kapatma işlemi yapma.
            Application.Exit();
        }
        #endregion

    }
}