using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace PresentacionConsultaMovimientos
{
    public partial class ConsultaMovimiento : Form
    {
        public ConsultaMovimiento()
        {
            InitializeComponent();
        }

        private void ConsultaMovimiento_Load(object sender, EventArgs e)
        {
            ConexionSQL_Negocio verProductos = new ConexionSQL_Negocio();
            DataTable prductos = verProductos.verDetalleCompletoProductos();
            tablaProductos.DataSource = prductos;
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
