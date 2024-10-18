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

        public void actualizarTabla()
        {
            ConexionSQL_Negocio verProductos = new ConexionSQL_Negocio();
            DataTable prductos = verProductos.verDetalleCompletoProductos();
            tablaProductos.DataSource = prductos;
        }

        private void ConsultaMovimiento_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            // Funcion para agregar producto
            ConexionSQL_Negocio agregarProducto = new ConexionSQL_Negocio();
            agregarProducto.agregarProducto(textboxCodigoProducto.Text, textBoxNombreProducto.Text, textBoxNombreCortoProducto.Text, textBoxPrecioCosto.Text, textboxStockActual.Text, textBoxStockMinimo.Text, textBoxPorcentajeGanancia.Text);
            MessageBox.Show("Producto agregado correctamente");
            actualizarTabla();
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Rellenar los campos con los datos de la fila seleccionada
            textboxID.Text = tablaProductos.SelectedCells[0].Value.ToString();
            textboxCodigoProducto.Text = tablaProductos.SelectedCells[1].Value.ToString();
            textBoxNombreProducto.Text = tablaProductos.SelectedCells[2].Value.ToString();
            textBoxNombreCortoProducto.Text = tablaProductos.SelectedCells[3].Value.ToString();
            textBoxPrecioCosto.Text = tablaProductos.SelectedCells[4].Value.ToString();
            textboxStockActual.Text = tablaProductos.SelectedCells[5].Value.ToString();
            textBoxStockMinimo.Text = tablaProductos.SelectedCells[6].Value.ToString();
            textBoxPorcentajeGanancia.Text = tablaProductos.SelectedCells[7].Value.ToString();



        }

        private void botonLimpiarCampos_Click(object sender, EventArgs e)
        {
            // Limpiar los campos
            textboxID.Text = "";
            textboxCodigoProducto.Text = "";
            textBoxNombreProducto.Text = "";
            textBoxNombreCortoProducto.Text = "";
            textBoxPrecioCosto.Text = "";
            textboxStockActual.Text = "";
            textBoxStockMinimo.Text = "";
            textBoxPorcentajeGanancia.Text = "";
        }
    }
}
