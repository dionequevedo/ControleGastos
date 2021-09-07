
namespace ControleGastos.Views
{
    partial class frmCadLancamentos
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
            this.btnFecharTelaCompetencia = new System.Windows.Forms.Button();
            this.btnExcluirCompetencia = new System.Windows.Forms.Button();
            this.btnEditarCompetencia = new System.Windows.Forms.Button();
            this.btnAdicionarCompetencia = new System.Windows.Forms.Button();
            this.dgCompetencia = new System.Windows.Forms.DataGridView();
            this.tbCompetencia = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.cbCompetencia = new System.Windows.Forms.ComboBox();
            this.btnAbrirCadCompetencia = new System.Windows.Forms.Button();
            this.lblDatalancamento = new System.Windows.Forms.Label();
            this.dtDatalancamento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFecharTelaCompetencia
            // 
            this.btnFecharTelaCompetencia.Location = new System.Drawing.Point(432, 316);
            this.btnFecharTelaCompetencia.Name = "btnFecharTelaCompetencia";
            this.btnFecharTelaCompetencia.Size = new System.Drawing.Size(105, 23);
            this.btnFecharTelaCompetencia.TabIndex = 13;
            this.btnFecharTelaCompetencia.Text = "Fechar";
            this.btnFecharTelaCompetencia.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCompetencia
            // 
            this.btnExcluirCompetencia.Location = new System.Drawing.Point(295, 316);
            this.btnExcluirCompetencia.Name = "btnExcluirCompetencia";
            this.btnExcluirCompetencia.Size = new System.Drawing.Size(105, 23);
            this.btnExcluirCompetencia.TabIndex = 12;
            this.btnExcluirCompetencia.Text = "Excluir";
            this.btnExcluirCompetencia.UseVisualStyleBackColor = true;
            // 
            // btnEditarCompetencia
            // 
            this.btnEditarCompetencia.Location = new System.Drawing.Point(158, 316);
            this.btnEditarCompetencia.Name = "btnEditarCompetencia";
            this.btnEditarCompetencia.Size = new System.Drawing.Size(105, 23);
            this.btnEditarCompetencia.TabIndex = 11;
            this.btnEditarCompetencia.Text = "Editar";
            this.btnEditarCompetencia.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCompetencia
            // 
            this.btnAdicionarCompetencia.Location = new System.Drawing.Point(21, 316);
            this.btnAdicionarCompetencia.Name = "btnAdicionarCompetencia";
            this.btnAdicionarCompetencia.Size = new System.Drawing.Size(105, 23);
            this.btnAdicionarCompetencia.TabIndex = 10;
            this.btnAdicionarCompetencia.Text = "Adicionar";
            this.btnAdicionarCompetencia.UseVisualStyleBackColor = true;
            // 
            // dgCompetencia
            // 
            this.dgCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompetencia.Location = new System.Drawing.Point(21, 77);
            this.dgCompetencia.Name = "dgCompetencia";
            this.dgCompetencia.Size = new System.Drawing.Size(651, 224);
            this.dgCompetencia.TabIndex = 9;
            // 
            // tbCompetencia
            // 
            this.tbCompetencia.Enabled = false;
            this.tbCompetencia.Location = new System.Drawing.Point(82, 41);
            this.tbCompetencia.Name = "tbCompetencia";
            this.tbCompetencia.Size = new System.Drawing.Size(373, 20);
            this.tbCompetencia.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(18, 44);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(474, 43);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Valor: ";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(517, 40);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(155, 20);
            this.tbValor.TabIndex = 15;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(18, 13);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbTipo.Location = new System.Drawing.Point(61, 10);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 17;
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(339, 13);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(72, 13);
            this.lblCompetencia.TabIndex = 18;
            this.lblCompetencia.Text = "Competência:";
            // 
            // cbCompetencia
            // 
            this.cbCompetencia.FormattingEnabled = true;
            this.cbCompetencia.Items.AddRange(new object[] {
            "01/2020",
            "02/2020",
            "03/2020",
            "04/2020",
            "05/2020",
            "06/2020",
            "07/2020",
            "08/2020",
            "09/2020",
            "10/2020",
            "11/2020",
            "12/2020",
            "01/2021",
            "02/2021",
            "03/2021",
            "04/2021",
            "05/2021",
            "06/2021",
            "07/2021",
            "08/2021",
            "09/2021",
            "10/2021",
            "11/2021",
            "12/2021",
            "01/2022",
            "02/2022",
            "03/2022",
            "04/2022",
            "05/2022",
            "06/2022",
            "07/2022",
            "08/2022",
            "09/2022",
            "10/2022",
            "11/2022",
            "12/2022"});
            this.cbCompetencia.Location = new System.Drawing.Point(423, 10);
            this.cbCompetencia.Name = "cbCompetencia";
            this.cbCompetencia.Size = new System.Drawing.Size(121, 21);
            this.cbCompetencia.TabIndex = 19;
            // 
            // btnAbrirCadCompetencia
            // 
            this.btnAbrirCadCompetencia.Location = new System.Drawing.Point(556, 8);
            this.btnAbrirCadCompetencia.Name = "btnAbrirCadCompetencia";
            this.btnAbrirCadCompetencia.Size = new System.Drawing.Size(116, 23);
            this.btnAbrirCadCompetencia.TabIndex = 20;
            this.btnAbrirCadCompetencia.Text = "Cad Competência";
            this.btnAbrirCadCompetencia.UseVisualStyleBackColor = true;
            this.btnAbrirCadCompetencia.Click += new System.EventHandler(this.btnAbrirCadCompetencia_Click);
            // 
            // lblDatalancamento
            // 
            this.lblDatalancamento.AutoSize = true;
            this.lblDatalancamento.Location = new System.Drawing.Point(194, 13);
            this.lblDatalancamento.Name = "lblDatalancamento";
            this.lblDatalancamento.Size = new System.Drawing.Size(33, 13);
            this.lblDatalancamento.TabIndex = 21;
            this.lblDatalancamento.Text = "Data:";
            // 
            // dtDatalancamento
            // 
            this.dtDatalancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatalancamento.Location = new System.Drawing.Point(239, 10);
            this.dtDatalancamento.Name = "dtDatalancamento";
            this.dtDatalancamento.Size = new System.Drawing.Size(88, 20);
            this.dtDatalancamento.TabIndex = 22;
            // 
            // frmCadLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.dtDatalancamento);
            this.Controls.Add(this.lblDatalancamento);
            this.Controls.Add(this.btnAbrirCadCompetencia);
            this.Controls.Add(this.cbCompetencia);
            this.Controls.Add(this.lblCompetencia);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnFecharTelaCompetencia);
            this.Controls.Add(this.btnExcluirCompetencia);
            this.Controls.Add(this.btnEditarCompetencia);
            this.Controls.Add(this.btnAdicionarCompetencia);
            this.Controls.Add(this.dgCompetencia);
            this.Controls.Add(this.tbCompetencia);
            this.Controls.Add(this.lblDescricao);
            this.Name = "frmCadLancamentos";
            this.Text = "Lançamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgCompetencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecharTelaCompetencia;
        private System.Windows.Forms.Button btnExcluirCompetencia;
        private System.Windows.Forms.Button btnEditarCompetencia;
        private System.Windows.Forms.Button btnAdicionarCompetencia;
        private System.Windows.Forms.DataGridView dgCompetencia;
        private System.Windows.Forms.TextBox tbCompetencia;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.ComboBox cbCompetencia;
        private System.Windows.Forms.Button btnAbrirCadCompetencia;
        private System.Windows.Forms.Label lblDatalancamento;
        private System.Windows.Forms.DateTimePicker dtDatalancamento;
    }
}