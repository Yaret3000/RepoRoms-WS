using ConsumirRepoRomsWS.Util;
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
    public partial class Form1 : Form
    {
        RomsWS.RomsWebServiceSoapClient ws = new RomsWS.RomsWebServiceSoapClient();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAgregar = new frmAgregarRom();

            frmAgregar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            //dgvRoms.Rows.Clear();
            var lstConsolas = ws.ListarRoms();
            var lstDgv = lstConsolas.Select(x => new dgvRom
            {
                ID = x.id,
                Nombre = x.nombre
            });
            dgvRoms.DataSource = lstDgv.ToList();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(dgvRoms.Rows.Count > 0)
            {
                int id = int.Parse(dgvRoms.Rows[dgvRoms.CurrentRow.Index].Cells[0].Value.ToString());
                var rom = ws.DetalleRom(id);

                lblFecha.Text = "Lanzamiento: " + rom.fecha.ToShortDateString();
                lblTitulo.Text = "Titulo: " + rom.nombre;
                webBrowser1.Navigate(rom.video);
                txtSinopsis.Text = rom.sinopsis;

                MemoryStream ms = new MemoryStream(rom.cover);
                Bitmap bit = new Bitmap(ms);
                pbCover.Image = bit;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRoms.Rows.Count > 0)
            {
                int id = int.Parse(dgvRoms.Rows[dgvRoms.CurrentRow.Index].Cells[0].Value.ToString());
                var rom = ws.EliminarRom(id);

                Refrescar();
            }
        }
    }
}
