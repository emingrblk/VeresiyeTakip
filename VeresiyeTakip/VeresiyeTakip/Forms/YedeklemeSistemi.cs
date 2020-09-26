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
using System.Data.SqlClient;

namespace VeresiyeTakip
{
    public partial class YedeklemeSistemi : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = new SqlConnection(VeresiyeTakip.Properties.Settings.Default.DBConnectionString);

        public YedeklemeSistemi()
        {
            InitializeComponent();
        }

        #region Button GözAt
        private void btnYedekAlGozAt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtHedefKlasör.Text = dlg.SelectedPath;
                btnYedekAl.Enabled = true;
            }
        }
        private void btnGeriYuklemeGozAt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtYedekDosyasi.Text = dlg.FileName;
                btnGeriYukle.Enabled = true;
            }
        }
        #endregion
        #region Button Yedek Alma ve Geri Yükleme
        private void btnYedekAl_Click(object sender, EventArgs e)
        {

            string database = con.Database.ToString();

            if (txtHedefKlasör.Text == string.Empty)
            {
                MessageBox.Show("Lütfen veritabanının yedekleneceği yeri seçiniz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txtHedefKlasör.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                using (SqlCommand command = new SqlCommand(cmd, con))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Veritabanı yedeklemesi başarıyla yapıldı.", "Yedekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    btnYedekAl.Enabled = false;
                }
            }
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();

            if (txtHedefKlasör.Text == string.Empty)
            {
                MessageBox.Show("Lütfen yedekleme yapmak için dosyanızı seçiniz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd1 = new SqlCommand("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ", con);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtYedekDosyasi.Text + "' WITH REPLACE", con);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand("ALTER DATABASE [" + database + "] SET MULTI_USER", con);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Veritabanı restorasyonu başarılı gerçekleşti..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
        }
        #endregion
        #region Button Vazgeç
        private void btnYedekAlVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGeriYukleVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}