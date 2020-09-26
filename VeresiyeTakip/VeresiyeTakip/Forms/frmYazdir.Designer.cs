namespace VeresiyeTakip.Forms
{
    partial class frmYazdir
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
            this.crPrint = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crPrint
            // 
            this.crPrint.ActiveViewIndex = -1;
            this.crPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.crPrint.DisplayStatusBar = false;
            this.crPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crPrint.Location = new System.Drawing.Point(0, 0);
            this.crPrint.Name = "crPrint";
            this.crPrint.ReuseParameterValuesOnRefresh = true;
            this.crPrint.ShowExportButton = false;
            this.crPrint.ShowGroupTreeButton = false;
            this.crPrint.ShowLogo = false;
            this.crPrint.ShowParameterPanelButton = false;
            this.crPrint.Size = new System.Drawing.Size(800, 450);
            this.crPrint.TabIndex = 0;
            this.crPrint.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crPrint.Load += new System.EventHandler(this.crPrint_Load);
            // 
            // frmYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crPrint);
            this.Name = "frmYazdir";
            this.Text = "Report(Ön İzleme)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmYazdir_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crPrint;
    }
}