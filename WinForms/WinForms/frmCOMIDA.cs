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
    public partial class frmCOMIDA : Form
    {
        comida C = new comida();
        public frmCOMIDA()
        {
            InitializeComponent();
        }

        private void COMIDA_Load(object sender, EventArgs e)
        {
            C.conectar();
            mostrarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow grid = dataGrid.Rows[e.RowIndex];
            textID.Text = grid.Cells[0].Value.ToString();
            textNombre.Text = grid.Cells[1].Value.ToString();
            textPrecio.Text = grid.Cells[2].Value.ToString();
            textExistencia.Text = grid.Cells[3].Value.ToString();

        }
        public void mostrarDatos()
        {
            C.consulta("select*from COMIDA", "COMIDA");
            dataGrid.DataSource = C.ds.Tables["COMIDA"];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into COMIDA values(" + textID.Text + ",'" + textNombre.Text + "'," + textPrecio.Text + ",'" + textExistencia + "')";
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string actualizar = "ID=" + textID.Text + ",NOMBRE='" + textNombre.Text + ",PRECIO=" + textPrecio.Text + "',EXISTENCIA=" + textExistencia.Text + "";
            if (C.modificar("COMIDA", actualizar, "ID=" + textID.Text))
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

            if (C.eliminar("COMIDA", "ID=" + textID.Text))
            {
                MessageBox.Show("Se elimino");
                textID.Text = "";
                textNombre.Text = "";
                textPrecio.Text = "";
                textExistencia.Text = "";
                
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }
    }
}