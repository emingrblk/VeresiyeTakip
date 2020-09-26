namespace VeresiyeTakip
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Şifre = new System.Windows.Forms.Label();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.telif = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.Label();
            this.sürüm = new System.Windows.Forms.Label();
            this.Veresiye = new System.Windows.Forms.Label();
            this.btnCıkıs = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Şifre);
            this.groupControl1.Controls.Add(this.txtSifre);
            this.groupControl1.Location = new System.Drawing.Point(182, 153);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(273, 60);
            this.groupControl1.TabIndex = 45;
            // 
            // Şifre
            // 
            this.Şifre.AutoSize = true;
            this.Şifre.Location = new System.Drawing.Point(21, 18);
            this.Şifre.Name = "Şifre";
            this.Şifre.Size = new System.Drawing.Size(37, 13);
            this.Şifre.TabIndex = 2;
            this.Şifre.Text = "Şifre=";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(64, 15);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(200, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(162, 210);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 44;
            this.pictureBox.TabStop = false;
            // 
            // telif
            // 
            this.telif.AutoSize = true;
            this.telif.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telif.ForeColor = System.Drawing.Color.Black;
            this.telif.Location = new System.Drawing.Point(207, 101);
            this.telif.Name = "telif";
            this.telif.Size = new System.Drawing.Size(237, 13);
            this.telif.TabIndex = 43;
            this.telif.Text = "Telif hakkı @ 2019 Emin Gürbulak\'a aittir.";
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.ForeColor = System.Drawing.Color.Black;
            this.isim.Location = new System.Drawing.Point(206, 84);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(133, 13);
            this.isim.TabIndex = 42;
            this.isim.Text = "Veresiye(Profesyonel)";
            // 
            // sürüm
            // 
            this.sürüm.AutoSize = true;
            this.sürüm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sürüm.ForeColor = System.Drawing.Color.Black;
            this.sürüm.Location = new System.Drawing.Point(206, 67);
            this.sürüm.Name = "sürüm";
            this.sürüm.Size = new System.Drawing.Size(67, 13);
            this.sürüm.TabIndex = 41;
            this.sürüm.Text = "Sürüm: 1.0";
            // 
            // Veresiye
            // 
            this.Veresiye.AutoSize = true;
            this.Veresiye.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Veresiye.Location = new System.Drawing.Point(322, 33);
            this.Veresiye.Name = "Veresiye";
            this.Veresiye.Size = new System.Drawing.Size(130, 19);
            this.Veresiye.TabIndex = 40;
            this.Veresiye.Text = "Veresiye Takip";
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCıkıs.ImageOptions.Image")));
            this.btnCıkıs.Location = new System.Drawing.Point(182, 241);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(116, 54);
            this.btnCıkıs.TabIndex = 39;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
            this.btnGiris.Location = new System.Drawing.Point(339, 241);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(116, 54);
            this.btnGiris.TabIndex = 38;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 323);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.telif);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.sürüm);
            this.Controls.Add(this.Veresiye);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnGiris);
            this.Name = "Giris";
            this.Text = "Giris";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label Şifre;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label telif;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Label sürüm;
        private System.Windows.Forms.Label Veresiye;
        private DevExpress.XtraEditors.SimpleButton btnCıkıs;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
    }
}