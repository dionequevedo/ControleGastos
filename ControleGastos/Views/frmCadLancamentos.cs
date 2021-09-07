using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGastos.Views
{
    public partial class frmCadLancamentos : Form
    {
        public frmCadLancamentos()
        {
            InitializeComponent();
        }

        private void btnAbrirCadCompetencia_Click(object sender, EventArgs e)
        {
            frmCompetencia cpt = new frmCompetencia();
            cpt.ShowDialog();
        }
    }
}
