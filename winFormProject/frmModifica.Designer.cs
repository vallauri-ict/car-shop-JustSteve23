namespace winFormProject
{
    partial class frmModifica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtV = new System.Windows.Forms.TextBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifica campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "numero campo da modificare";
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(361, 163);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(120, 31);
            this.nud.TabIndex = 2;
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(527, 36);
            this.rtb.Name = "rtb";
            this.rtb.ReadOnly = true;
            this.rtb.Size = new System.Drawing.Size(244, 402);
            this.rtb.TabIndex = 3;
            this.rtb.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "valore campo da modificare";
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(64, 255);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(397, 31);
            this.txtV.TabIndex = 5;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(40, 312);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(441, 77);
            this.btnModifica.TabIndex = 6;
            this.btnModifica.Text = "Modifica campo";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(40, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(441, 59);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Chiudi";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID veiocolo da modificare: ";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(306, 116);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(120, 31);
            this.tbID.TabIndex = 9;
            // 
            // frmModifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.txtV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModifica";
            this.Text = "frmModifica";
            this.Load += new System.EventHandler(this.frmModifica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmModifica_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
    }
}