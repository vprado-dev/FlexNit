using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flexnit
{
    public partial class frmCatalogo : Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            // carregaFilmes();
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // carregaGenero();
        }

        private void mtxtDigitAno_Click(object sender, EventArgs e)
        {
            mtxtDigitAno.SelectAll();
        }

        private void mtxtDigitAno_Leave(object sender, EventArgs e)
        {
            // carregaAno();
        }
    }
}
