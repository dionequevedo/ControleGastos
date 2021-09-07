using ControleGastos.Entidades;
using ControleGastos.Models;
using ControleGastos.Controllers;
using System;
using Npgsql;
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
    public partial class frmCompetencia : Form
    {
        // Instanciando a classe Competência para não precisar instanciar o obj em todas as subclasses
        Competencias obj = new Competencias();

        // Criação de controles para o botão Salvar
        bool adicionar;
        bool editar;
        bool excluir;

        public frmCompetencia()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            /// TODO Remover try 
            try
            {
                List<Competencias> lista = new List<Competencias>();
                lista = new CompetenciasModels().Listar();

                var query = from itens in lista
                            select new
                            {
                                ID = itens.Get_Id_Competencia(),
                                Competencia = itens.Get_Descr_Competencia()
                            };
                dgCompetencia.DataSource = query.ToList();
                dgCompetencia.Columns[0].Visible = true;
                dgCompetencia.Columns[1].Visible = true;
                dgCompetencia.Columns[0].Width = 40;
                dgCompetencia.Columns[1].Width = 130;

            }
            catch (Exception _err)
            {

                MessageBox.Show("ERRO!\n\t" + _err.Message);
            }   
        }

        private void btnAdicionarCompetencia_Click(object sender, EventArgs e)
        {
            adicionar = true;
            tbCompetencia.Visible = true;
            lblCompetencia.Visible = true;
            btnSalvar.Enabled = true;
            tbCompetencia.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (adicionar == true)
            {
                    if (tbCompetencia.Text == "")
                    {
                        MessageBox.Show("Insira uma competência!");
                        btnSalvar.Enabled = false;
                    }
                    else
                    {
                        btnSalvar.Enabled = false;
                        tbCompetencia.Enabled = false;
                        Salvar();
                        tbCompetencia.Text = "";
                        tbCompetencia.Visible = false;
                        lblCompetencia.Visible = false;
                    }
                    adicionar = false;              
            }
            else if (editar == true)
            {
                if (tbCompetencia.Text == "")
                {
                    MessageBox.Show("Selecione um registro para edição!");
                    btnSalvar.Enabled = false;
                }
                else
                {
                    btnSalvar.Enabled = false;
                    tbCompetencia.Enabled = false;
                    Editar();
                    tbCompetencia.Text = "";
                    tbCompetencia.Visible = false;
                    lblCompetencia.Visible = false;
                }
                editar = false;
            } else if (excluir == true)
            {
                if (tbCompetencia.Text == "")
                {
                    MessageBox.Show("Selecione um registro para exclusão!");
                    btnSalvar.Enabled = false;
                }
                else
                {
                    btnSalvar.Enabled = false;
                    tbCompetencia.Enabled = false;
                    Deletar();
                    tbCompetencia.Text = "";
                    tbCompetencia.Visible = false;
                    lblCompetencia.Visible = false;
                }
                excluir = false;
            }
        }

        private void Deletar()
        {
            try
            {
                obj.Set_Descr_Competencia(tbCompetencia.Text);
                obj.Set_Id_Competencia(Convert.ToInt32(tbIdCompetencia.Text));
                int x = CompetenciasModels.Deletar(obj);
                if (x == 1)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                }
            }
            catch (Exception _err)
            {
                MessageBox.Show($"Erro ao gravar! \n{_err}");
            }
        }

        private void Editar()
        {
            try
            {
                obj.Set_Descr_Competencia(tbCompetencia.Text);
                obj.Set_Id_Competencia(Convert.ToInt32(tbIdCompetencia.Text));
                int x = CompetenciasModels.Editar(obj);
                if (x == 1)
                {
                    MessageBox.Show("Competência salva com sucesso!");
                }
            }
            catch (Exception _err)
            {
                MessageBox.Show($"Erro ao gravar! \n{_err}");
            }
        }

        private void Salvar()
        {
            try
            {
                obj.Set_Descr_Competencia(tbCompetencia.Text);
                int x = CompetenciasModels.Inserir(obj);
                if (x == 1)
                {
                    MessageBox.Show("Competência salva com sucesso!");
                }
            }
            catch (Exception _err)
            {
                MessageBox.Show($"Erro ao gravar! \n{_err}");
            }
        }

        private void btnFecharTelaCompetencia_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbLocalizarCompetencia_TextChanged(object sender, EventArgs e)
        {
            if(tbLocalizarCompetencia.Text == "")
            {
                Listar();
            }
            else 
            {
                obj.Set_Descr_Competencia(tbLocalizarCompetencia.Text);
                List<Competencias> lista = new List<Competencias>();
                Competencia_Controller cc = new Competencia_Controller();
                lista = cc.Buscar(obj);

                var query = from item in lista
                            select new
                            {
                                ID = item.Get_Id_Competencia(),
                                Competencia = item.Get_Descr_Competencia()
                            };

                
                dgCompetencia.DataSource = query.ToList();
                dgCompetencia.Columns[0].Visible = true;
                dgCompetencia.Columns[1].Visible = true;
                dgCompetencia.Columns[0].Width = 40;
                dgCompetencia.Columns[1].Width = 130;
            }
        }


        private void dgCompetencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarCompetencia.Enabled = true;
            btnExcluirCompetencia.Enabled = true;
            tbCompetencia.Enabled = true;
            tbCompetencia.Visible = true;
            btnSalvar.Enabled = false;
            lblCompetencia.Visible = true;
            tbCompetencia.Focus();
            tbIdCompetencia.Text = dgCompetencia.CurrentRow.Cells[0].Value.ToString();
            tbCompetencia.Text = dgCompetencia.CurrentCell.Value.ToString();
        }

        private void btnEditarCompetencia_Click(object sender, EventArgs e)
        {
            editar = true;
            btnEditarCompetencia.Enabled = false;
            btnExcluirCompetencia.Enabled = false;
            tbCompetencia.Visible = true;
            lblCompetencia.Visible = false;
            lblCompetencia.Text = "";
            btnSalvar.Enabled = false;
            tbCompetencia.Enabled = false;
            Editar();
        }

        private void btnExcluirCompetencia_Click(object sender, EventArgs e)
        {
            excluir = true;
            btnEditarCompetencia.Enabled = false;
            btnExcluirCompetencia.Enabled = false;
            tbCompetencia.Visible = true;
            lblCompetencia.Visible = false;
            lblCompetencia.Text = "";
            btnSalvar.Enabled = false;
            tbCompetencia.Enabled = false;
            Deletar();
        }
    }
}
