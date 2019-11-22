using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flexnit
{
    public partial class frmMenuUser : Form
    {
        public frmMenuUser(string username)
        {
            InitializeComponent();
            tssNomeUsuario.Text = username;
        }

        private void frmMenuUser_Load(object sender, EventArgs e)
        {
        }

        private void tssLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSaida_MouseEnter(object sender, EventArgs e)
        {
            lblXis.BackColor = Color.Firebrick;
        }

        private void lblSaida_MouseLeave(object sender, EventArgs e)
        {
            lblXis.BackColor = Color.RosyBrown;
        }

        private void btnDadosCadastrados_Click(object sender, EventArgs e)
        {
            frmMinhaConta formConta = new frmMinhaConta(tssNomeUsuario.Text);
            formConta.ShowDialog();
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            frmCatalogo formCat = new frmCatalogo();
            formCat.ShowDialog();
            this.Activate();
        }
    }
}
