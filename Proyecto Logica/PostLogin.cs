using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Logica
{
    public partial class PostLogin : Form
    {
        public PostLogin()
        {
            InitializeComponent();
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();

        }

        private void SalirTestBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si sale del programa, se perderán todos los cambios. \n¿Desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
