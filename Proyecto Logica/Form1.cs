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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IniciarTestBtn_Click(object sender, EventArgs e)
        {
            PostLogin nuevaVentana = new PostLogin();
            this.Hide();
            nuevaVentana.Show();
        }
    }
}
