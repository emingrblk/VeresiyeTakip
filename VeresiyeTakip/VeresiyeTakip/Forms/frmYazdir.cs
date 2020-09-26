using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeresiyeTakip.Forms
{
    public partial class frmYazdir : Form
    {
        public string HangiListe;
        VeresiyeDBEntities db = new VeresiyeDBEntities();
        public frmYazdir()
        {
            InitializeComponent();
        }

        private void frmYazdir_Load(object sender, EventArgs e)
        {

            switch (HangiListe)
            {
                case "CariKart":
                    Cari();
                    break;
                default:
                    break;
            }
        }

        private void Cari()
        {
            frmYazdir frm = Application.OpenForms["frmYazdir"] as frmYazdir;
            crPrint cr = new crPrint();
            int a = int.Parse((from x in db.Ayarlar where x.Id == 1 select x).First().Firma.ToString());
            var lst = db.spFirmaBilgi(a).ToList();
            if (lst != null)
            {
                PrintYardim ch = new PrintYardim();
                DataTable dt = ch.ConvertTo(lst);
                cr.SetDataSource(dt);
                crPrint.ReportSource = cr;


            }
        }

        private void crPrint_Load(object sender, EventArgs e)
        {

        }
    }
}
