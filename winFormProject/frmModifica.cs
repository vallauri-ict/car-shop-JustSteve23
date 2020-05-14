using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using venditaVeicoliDLLProject;

namespace winFormProject
{
    public partial class frmModifica : Form
    {
        static string connectionStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\DB\\Veicoli.accdb";

        int id;
        public frmModifica(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        string[] DBFieldArray = { "type (auto/moto)", "marca", "modello", "cilindrata", "potenzaKw", "dataImmatricolazione", "kmPercorsi", "colore", "isUsato (SI/NO)", "isKm0 (SI/NO)", "info", "prezzo" };

        private void frmModifica_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            tbID.Text = id.ToString();
            for (int i = 0; i < DBFieldArray.Length; i++)
            {
                rtb.Text +=i+"-> "+DBFieldArray[i]+"\n";
            }

            nud.Maximum = DBFieldArray.Length-1;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Ins();
        }

        private void frmModifica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Ins();
            }
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ins()
        {
            try
            {
                switch (nud.Value)
                {
                    case 0:
                        InsCh("auto", "moto");
                        break;
                    case 8:
                        InsCh("SI", "NO");
                        break;
                    case 9:
                        InsCh("SI", "NO");
                        break;
                }
                MessageBox.Show((DB.updateVehicle(connectionStr, id.ToString(), DBFieldArray[Convert.ToInt32(nud.Value)], txtV.Text, Convert.ToInt32(nud.Value))));
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!ERROR!!\n" + ex.Message);
            }
            txtV.Clear();
            nud.Value = nud.Minimum;
        }

        private void InsCh(string p1,string p2)
        {
            if (txtV.Text != p1 && txtV.Text != p2)
            {
                throw new Exception("Inserimento non valido");
            }
        }
    }
}
