
namespace ControleGastos.Views
{
    partial class frmCompetencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompetencia));
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.tbCompetencia = new System.Windows.Forms.TextBox();
            this.dgCompetencia = new System.Windows.Forms.DataGridView();
            this.btnAdicionarCompetencia = new System.Windows.Forms.Button();
            this.btnEditarCompetencia = new System.Windows.Forms.Button();
            this.btnExcluirCompetencia = new System.Windows.Forms.Button();
            this.btnFecharTelaCompetencia = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbLocalizarCompetencia = new System.Windows.Forms.TextBox();
            this.lblLocalizarCompetencia = new System.Windows.Forms.Label();
            this.btnBuscarCompetencia = new System.Windows.Forms.Button();
            this.tbIdCompetencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(12, 55);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(75, 13);
            this.lblCompetencia.TabIndex = 0;
            this.lblCompetencia.Text = "Competência: ";
            this.lblCompetencia.Visible = false;
            // 
            // tbCompetencia
            // 
            this.tbCompetencia.Enabled = false;
            this.tbCompetencia.Location = new System.Drawing.Point(104, 51);
            this.tbCompetencia.Name = "tbCompetencia";
            this.tbCompetencia.Size = new System.Drawing.Size(149, 20);
            this.tbCompetencia.TabIndex = 1;
            this.tbCompetencia.Visible = false;
            // 
            // dgCompetencia
            // 
            this.dgCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompetencia.Location = new System.Drawing.Point(15, 90);
            this.dgCompetencia.Name = "dgCompetencia";
            this.dgCompetencia.Size = new System.Drawing.Size(238, 259);
            this.dgCompetencia.TabIndex = 2;
            this.dgCompetencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompetencia_CellClick);
            // 
            // btnAdicionarCompetencia
            // 
            this.btnAdicionarCompetencia.Location = new System.Drawing.Point(259, 91);
            this.btnAdicionarCompetencia.Name = "btnAdicionarCompetencia";
            this.btnAdicionarCompetencia.Size = new System.Drawing.Size(105, 23);
            this.btnAdicionarCompetencia.TabIndex = 3;
            this.btnAdicionarCompetencia.Text = "Adicionar";
            this.btnAdicionarCompetencia.UseVisualStyleBackColor = true;
            this.btnAdicionarCompetencia.Click += new System.EventHandler(this.btnAdicionarCompetencia_Click);
            // 
            // btnEditarCompetencia
            // 
            this.btnEditarCompetencia.Enabled = false;
            this.btnEditarCompetencia.Location = new System.Drawing.Point(259, 141);
            this.btnEditarCompetencia.Name = "btnEditarCompetencia";
            this.btnEditarCompetencia.Size = new System.Drawing.Size(105, 23);
            this.btnEditarCompetencia.TabIndex = 4;
            this.btnEditarCompetencia.Text = "Editar";
            this.btnEditarCompetencia.UseVisualStyleBackColor = true;
            this.btnEditarCompetencia.Click += new System.EventHandler(this.btnEditarCompetencia_Click);
            // 
            // btnExcluirCompetencia
            // 
            this.btnExcluirCompetencia.Enabled = false;
            this.btnExcluirCompetencia.Location = new System.Drawing.Point(259, 191);
            this.btnExcluirCompetencia.Name = "btnExcluirCompetencia";
            this.btnExcluirCompetencia.Size = new System.Drawing.Size(105, 23);
            this.btnExcluirCompetencia.TabIndex = 5;
            this.btnExcluirCompetencia.Text = "Excluir";
            this.btnExcluirCompetencia.UseVisualStyleBackColor = true;
            this.btnExcluirCompetencia.Click += new System.EventHandler(this.btnExcluirCompetencia_Click);
            // 
            // btnFecharTelaCompetencia
            // 
            this.btnFecharTelaCompetencia.Location = new System.Drawing.Point(259, 291);
            this.btnFecharTelaCompetencia.Name = "btnFecharTelaCompetencia";
            this.btnFecharTelaCompetencia.Size = new System.Drawing.Size(105, 23);
            this.btnFecharTelaCompetencia.TabIndex = 6;
            this.btnFecharTelaCompetencia.Text = "Fechar";
            this.btnFecharTelaCompetencia.UseVisualStyleBackColor = true;
            this.btnFecharTelaCompetencia.Click += new System.EventHandler(this.btnFecharTelaCompetencia_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(259, 241);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbLocalizarCompetencia
            // 
            this.tbLocalizarCompetencia.Location = new System.Drawing.Point(104, 12);
            this.tbLocalizarCompetencia.Name = "tbLocalizarCompetencia";
            this.tbLocalizarCompetencia.Size = new System.Drawing.Size(149, 20);
            this.tbLocalizarCompetencia.TabIndex = 9;
            this.tbLocalizarCompetencia.TextChanged += new System.EventHandler(this.tbLocalizarCompetencia_TextChanged);
            // 
            // lblLocalizarCompetencia
            // 
            this.lblLocalizarCompetencia.AutoSize = true;
            this.lblLocalizarCompetencia.Location = new System.Drawing.Point(12, 16);
            this.lblLocalizarCompetencia.Name = "lblLocalizarCompetencia";
            this.lblLocalizarCompetencia.Size = new System.Drawing.Size(52, 13);
            this.lblLocalizarCompetencia.TabIndex = 8;
            this.lblLocalizarCompetencia.Text = "Localizar:";
            // 
            // btnBuscarCompetencia
            // 
            this.btnBuscarCompetencia.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCompetencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCompetencia.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarCompetencia.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCompetencia.Image")));
            this.btnBuscarCompetencia.Location = new System.Drawing.Point(259, 6);
            this.btnBuscarCompetencia.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarCompetencia.Name = "btnBuscarCompetencia";
            this.btnBuscarCompetencia.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarCompetencia.TabIndex = 10;
            this.btnBuscarCompetencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCompetencia.UseVisualStyleBackColor = false;
            // 
            // tbIdCompetencia
            // 
            this.tbIdCompetencia.Enabled = false;
            this.tbIdCompetencia.Location = new System.Drawing.Point(264, 52);
            this.tbIdCompetencia.Name = "tbIdCompetencia";
            this.tbIdCompetencia.Size = new System.Drawing.Size(100, 20);
            this.tbIdCompetencia.TabIndex = 11;
            this.tbIdCompetencia.Visible = false;
            // 
            // frmCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 368);
            this.Controls.Add(this.tbIdCompetencia);
            this.Controls.Add(this.btnBuscarCompetencia);
            this.Controls.Add(this.tbLocalizarCompetencia);
            this.Controls.Add(this.lblLocalizarCompetencia);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFecharTelaCompetencia);
            this.Controls.Add(this.btnExcluirCompetencia);
            this.Controls.Add(this.btnEditarCompetencia);
            this.Controls.Add(this.btnAdicionarCompetencia);
            this.Controls.Add(this.dgCompetencia);
            this.Controls.Add(this.tbCompetencia);
            this.Controls.Add(this.lblCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCompetencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Competências";
            ((System.ComponentModel.ISupportInitialize)(this.dgCompetencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.TextBox tbCompetencia;
        private System.Windows.Forms.DataGridView dgCompetencia;
        private System.Windows.Forms.Button btnAdicionarCompetencia;
        private System.Windows.Forms.Button btnEditarCompetencia;
        private System.Windows.Forms.Button btnExcluirCompetencia;
        private System.Windows.Forms.Button btnFecharTelaCompetencia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbLocalizarCompetencia;
        private System.Windows.Forms.Label lblLocalizarCompetencia;
        private System.Windows.Forms.Button btnBuscarCompetencia;
        private System.Windows.Forms.TextBox tbIdCompetencia;
    }
}