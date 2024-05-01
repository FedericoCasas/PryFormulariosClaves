using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFormulariosClaves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            int Clave;
            string Usuario;
            int ClaveForm;
            string UsuarioForm;

            Clave = 1111;
            Usuario = "Pepe";
            ClaveForm = Convert.ToInt32(TxtClave.Text);
            UsuarioForm = Convert.ToString(TxtUsuario.Text);

            if (Clave == ClaveForm && Usuario == UsuarioForm)
            {
                this.Hide();
                FrmSegundo variableVuelta = new FrmSegundo();
                variableVuelta.Show();
            }
            else
            {
                MessageBox.Show("Ingreso mal la clave o el usuario!!!!!!!!");
            }


        }
    }
}
