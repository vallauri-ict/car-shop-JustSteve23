namespace winFormProject
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbVeicoli = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAddVeicolo = new System.Windows.Forms.ToolStripButton();
            this.salvaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.apriToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnCaricaOnline = new System.Windows.Forms.ToolStripButton();
            this.tsbWordParse = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminaVeicolo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVeicoli
            // 
            this.lbVeicoli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVeicoli.FormattingEnabled = true;
            this.lbVeicoli.ItemHeight = 25;
            this.lbVeicoli.Location = new System.Drawing.Point(0, 50);
            this.lbVeicoli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbVeicoli.Name = "lbVeicoli";
            this.lbVeicoli.Size = new System.Drawing.Size(1090, 610);
            this.lbVeicoli.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAddVeicolo,
            this.salvaToolStripButton,
            this.apriToolStripButton,
            this.tlsBtnCaricaOnline,
            this.tsbWordParse,
            this.tsbEliminaVeicolo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1090, 50);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAddVeicolo
            // 
            this.toolStripBtnAddVeicolo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnAddVeicolo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAddVeicolo.Image")));
            this.toolStripBtnAddVeicolo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAddVeicolo.Name = "toolStripBtnAddVeicolo";
            this.toolStripBtnAddVeicolo.Size = new System.Drawing.Size(91, 44);
            this.toolStripBtnAddVeicolo.Text = "&Nuovo";
            this.toolStripBtnAddVeicolo.Click += new System.EventHandler(this.toolStripBtnAddVeicolo_Click_1);
            // 
            // salvaToolStripButton
            // 
            this.salvaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.salvaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripButton.Image")));
            this.salvaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripButton.Name = "salvaToolStripButton";
            this.salvaToolStripButton.Size = new System.Drawing.Size(74, 44);
            this.salvaToolStripButton.Text = "&Salva";
            this.salvaToolStripButton.Click += new System.EventHandler(this.salvaToolStripButton_Click);
            // 
            // apriToolStripButton
            // 
            this.apriToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.apriToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("apriToolStripButton.Image")));
            this.apriToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apriToolStripButton.Name = "apriToolStripButton";
            this.apriToolStripButton.Size = new System.Drawing.Size(62, 44);
            this.apriToolStripButton.Text = "&Apri";
            this.apriToolStripButton.Click += new System.EventHandler(this.apriToolStripButton_Click);
            // 
            // tlsBtnCaricaOnline
            // 
            this.tlsBtnCaricaOnline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlsBtnCaricaOnline.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnCaricaOnline.Image")));
            this.tlsBtnCaricaOnline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnCaricaOnline.Name = "tlsBtnCaricaOnline";
            this.tlsBtnCaricaOnline.Size = new System.Drawing.Size(154, 44);
            this.tlsBtnCaricaOnline.Text = "CaricaOnline";
            this.tlsBtnCaricaOnline.Click += new System.EventHandler(this.tlsBtnCaricaOnline_Click);
            // 
            // tsbWordParse
            // 
            this.tsbWordParse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbWordParse.Image = ((System.Drawing.Image)(resources.GetObject("tsbWordParse.Image")));
            this.tsbWordParse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWordParse.Name = "tsbWordParse";
            this.tsbWordParse.Size = new System.Drawing.Size(113, 44);
            this.tsbWordParse.Text = "WordFile";
            this.tsbWordParse.Click += new System.EventHandler(this.tsbWordParse_Click);
            // 
            // tsbEliminaVeicolo
            // 
            this.tsbEliminaVeicolo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEliminaVeicolo.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminaVeicolo.Image")));
            this.tsbEliminaVeicolo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminaVeicolo.Name = "tsbEliminaVeicolo";
            this.tsbEliminaVeicolo.Size = new System.Drawing.Size(180, 44);
            this.tsbEliminaVeicolo.Text = "Elimina Veicolo";
            this.tsbEliminaVeicolo.Click += new System.EventHandler(this.tsbEliminaVeicolo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 660);
            this.Controls.Add(this.lbVeicoli);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Salone Vendita";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVeicoli;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAddVeicolo;
        private System.Windows.Forms.ToolStripButton apriToolStripButton;
        private System.Windows.Forms.ToolStripButton salvaToolStripButton;
        private System.Windows.Forms.ToolStripButton tlsBtnCaricaOnline;
        private System.Windows.Forms.ToolStripButton tsbWordParse;
        private System.Windows.Forms.ToolStripButton tsbEliminaVeicolo;
    }
}

