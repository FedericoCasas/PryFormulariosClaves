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
    public partial class FrmSegundo : Form
    {
        public FrmSegundo()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 VariableVolver = new Form1();
            VariableVolver.Show();
        }
    }
}
