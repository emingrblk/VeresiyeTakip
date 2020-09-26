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

namespace VeresiyeTakip.Forms
{
    public partial class frmListeToplamları : DevExpress.XtraEditors.XtraForm
    {
        public frmListeToplamları()
        {
            InitializeComponent();
        }

    
        private void frmListeToplamları_Load(object sender, EventArgs e)
        {

        }

        private void btnVazgecAciklama_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}