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
        string[] DBFieldArray = { "type", "marca", "modello", "cilindrata", "potenzaKw", "dataImmatricolazione", "kmPercorsi", "colore", "isUsato", "isKm0", "info", "prezzo" };

        private void frmModifica_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < DBFieldArray.Length; i++)
            {
                rtb.Text +=i+"-> "+DBFieldArray[i]+"\n";
            }

            nud.Maximum = DBFieldArray.Length-1;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            DB.updateVehicle(connectionStr,id.ToString(),DBFieldArray[Convert.ToInt32(nud.Value)],txtV.Text,Convert.ToInt32(nud.Value));
            this.Close();
        }
    }
}
