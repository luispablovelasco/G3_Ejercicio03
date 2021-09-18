using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3_Ejercicio3
{
    public partial class Form1 : Form
    {
        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1;

        private void actuaGrid()
        {
            dgvlistado.DataSource = null;
            dgvlistado.DataSource = Productos;
        }

        private void reseteo()
        {
            txtnombre.Clear();
            txtdescrip.Clear();
            txtmarca.Clear();
            txtprecio.Clear();
            txtstock.Clear();
        }
        private void limpiar()
        {
            txtdescrip.Clear();
            txtmarca.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            txtstock.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvlistado.SelectedRows[0];
            int posicion = dgvlistado.Rows.IndexOf(selected);
            edit_indice = posicion;

            Producto product = Productos[posicion];

            txtnombre.Text = product.Nombre;
            txtdescrip.Text = product.Descripcion;
            txtmarca.Text = product.Marca;
            txtprecio.Text = Convert.ToString(product.Precio);
            txtstock.Text = Convert.ToString(product.Stock);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Producto product = new Producto();
            product.Nombre = txtnombre.Text;
            product.Descripcion = txtdescrip.Text;
            product.Marca = txtmarca.Text;
            product.Precio = float.Parse(txtprecio.Text);
            product.Stock = Convert.ToInt16(txtstock.Text);
            product.Imaproducto = Convert.ToString(Image.FromFile(ofdimagen.FileName));

            if (edit_indice > -1)
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {
                Productos.Add(product);
            }
            actuaGrid();
            reseteo();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1;
                limpiar();
                actuaGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre el elemento para seleccionar y borrar");
            }
        }

        public void btngargarimagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdimagen.ShowDialog() == DialogResult.OK)
                {
                    string imagen = ofdimagen.FileName;
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
                throw;
            }
        }
    }
}
