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
    public partial class frmListeToplamlari : DevExpress.XtraEditors.XtraForm
    {
        public frmListeToplamlari()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}