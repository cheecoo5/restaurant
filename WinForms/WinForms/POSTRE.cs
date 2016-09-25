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
    public partial class POSTRE : Form
    {
        postres P = new postres();
        public POSTRE()
        {
            InitializeComponent();
        }

        private void POSTRE_Load(object sender, EventArgs e)
        {
            P.conectar();
            mostrarDatos();


        }

        private void bu_Click(object sender, EventArgs e)
        {
            string agregar = "insert into POSTRE values(" + txtid.Text + ",'" + txtnombre.Text + "'," + txtprecio.Text + ",'" + txtexistencia.Text + "')";
            if (P.agregar(agregar))
            {
                MessageBox.Show("Datos agregados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }
        }
        public void mostrarDatos()
        {
            P.consulta("select*from POSTRE", "POSTRE");
            dataGridView1.DataSource = P.ds.Tables["POSTRE"];
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string actualizar = "ID=" + txtid.Text + ",NOMBRE='" + txtnombre.Text + "',PRECIO=" + txtprecio.Text + ",EXISTENCIA='" + txtexistencia + "'";
            if (P.modificar("POSTRE", actualizar, "ID=" + txtid.Text))
            {
                MessageBox.Show("Datos Actualizados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al Actualizar");
            }
        }

        private void btnbajas_Click(object sender, EventArgs e)
        {

            if (P.eliminar("POSTRE", "ID=" + txtid.Text))
            {
                MessageBox.Show("Se elimino");
                txtid.Text = "";
                txtnombre.Text = "";
                txtprecio.Text = "";
                txtexistencia.Text = "";

                mostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow grid = dataGridView1.Rows[e.RowIndex];

            txtid.Text = grid.Cells[0].Value.ToString();
            txtnombre.Text = grid.Cells[1].Value.ToString();
            txtprecio.Text = grid.Cells[2].Value.ToString();
            txtexistencia.Text = grid.Cells[3].Value.ToString();

        }
    }
}
