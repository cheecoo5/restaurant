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
    public partial class Bebidas : Form
    {
        bebidas1 B = new bebidas1();
        public Bebidas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string agregar = "insert into BEBIDAS values(" + txtid.Text + ",'" + txtnombre.Text + "'," + txtprecio.Text + ",'" + txtexistencia.Text + "')";
            if (B.agregar(agregar))
            {
                MessageBox.Show("Datos agregados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }
        }

        private void Bebidas_Load(object sender, EventArgs e)
        {
            B.conectar();
            mostrarDatos();

        }
        public void mostrarDatos()
        {
            B.consulta("select*from BEBIDAS", "BEBIDAS");
            dataGridView1.DataSource = B.ds.Tables["BEBIDAS"];
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string actualizar = "ID=" + txtid.Text + ",NOMBRE='" + txtnombre.Text + "',PRECIO=" + txtprecio.Text + ",EXISTENCIA='" + txtexistencia.Text + "'";
            if (B.modificar("BEBIDAS", actualizar, "ID=" + txtid.Text))
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
            if (B.eliminar("BEBIDAS", "ID=" + txtid.Text))
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            menu a = new menu();
            a.Show();

            this.Close();
        }
    }
}
