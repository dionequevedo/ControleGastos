using ControleGastos.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirCadCompetencia_Click(object sender, EventArgs e)
        {
            frmCompetencia cpt = new frmCompetencia();
            cpt.ShowDialog();
        }

        private void competênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompetencia cpt = new frmCompetencia();
            cpt.ShowDialog();
        }

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadLancamentos cadlanc = new frmCadLancamentos();
            cadlanc.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaArquivos_Click(object sender, EventArgs e)
        {
            string caminho = "C:\\";
            var query = from arquivo in Directory.GetFiles($"{caminho}")
                        select new      // Tipo Anônimo
                        {
                            Arquivo = Path.GetFileName(arquivo),
                            Tipo = Path.GetExtension(arquivo)
                        };
            dgEntradas.DataSource = query.ToList();            
        }
    }
}
