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
            numericStockActual.Text = "";
            numericStockMinimo.Text = "";
            numericPorcentajeGanancia.Text = "";
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
            agregarProducto.agregarProducto(textboxCodigoProducto.Text, textBoxNombreProducto.Text, textBoxNombreCortoProducto.Text, textBoxPrecioCosto.Text, numericStockActual.Text, numericStockMinimo.Text, numericPorcentajeGanancia.Text);
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
            textBoxPrecioCosto.Text = tablaProductos.SelectedCells[4].Value.ToString();
            numericStockActual.Text = tablaProductos.SelectedCells[5].Value.ToString();
            numericStockMinimo.Text = tablaProductos.SelectedCells[6].Value.ToString();
            numericPorcentajeGanancia.Text = tablaProductos.SelectedCells[7].Value.ToString();




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
            else
            {
                ConexionSQL_Negocio editarProducto = new ConexionSQL_Negocio();
                string idProducto = textboxID.Text;
                string codigoProducto = textboxCodigoProducto.Text;
                string nombreProducto = textBoxNombreProducto.Text;
                string nombreCortoProducto = textBoxNombreCortoProducto.Text;
                string precioCosto = textBoxPrecioCosto.Text;
                string stockActual = Convert.ToString(numericStockActual.Value);
                string stockMinimo = Convert.ToString(numericStockMinimo.Value);
                string porcentajeGanancia = Convert.ToString(numericPorcentajeGanancia.Value);

                editarProducto.editarProducto(idProducto, codigoProducto, nombreProducto, nombreCortoProducto, precioCosto, stockActual, stockMinimo, porcentajeGanancia);

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
            else
            {
                ConexionSQL_Negocio eliminarProducto = new ConexionSQL_Negocio();
                eliminarProducto.eliminarProducto(textboxID.Text);
                MessageBox.Show("Producto eliminado correctamente");
                actualizarTabla();
                limpiarCampos();

            }


        }

        private void textboxCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validacion solo se puede ingresar numeros, no se permite letras o caracteres especiales
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros en el codigo de producto");
            }
        }

        private void textBoxPrecioCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validacion solo se permite numeros
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros en el precio de costo");
            }
        }
    }
}
