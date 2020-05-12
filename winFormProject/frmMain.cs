using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using venditaVeicoliDLLProject;
using static venditaVeicoliDLLProject.Utilities;
using Microsoft.VisualBasic;
using System.Data.OleDb;
using DocumentFormat.OpenXml.CustomProperties;

namespace winFormProject
{ 
    public partial class frmMain : Form
    {
    static string connectionStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\DB\\Veicoli.accdb";
    SerializableBindingList<veicolo> listVeicolo;
        int[] iDs = new int[10000];
        public frmMain()
        { 
            listVeicolo = new SerializableBindingList<veicolo>();
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            dgv.ClearSelection();
            CaricaDatiDiTesto();
        }

        private void CaricaDatiDiTesto()
        {
            dgv.Rows.Clear();
            string ctrlDatapassEXVAR = DB.datapass(connectionStr, listVeicolo, iDs);
            if (ctrlDatapassEXVAR != "DONE")
            {
                MessageBox.Show(ctrlDatapassEXVAR);
                this.Close();
            }

            int rowN = 0;
            foreach (var item in listVeicolo)
            {
                dgv.Rows.Add();
                dgv.Rows[rowN].Cells[0].Value = iDs[rowN];
                dgv.Rows[rowN].Cells[1].Value = item.Marca;
                dgv.Rows[rowN].Cells[2].Value = item.Modello;
                dgv.Rows[rowN].Cells[3].Value = item.Colore;
                dgv.Rows[rowN].Cells[4].Value = item.Prezzo + "$";

                rowN++;
            }
        }

        private void toolStripBtnAddVeicolo_Click_1(object sender, EventArgs e)
        {
            AggiungiVeicoloDialog frmDialog = new AggiungiVeicoloDialog(listVeicolo);
            frmDialog.ShowDialog();
            CaricaDatiDiTesto();
        }

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {
            Utilities.SerializeToCsv(listVeicolo, "./veicolo.csv");
            Utilities.SerializeToXml(listVeicolo, "./veicolo.xml");
            Utilities.SerializeToJson(listVeicolo, "./veicolo.json");
        }

        private void tlsBtnCaricaOnline_Click(object sender, EventArgs e)
        {
            string homePath = @".\www.\index.html";
            Utilities.createHTML(listVeicolo, homePath);
            System.Diagnostics.Process.Start(homePath);
        }

        private void tsbWordParse_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities.WordDocumentCreation(listVeicolo);
                SystemSounds.Beep.Play();
                System.Diagnostics.Process.Start("veicoli.docx");
            }
            catch (Exception)
            {
                MessageBox.Show("Errore creazione foglio di word");
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex>=0 && e.ColumnIndex==6)
            {
                frmDettagli FRD = new frmDettagli(iDs[e.RowIndex],iDs,listVeicolo);
                FRD.ShowDialog();
            }

            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                try
                {
                    DB.deleteVehicle(connectionStr, iDs[e.RowIndex]);
                    CaricaDatiDiTesto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("!!ERROR!! " + ex.Message);
                }
            }
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                frmModifica FMD = new frmModifica(iDs[e.RowIndex]);
                FMD.ShowDialog();
                CaricaDatiDiTesto();
            }
        }
    }
}
