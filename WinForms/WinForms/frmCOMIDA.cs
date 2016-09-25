using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FrmCOMIDA : Form
    {
        comida C = new comida();
        public FrmCOMIDA()
        {
            InitializeComponent();
        }

        private void FrmCOMIDA_Load(object sender, EventArgs e)
        {
            C.conectar();
            mostrarDatos();
        }
        public void mostrarDatos()
        {
            C.consulta("select*from COMIDA", "COMIDA");
            dataGrid.DataSource = C.ds.Tables["COMIDA"];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string actualizar = "ID=" + txtID.Text + ",NOMBRE='" + txtNombre.Text + "',PRECIO=" + txtPrecio.Text + ",EXISTENCIA='" + txtExistencia.Text + "'";
            if (C.modificar("COMIDA", actualizar, "ID=" + txtID.Text))
            {
                MessageBox.Show("Datos Actualizados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al Actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (C.eliminar("COMIDA", "ID=" + txtID.Text))
            {
                MessageBox.Show("Se elimino");
                txtID.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtExistencia.Text = "";

                mostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow grid = dataGrid.Rows[e.RowIndex];

            txtID.Text = grid.Cells[0].Value.ToString();
            txtNombre.Text = grid.Cells[1].Value.ToString();
            txtPrecio.Text = grid.Cells[2].Value.ToString();
            txtExistencia.Text = grid.Cells[3].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into COMIDA values(" + txtID.Text + ",'" + txtNombre.Text + "'," + txtPrecio.Text + ",'" + txtExistencia.Text + "')";
            if (C.agregar(agregar))
            {
                MessageBox.Show("Datos agregados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu a = new menu();
            a.Show();

            this.Close();
        }
    }
}