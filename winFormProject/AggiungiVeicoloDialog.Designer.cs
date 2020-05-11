namespace winFormProject
{
    partial class AggiungiVeicoloDialog
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
            this.cmbTipoVeicolo = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCilindrata = new System.Windows.Forms.TextBox();
            this.txtPotenza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpImm = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMP = new System.Windows.Forms.NumericUpDown();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUsato = new System.Windows.Forms.CheckBox();
            this.cbKmZero = new System.Windows.Forms.CheckBox();
            this.lblMarcaSella = new System.Windows.Forms.Label();
            this.tbMarcaSella = new System.Windows.Forms.TextBox();
            this.lblNAirBag = new System.Windows.Forms.Label();
            this.nudNumeroAirBag = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroAirBag)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoVeicolo
            // 
            this.cmbTipoVeicolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVeicolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoVeicolo.FormattingEnabled = true;
            this.cmbTipoVeicolo.Items.AddRange(new object[] {
            "auto",
            "moto"});
            this.cmbTipoVeicolo.Location = new System.Drawing.Point(193, 12);
            this.cmbTipoVeicolo.Name = "cmbTipoVeicolo";
            this.cmbTipoVeicolo.Size = new System.Drawing.Size(227, 33);
            this.cmbTipoVeicolo.TabIndex = 0;
            this.cmbTipoVeicolo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVeicolo_SelectedIndexChanged);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(500, 443);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(178, 54);
            this.btnAggiungi.TabIndex = 1;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(684, 443);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(178, 54);
            this.btnAnnulla.TabIndex = 2;
            this.btnAnnulla.Text = "Chiudi";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(193, 86);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(223, 33);
            this.cmbMarca.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modello";
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(580, 83);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(224, 31);
            this.txtModello.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cilindrata";
            // 
            // txtCilindrata
            // 
            this.txtCilindrata.Location = new System.Drawing.Point(193, 154);
            this.txtCilindrata.Name = "txtCilindrata";
            this.txtCilindrata.Size = new System.Drawing.Size(224, 31);
            this.txtCilindrata.TabIndex = 8;
            // 
            // txtPotenza
            // 
            this.txtPotenza.Location = new System.Drawing.Point(580, 154);
            this.txtPotenza.Name = "txtPotenza";
            this.txtPotenza.Size = new System.Drawing.Size(224, 31);
            this.txtPotenza.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Potenza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Immatricolazione";
            // 
            // dtpImm
            // 
            this.dtpImm.Location = new System.Drawing.Point(193, 214);
            this.dtpImm.Name = "dtpImm";
            this.dtpImm.Size = new System.Drawing.Size(224, 31);
            this.dtpImm.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "Km \r\nPercorsi";
            // 
            // nudMP
            // 
            this.nudMP.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMP.Location = new System.Drawing.Point(580, 217);
            this.nudMP.Name = "nudMP";
            this.nudMP.Size = new System.Drawing.Size(224, 31);
            this.nudMP.TabIndex = 14;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(193, 280);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(223, 33);
            this.cmbColor.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Colore";
            // 
            // cbUsato
            // 
            this.cbUsato.AutoSize = true;
            this.cbUsato.Location = new System.Drawing.Point(476, 280);
            this.cbUsato.Name = "cbUsato";
            this.cbUsato.Size = new System.Drawing.Size(100, 29);
            this.cbUsato.TabIndex = 17;
            this.cbUsato.Text = "Usato";
            this.cbUsato.UseVisualStyleBackColor = true;
            this.cbUsato.CheckedChanged += new System.EventHandler(this.cbUsato_CheckedChanged);
            // 
            // cbKmZero
            // 
            this.cbKmZero.AutoSize = true;
            this.cbKmZero.Location = new System.Drawing.Point(654, 282);
            this.cbKmZero.Name = "cbKmZero";
            this.cbKmZero.Size = new System.Drawing.Size(88, 29);
            this.cbKmZero.TabIndex = 18;
            this.cbKmZero.Text = "KM0";
            this.cbKmZero.UseVisualStyleBackColor = true;
            this.cbKmZero.CheckedChanged += new System.EventHandler(this.cbKmZero_CheckedChanged);
            // 
            // lblMarcaSella
            // 
            this.lblMarcaSella.AutoSize = true;
            this.lblMarcaSella.Location = new System.Drawing.Point(13, 350);
            this.lblMarcaSella.Name = "lblMarcaSella";
            this.lblMarcaSella.Size = new System.Drawing.Size(123, 25);
            this.lblMarcaSella.TabIndex = 19;
            this.lblMarcaSella.Text = "Marca sella";
            // 
            // tbMarcaSella
            // 
            this.tbMarcaSella.Location = new System.Drawing.Point(192, 347);
            this.tbMarcaSella.Name = "tbMarcaSella";
            this.tbMarcaSella.Size = new System.Drawing.Size(224, 31);
            this.tbMarcaSella.TabIndex = 20;
            // 
            // lblNAirBag
            // 
            this.lblNAirBag.AutoSize = true;
            this.lblNAirBag.Location = new System.Drawing.Point(467, 328);
            this.lblNAirBag.Name = "lblNAirBag";
            this.lblNAirBag.Size = new System.Drawing.Size(93, 50);
            this.lblNAirBag.TabIndex = 21;
            this.lblNAirBag.Text = "Numero \r\nAirBag";
            // 
            // nudNumeroAirBag
            // 
            this.nudNumeroAirBag.Location = new System.Drawing.Point(580, 344);
            this.nudNumeroAirBag.Name = "nudNumeroAirBag";
            this.nudNumeroAirBag.Size = new System.Drawing.Size(224, 31);
            this.nudNumeroAirBag.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tipo veicolo ";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(580, 15);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(224, 31);
            this.txtPrezzo.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Prezzo";
            // 
            // AggiungiVeicoloDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnulla;
            this.ClientSize = new System.Drawing.Size(868, 507);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudNumeroAirBag);
            this.Controls.Add(this.lblNAirBag);
            this.Controls.Add(this.tbMarcaSella);
            this.Controls.Add(this.lblMarcaSella);
            this.Controls.Add(this.cbKmZero);
            this.Controls.Add(this.cbUsato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.nudMP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpImm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPotenza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCilindrata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModello);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.cmbTipoVeicolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AggiungiVeicoloDialog";
            this.Text = "AggiungiVeicolo";
            this.Load += new System.EventHandler(this.AggiungiVeicoloDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroAirBag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoVeicolo;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCilindrata;
        private System.Windows.Forms.TextBox txtPotenza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpImm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMP;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbUsato;
        private System.Windows.Forms.CheckBox cbKmZero;
        private System.Windows.Forms.Label lblMarcaSella;
        private System.Windows.Forms.TextBox tbMarcaSella;
        private System.Windows.Forms.Label lblNAirBag;
        private System.Windows.Forms.NumericUpDown nudNumeroAirBag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.Label label9;
    }
}