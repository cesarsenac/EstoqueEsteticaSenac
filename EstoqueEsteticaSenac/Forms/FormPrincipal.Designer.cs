namespace EstoqueEsteticaSenac.Forms
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posiçãoDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaBaixaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vencidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximosADataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vencidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCadastradosNoMesCorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCadastradosNoMêsAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoDoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDoMesAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vencidosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vencidosNesteMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vencidosNoMesAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.trocarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.marcasToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.produtosToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.produtosToolStripMenuItem1.Text = "Produto";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.marcasToolStripMenuItem.Text = "Marca";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.usuáriosToolStripMenuItem.Text = "Usuário";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posiçãoDeEstoqueToolStripMenuItem,
            this.entradaDeProdutosToolStripMenuItem,
            this.saidaBaixaDeProdutosToolStripMenuItem,
            this.vencidosToolStripMenuItem});
            this.estoqueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // posiçãoDeEstoqueToolStripMenuItem
            // 
            this.posiçãoDeEstoqueToolStripMenuItem.Name = "posiçãoDeEstoqueToolStripMenuItem";
            this.posiçãoDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.posiçãoDeEstoqueToolStripMenuItem.Text = "Posição de Estoque";
            // 
            // entradaDeProdutosToolStripMenuItem
            // 
            this.entradaDeProdutosToolStripMenuItem.Name = "entradaDeProdutosToolStripMenuItem";
            this.entradaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.entradaDeProdutosToolStripMenuItem.Text = "Entrada de Produtos";
            this.entradaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProdutosToolStripMenuItem_Click);
            // 
            // saidaBaixaDeProdutosToolStripMenuItem
            // 
            this.saidaBaixaDeProdutosToolStripMenuItem.Name = "saidaBaixaDeProdutosToolStripMenuItem";
            this.saidaBaixaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.saidaBaixaDeProdutosToolStripMenuItem.Text = "Saida/Baixa de Produtos";
            this.saidaBaixaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.saidaBaixaDeProdutosToolStripMenuItem_Click);
            // 
            // vencidosToolStripMenuItem
            // 
            this.vencidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proximosADataToolStripMenuItem,
            this.vencidosToolStripMenuItem1});
            this.vencidosToolStripMenuItem.Name = "vencidosToolStripMenuItem";
            this.vencidosToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.vencidosToolStripMenuItem.Text = "Vencidos";
            // 
            // proximosADataToolStripMenuItem
            // 
            this.proximosADataToolStripMenuItem.Name = "proximosADataToolStripMenuItem";
            this.proximosADataToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.proximosADataToolStripMenuItem.Text = "Vencidos: Proximos a data";
            // 
            // vencidosToolStripMenuItem1
            // 
            this.vencidosToolStripMenuItem1.Name = "vencidosToolStripMenuItem1";
            this.vencidosToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.vencidosToolStripMenuItem1.Text = "Vencidos: Informar Periodo";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem2,
            this.movimentoToolStripMenuItem,
            this.vencidosToolStripMenuItem2});
            this.relatoriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // produtosToolStripMenuItem2
            // 
            this.produtosToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosOsProdutosToolStripMenuItem,
            this.produtoPorMarcaToolStripMenuItem,
            this.produtosCadastradosNoMesCorrenteToolStripMenuItem,
            this.produtosCadastradosNoMêsAnteriorToolStripMenuItem});
            this.produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            this.produtosToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.produtosToolStripMenuItem2.Text = "Produto";
            // 
            // todosOsProdutosToolStripMenuItem
            // 
            this.todosOsProdutosToolStripMenuItem.Name = "todosOsProdutosToolStripMenuItem";
            this.todosOsProdutosToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.todosOsProdutosToolStripMenuItem.Text = "Produtos: Todos";
            // 
            // produtoPorMarcaToolStripMenuItem
            // 
            this.produtoPorMarcaToolStripMenuItem.Name = "produtoPorMarcaToolStripMenuItem";
            this.produtoPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.produtoPorMarcaToolStripMenuItem.Text = "Produtos: Por Marca";
            // 
            // produtosCadastradosNoMesCorrenteToolStripMenuItem
            // 
            this.produtosCadastradosNoMesCorrenteToolStripMenuItem.Name = "produtosCadastradosNoMesCorrenteToolStripMenuItem";
            this.produtosCadastradosNoMesCorrenteToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.produtosCadastradosNoMesCorrenteToolStripMenuItem.Text = "Produtos: Cadastrados no Mês Corrente";
            // 
            // produtosCadastradosNoMêsAnteriorToolStripMenuItem
            // 
            this.produtosCadastradosNoMêsAnteriorToolStripMenuItem.Name = "produtosCadastradosNoMêsAnteriorToolStripMenuItem";
            this.produtosCadastradosNoMêsAnteriorToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.produtosCadastradosNoMêsAnteriorToolStripMenuItem.Text = "Produtos: Cadastrados no Mês Anterior";
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentaçãoDoMêsToolStripMenuItem,
            this.movimentoDoMesAnteriorToolStripMenuItem,
            this.movimentoToolStripMenuItem1});
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.movimentoToolStripMenuItem.Text = "Movimento";
            // 
            // movimentaçãoDoMêsToolStripMenuItem
            // 
            this.movimentaçãoDoMêsToolStripMenuItem.Name = "movimentaçãoDoMêsToolStripMenuItem";
            this.movimentaçãoDoMêsToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.movimentaçãoDoMêsToolStripMenuItem.Text = "Movimento: Mês Corrente";
            // 
            // movimentoDoMesAnteriorToolStripMenuItem
            // 
            this.movimentoDoMesAnteriorToolStripMenuItem.Name = "movimentoDoMesAnteriorToolStripMenuItem";
            this.movimentoDoMesAnteriorToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.movimentoDoMesAnteriorToolStripMenuItem.Text = "Movimento: Mes Anterior";
            // 
            // movimentoToolStripMenuItem1
            // 
            this.movimentoToolStripMenuItem1.Name = "movimentoToolStripMenuItem1";
            this.movimentoToolStripMenuItem1.Size = new System.Drawing.Size(264, 26);
            this.movimentoToolStripMenuItem1.Text = "Movimento: Informar Data";
            // 
            // vencidosToolStripMenuItem2
            // 
            this.vencidosToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vencidosNesteMêsToolStripMenuItem,
            this.vencidosNoMesAnteriorToolStripMenuItem,
            this.venToolStripMenuItem});
            this.vencidosToolStripMenuItem2.Name = "vencidosToolStripMenuItem2";
            this.vencidosToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.vencidosToolStripMenuItem2.Text = "Vencidos";
            // 
            // vencidosNesteMêsToolStripMenuItem
            // 
            this.vencidosNesteMêsToolStripMenuItem.Name = "vencidosNesteMêsToolStripMenuItem";
            this.vencidosNesteMêsToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.vencidosNesteMêsToolStripMenuItem.Text = "Vencidos: Este Mês";
            // 
            // vencidosNoMesAnteriorToolStripMenuItem
            // 
            this.vencidosNoMesAnteriorToolStripMenuItem.Name = "vencidosNoMesAnteriorToolStripMenuItem";
            this.vencidosNoMesAnteriorToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.vencidosNoMesAnteriorToolStripMenuItem.Text = "Vencidos: Mês Anterior";
            // 
            // venToolStripMenuItem
            // 
            this.venToolStripMenuItem.Name = "venToolStripMenuItem";
            this.venToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.venToolStripMenuItem.Text = "Vencidos: Informar Data";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // trocarToolStripMenuItem
            // 
            this.trocarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.trocarToolStripMenuItem.Name = "trocarToolStripMenuItem";
            this.trocarToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.trocarToolStripMenuItem.Text = "Trocar Usuário";
            this.trocarToolStripMenuItem.Click += new System.EventHandler(this.trocarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelNomeUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelNomeUsuario
            // 
            this.toolStripStatusLabelNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabelNomeUsuario.Name = "toolStripStatusLabelNomeUsuario";
            this.toolStripStatusLabelNomeUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::EstoqueEsteticaSenac.Properties.Resources.logo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Estoque Estetica Senac";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posiçãoDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaBaixaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vencidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximosADataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vencidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem todosOsProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoPorMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosCadastradosNoMesCorrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosCadastradosNoMêsAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoDoMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDoMesAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vencidosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vencidosNesteMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vencidosNoMesAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNomeUsuario;
    }
}