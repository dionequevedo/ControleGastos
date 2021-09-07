
namespace ControleGastos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLancamentosDia = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblSaidas = new System.Windows.Forms.Label();
            this.dgEntradas = new System.Windows.Forms.DataGridView();
            this.dgSaidas = new System.Windows.Forms.DataGridView();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblTotalizador = new System.Windows.Forms.Label();
            this.btnConsultaArquivos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.competênciasToolStripMenuItem,
            this.lançamentosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatóriosToolStripMenuItem.Image")));
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // competênciasToolStripMenuItem
            // 
            this.competênciasToolStripMenuItem.Name = "competênciasToolStripMenuItem";
            this.competênciasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.competênciasToolStripMenuItem.Text = "Competências";
            this.competênciasToolStripMenuItem.Click += new System.EventHandler(this.competênciasToolStripMenuItem_Click);
            // 
            // lançamentosToolStripMenuItem
            // 
            this.lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            this.lançamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lançamentosToolStripMenuItem.Text = "Lançamentos";
            this.lançamentosToolStripMenuItem.Click += new System.EventHandler(this.lançamentosToolStripMenuItem_Click);
            // 
            // lblLancamentosDia
            // 
            this.lblLancamentosDia.AutoSize = true;
            this.lblLancamentosDia.Location = new System.Drawing.Point(12, 47);
            this.lblLancamentosDia.Name = "lblLancamentosDia";
            this.lblLancamentosDia.Size = new System.Drawing.Size(106, 13);
            this.lblLancamentosDia.TabIndex = 23;
            this.lblLancamentosDia.Text = "Lançamentos do dia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(12, 111);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(52, 13);
            this.lblEntradas.TabIndex = 25;
            this.lblEntradas.Text = "Entradas:";
            // 
            // lblSaidas
            // 
            this.lblSaidas.AutoSize = true;
            this.lblSaidas.Location = new System.Drawing.Point(365, 111);
            this.lblSaidas.Name = "lblSaidas";
            this.lblSaidas.Size = new System.Drawing.Size(44, 13);
            this.lblSaidas.TabIndex = 26;
            this.lblSaidas.Text = "Saídas:";
            // 
            // dgEntradas
            // 
            this.dgEntradas.AllowUserToOrderColumns = true;
            this.dgEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradas.Location = new System.Drawing.Point(15, 127);
            this.dgEntradas.Name = "dgEntradas";
            this.dgEntradas.Size = new System.Drawing.Size(319, 274);
            this.dgEntradas.TabIndex = 27;
            // 
            // dgSaidas
            // 
            this.dgSaidas.AllowUserToOrderColumns = true;
            this.dgSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaidas.Location = new System.Drawing.Point(368, 127);
            this.dgSaidas.Name = "dgSaidas";
            this.dgSaidas.Size = new System.Drawing.Size(343, 274);
            this.dgSaidas.TabIndex = 28;
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Location = new System.Drawing.Point(544, 418);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(70, 13);
            this.lblSaldoTotal.TabIndex = 29;
            this.lblSaldoTotal.Text = "Saldo Total:  ";
            // 
            // lblTotalizador
            // 
            this.lblTotalizador.AutoSize = true;
            this.lblTotalizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalizador.Location = new System.Drawing.Point(625, 418);
            this.lblTotalizador.Name = "lblTotalizador";
            this.lblTotalizador.Size = new System.Drawing.Size(52, 13);
            this.lblTotalizador.TabIndex = 30;
            this.lblTotalizador.Text = "R$ 0,00";
            // 
            // btnConsultaArquivos
            // 
            this.btnConsultaArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaArquivos.Location = new System.Drawing.Point(15, 413);
            this.btnConsultaArquivos.Name = "btnConsultaArquivos";
            this.btnConsultaArquivos.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaArquivos.TabIndex = 31;
            this.btnConsultaArquivos.Text = "Consulta";
            this.btnConsultaArquivos.UseVisualStyleBackColor = true;
            this.btnConsultaArquivos.Click += new System.EventHandler(this.btnConsultaArquivos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.btnConsultaArquivos);
            this.Controls.Add(this.lblTotalizador);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.dgSaidas);
            this.Controls.Add(this.dgEntradas);
            this.Controls.Add(this.lblSaidas);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblLancamentosDia);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Gastos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançamentosToolStripMenuItem;
        private System.Windows.Forms.Label lblLancamentosDia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblSaidas;
        private System.Windows.Forms.DataGridView dgEntradas;
        private System.Windows.Forms.DataGridView dgSaidas;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblTotalizador;
        private System.Windows.Forms.Button btnConsultaArquivos;
    }
}

