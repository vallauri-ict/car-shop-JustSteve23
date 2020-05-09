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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAddVeicolo = new System.Windows.Forms.ToolStripButton();
            this.salvaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnCaricaOnline = new System.Windows.Forms.ToolStripButton();
            this.tsbWordParse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminaVeicolo = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAddVeicolo,
            this.salvaToolStripButton,
            this.toolStripSeparator2,
            this.tlsBtnCaricaOnline,
            this.tsbWordParse,
            this.toolStripSeparator1,
            this.tsbEliminaVeicolo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(2956, 42);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAddVeicolo
            // 
            this.toolStripBtnAddVeicolo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnAddVeicolo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAddVeicolo.Image")));
            this.toolStripBtnAddVeicolo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAddVeicolo.Name = "toolStripBtnAddVeicolo";
            this.toolStripBtnAddVeicolo.Size = new System.Drawing.Size(91, 36);
            this.toolStripBtnAddVeicolo.Text = "&Nuovo";
            this.toolStripBtnAddVeicolo.Click += new System.EventHandler(this.toolStripBtnAddVeicolo_Click_1);
            // 
            // salvaToolStripButton
            // 
            this.salvaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.salvaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripButton.Image")));
            this.salvaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripButton.Name = "salvaToolStripButton";
            this.salvaToolStripButton.Size = new System.Drawing.Size(74, 36);
            this.salvaToolStripButton.Text = "&Salva";
            this.salvaToolStripButton.Click += new System.EventHandler(this.salvaToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // tlsBtnCaricaOnline
            // 
            this.tlsBtnCaricaOnline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlsBtnCaricaOnline.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnCaricaOnline.Image")));
            this.tlsBtnCaricaOnline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnCaricaOnline.Name = "tlsBtnCaricaOnline";
            this.tlsBtnCaricaOnline.Size = new System.Drawing.Size(154, 36);
            this.tlsBtnCaricaOnline.Text = "CaricaOnline";
            this.tlsBtnCaricaOnline.Click += new System.EventHandler(this.tlsBtnCaricaOnline_Click);
            // 
            // tsbWordParse
            // 
            this.tsbWordParse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbWordParse.Image = ((System.Drawing.Image)(resources.GetObject("tsbWordParse.Image")));
            this.tsbWordParse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWordParse.Name = "tsbWordParse";
            this.tsbWordParse.Size = new System.Drawing.Size(113, 36);
            this.tsbWordParse.Text = "WordFile";
            this.tsbWordParse.Click += new System.EventHandler(this.tsbWordParse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // tsbEliminaVeicolo
            // 
            this.tsbEliminaVeicolo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEliminaVeicolo.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminaVeicolo.Image")));
            this.tsbEliminaVeicolo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminaVeicolo.Name = "tsbEliminaVeicolo";
            this.tsbEliminaVeicolo.Size = new System.Drawing.Size(180, 36);
            this.tsbEliminaVeicolo.Text = "Elimina Veicolo";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column13,
            this.Column5,
            this.dgvBtn,
            this.Column2});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 42);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(2956, 1228);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // column1
            // 
            this.column1.HeaderText = "ID";
            this.column1.MinimumWidth = 10;
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            this.column1.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modello";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Colore";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Prezzo";
            this.Column13.MinimumWidth = 10;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Modifica";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "Modifica";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // dgvBtn
            // 
            this.dgvBtn.HeaderText = "Dettagli";
            this.dgvBtn.MinimumWidth = 10;
            this.dgvBtn.Name = "dgvBtn";
            this.dgvBtn.ReadOnly = true;
            this.dgvBtn.Text = "Dettagli";
            this.dgvBtn.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Elimina";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Elimina";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2956, 1270);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Car shop";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAddVeicolo;
        private System.Windows.Forms.ToolStripButton salvaToolStripButton;
        private System.Windows.Forms.ToolStripButton tlsBtnCaricaOnline;
        private System.Windows.Forms.ToolStripButton tsbWordParse;
        private System.Windows.Forms.ToolStripButton tsbEliminaVeicolo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtn;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}

