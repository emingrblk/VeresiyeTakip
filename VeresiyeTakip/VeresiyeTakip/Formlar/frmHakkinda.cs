﻿using System;
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
    public partial class frmHakkinda : DevExpress.XtraEditors.XtraForm
    {
        public frmHakkinda()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}