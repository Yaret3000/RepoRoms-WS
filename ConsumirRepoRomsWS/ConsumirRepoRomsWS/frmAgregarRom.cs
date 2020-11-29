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

namespace ConsumirRepoRomsWS
{
    public partial class frmAgregarRom : Form
    {
        RomsWS.RomsWebServiceSoapClient ws = new RomsWS.RomsWebServiceSoapClient();

        public frmAgregarRom()
        {
            InitializeComponent();
        }

        private void frmAgregarRom_Load(object sender, EventArgs e)
        {
            cbConsola.DisplayMember = "nombre";
            cbConsola.ValueMember = "id";
            cbConsola.DataSource = ws.ListarConsola();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCover.Text = openFileDialog1.FileName;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Equals("") || txtSinopsis.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nombre y sinopsis son campos obligatorios");
                return;
            }

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }
            
                ws.AgregarRom(txtNombre.Text, txtSinopsis.Text, file, dtpFecha.Value, txtVideo.Text, (int)cbConsola.SelectedValue);

            Form1 frmMain = new Form1();
            frmMain.Refrescar();
            this.Close();
        }
    }
}
