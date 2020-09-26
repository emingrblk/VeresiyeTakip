namespace VeresiyeTakip.Forms
{
    partial class frmFirmaİslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmaİslemleri));
            this.panelUst = new System.Windows.Forms.Panel();
            this.firmaUstLabel = new System.Windows.Forms.Label();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnCariHesabiAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.pnlKayit = new System.Windows.Forms.Panel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.mtbFaks = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.cmbIl = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVarsayılanBorcLimit = new System.Windows.Forms.TextBox();
            this.cmbParaBirimi = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtFirmaUnvani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlfirma = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.Listele = new System.Windows.Forms.DataGridView();
            this.panelUst.SuspendLayout();
            this.pnlAlt.SuspendLayout();
            this.pnlKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.pnlfirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listele)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panelUst.Controls.Add(this.firmaUstLabel);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(526, 48);
            this.panelUst.TabIndex = 0;
            // 
            // firmaUstLabel
            // 
            this.firmaUstLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmaUstLabel.Location = new System.Drawing.Point(285, 21);
            this.firmaUstLabel.Name = "firmaUstLabel";
            this.firmaUstLabel.Size = new System.Drawing.Size(233, 19);
            this.firmaUstLabel.TabIndex = 41;
            this.firmaUstLabel.Text = "Firma Hesapları";
            this.firmaUstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pnlAlt.Controls.Add(this.btnSil);
            this.pnlAlt.Controls.Add(this.btnCariHesabiAc);
            this.pnlAlt.Controls.Add(this.btnDegistir);
            this.pnlAlt.Controls.Add(this.btnEkle);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 362);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(526, 76);
            this.pnlAlt.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(268, 10);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 54);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCariHesabiAc
            // 
            this.btnCariHesabiAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCariHesabiAc.ImageOptions.Image")));
            this.btnCariHesabiAc.Location = new System.Drawing.Point(400, 9);
            this.btnCariHesabiAc.Name = "btnCariHesabiAc";
            this.btnCariHesabiAc.Size = new System.Drawing.Size(118, 54);
            this.btnCariHesabiAc.TabIndex = 0;
            this.btnCariHesabiAc.Text = "Cari Firma Aç";
            this.btnCariHesabiAc.Click += new System.EventHandler(this.btnCariHesabiAc_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.ImageOptions.Image")));
            this.btnDegistir.Location = new System.Drawing.Point(138, 10);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(100, 54);
            this.btnDegistir.TabIndex = 1;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(13, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 54);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pnlKayit
            // 
            this.pnlKayit.Controls.Add(this.groupControl3);
            this.pnlKayit.Controls.Add(this.groupControl2);
            this.pnlKayit.Controls.Add(this.groupControl1);
            this.pnlKayit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKayit.Location = new System.Drawing.Point(0, 48);
            this.pnlKayit.Name = "pnlKayit";
            this.pnlKayit.Size = new System.Drawing.Size(518, 314);
            this.pnlKayit.TabIndex = 14;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.mtbFaks);
            this.groupControl3.Controls.Add(this.mtbTelefon);
            this.groupControl3.Controls.Add(this.cmbIlce);
            this.groupControl3.Controls.Add(this.cmbIl);
            this.groupControl3.Controls.Add(this.label9);
            this.groupControl3.Controls.Add(this.label8);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.txtAdres);
            this.groupControl3.Controls.Add(this.txtVergiDairesi);
            this.groupControl3.Controls.Add(this.txtVergiNo);
            this.groupControl3.Location = new System.Drawing.Point(13, 83);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(496, 142);
            this.groupControl3.TabIndex = 14;
            this.groupControl3.Text = "groupControl3";
            // 
            // mtbFaks
            // 
            this.mtbFaks.Location = new System.Drawing.Point(345, 17);
            this.mtbFaks.Name = "mtbFaks";
            this.mtbFaks.Size = new System.Drawing.Size(141, 21);
            this.mtbFaks.TabIndex = 18;
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Location = new System.Drawing.Point(124, 16);
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(141, 21);
            this.mtbTelefon.TabIndex = 18;
            // 
            // cmbIlce
            // 
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(345, 71);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(140, 21);
            this.cmbIlce.TabIndex = 4;
            // 
            // cmbIl
            // 
            this.cmbIl.FormattingEnabled = true;
            this.cmbIl.Location = new System.Drawing.Point(125, 71);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Size = new System.Drawing.Size(140, 21);
            this.cmbIl.TabIndex = 3;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(269, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "V.No          =";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(269, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Faks No     =";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(269, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "İlçe            =";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "İl                                =";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(5, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vergi Dairesi              =";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adres                        =";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Telefon No                =";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(125, 46);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(360, 21);
            this.txtAdres.TabIndex = 2;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(125, 96);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(140, 21);
            this.txtVergiDairesi.TabIndex = 5;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(345, 98);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(140, 21);
            this.txtVergiNo.TabIndex = 6;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.txtVarsayılanBorcLimit);
            this.groupControl2.Controls.Add(this.cmbParaBirimi);
            this.groupControl2.Location = new System.Drawing.Point(13, 243);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(496, 51);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "groupControl2";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(269, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Para Birimi  =";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Varsayılan Borç Limiti =";
            // 
            // txtVarsayılanBorcLimit
            // 
            this.txtVarsayılanBorcLimit.Location = new System.Drawing.Point(125, 15);
            this.txtVarsayılanBorcLimit.Name = "txtVarsayılanBorcLimit";
            this.txtVarsayılanBorcLimit.Size = new System.Drawing.Size(140, 21);
            this.txtVarsayılanBorcLimit.TabIndex = 0;
            this.txtVarsayılanBorcLimit.Text = "10000";
            this.txtVarsayılanBorcLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbParaBirimi
            // 
            this.cmbParaBirimi.FormattingEnabled = true;
            this.cmbParaBirimi.Location = new System.Drawing.Point(345, 15);
            this.cmbParaBirimi.Name = "cmbParaBirimi";
            this.cmbParaBirimi.Size = new System.Drawing.Size(140, 21);
            this.cmbParaBirimi.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtFirmaUnvani);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(12, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(496, 51);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtFirmaUnvani
            // 
            this.txtFirmaUnvani.Location = new System.Drawing.Point(125, 15);
            this.txtFirmaUnvani.Name = "txtFirmaUnvani";
            this.txtFirmaUnvani.Size = new System.Drawing.Size(360, 21);
            this.txtFirmaUnvani.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firma Ünvanı             =";
            // 
            // pnlfirma
            // 
            this.pnlfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pnlfirma.Controls.Add(this.label12);
            this.pnlfirma.Controls.Add(this.Listele);
            this.pnlfirma.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlfirma.Location = new System.Drawing.Point(0, 48);
            this.pnlfirma.Name = "pnlfirma";
            this.pnlfirma.Size = new System.Drawing.Size(526, 314);
            this.pnlfirma.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(513, 43);
            this.label12.TabIndex = 1;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // Listele
            // 
            this.Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listele.Location = new System.Drawing.Point(3, 49);
            this.Listele.Name = "Listele";
            this.Listele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Listele.Size = new System.Drawing.Size(517, 259);
            this.Listele.TabIndex = 0;
            // 
            // frmFirmaİslemleri
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 438);
            this.Controls.Add(this.pnlfirma);
            this.Controls.Add(this.pnlKayit);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.panelUst);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(536, 470);
            this.Name = "frmFirmaİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma İslemleri";
            this.Load += new System.EventHandler(this.frmFirmaİslemleri_Load);
            this.panelUst.ResumeLayout(false);
            this.pnlAlt.ResumeLayout(false);
            this.pnlKayit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.pnlfirma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Listele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Label firmaUstLabel;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnCariHesabiAc;
        private DevExpress.XtraEditors.SimpleButton btnDegistir;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.Panel pnlKayit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.TextBox txtVergiNo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtVarsayılanBorcLimit;
        private System.Windows.Forms.ComboBox cmbParaBirimi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlfirma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView Listele;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirmaUnvani;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.ComboBox cmbIl;
        private System.Windows.Forms.MaskedTextBox mtbFaks;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
    }
}