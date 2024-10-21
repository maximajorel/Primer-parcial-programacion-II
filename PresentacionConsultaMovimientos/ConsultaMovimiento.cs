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
        public void limpiarCampos()
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
            limpiarCampos();
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Rellenar los campos con los datos de la fila seleccionada            
            textboxID.Text = tablaProductos.SelectedCells[0].Value.ToString();
            textboxCodigoProducto.Text = tablaProductos.SelectedCells[1].Value.ToString();
            textBoxNombreProducto.Text = tablaProductos.SelectedCells[2].Value.ToString();
            textBoxNombreCortoProducto.Text = tablaProductos.SelectedCells[3].Value.ToString();
            textBoxPrecioCosto.Text = tablaProductos.SelectedCells[4].Value.ToString().Replace(",", ".");
            textboxStockActual.Text = tablaProductos.SelectedCells[5].Value.ToString().Replace(",", ".");
            textBoxStockMinimo.Text = tablaProductos.SelectedCells[6].Value.ToString().Replace(",", ".");
            textBoxPorcentajeGanancia.Text = tablaProductos.SelectedCells[7].Value.ToString();



        }

        private void botonLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }


        // Editar producto
        private void button1_Click(object sender, EventArgs e)
        {

            if (textboxID.Text == "")
            {
                MessageBox.Show("Seleccione un producto para editar");
            }
            else {
                ConexionSQL_Negocio editarProducto = new ConexionSQL_Negocio();
                editarProducto.editarProducto(textboxID.Text, textboxCodigoProducto.Text, textBoxNombreProducto.Text, textBoxNombreCortoProducto.Text, textBoxPrecioCosto.Text, textboxStockActual.Text, textBoxStockMinimo.Text, textBoxPorcentajeGanancia.Text);
                MessageBox.Show("Producto editado correctamente");
                actualizarTabla();
                limpiarCampos();
            }



        }

        private void botonEliminarProducto_Click(object sender, EventArgs e)
        {

            if (textboxID.Text == "")
            {
                MessageBox.Show("Seleccione un producto para editar");
            }
            else {
                ConexionSQL_Negocio eliminarProducto = new ConexionSQL_Negocio();
                eliminarProducto.eliminarProducto(textboxID.Text);
                MessageBox.Show("Producto eliminado correctamente");
                actualizarTabla();
                limpiarCampos();

            }


        }
    }
}
