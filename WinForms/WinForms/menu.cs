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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            Bebidas bebida = new Bebidas();
            bebida.Show();
            this.Hide();
           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            FrmCOMIDA comida = new FrmCOMIDA();
            comida.Show();
            this.Hide();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            POSTRE postre = new POSTRE();
            postre.Show();
            this.Hide();
        }
    }
}
