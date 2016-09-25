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

        private void btnregresar_Click(object sender, EventArgs e)
        {
            menu a = new menu();
            a.Show();

            this.Close();
        }


    }
}
