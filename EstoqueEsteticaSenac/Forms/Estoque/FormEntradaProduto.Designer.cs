namespace EstoqueEsteticaSenac.Forms.Estoque
{
    partial class FormEntradaProduto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodigoProduto = new System.Windows.Forms.TextBox();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxVencimento = new System.Windows.Forms.MaskedTextBox();
            this.entradaEstoque1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradaEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewEntradaEstoque = new System.Windows.Forms.DataGridView();
            this.codigoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaEstoque1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.esteticaDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCodigoBarras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.entradaEstoque1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaEstoque1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esteticaDataSet5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Entrada";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(12, 304);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 30);
            this.buttonInserir.TabIndex = 5;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(110, 304);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 30);
            this.buttonAlterar.TabIndex = 6;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(200, 304);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 30);
            this.buttonExcluir.TabIndex = 7;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(301, 304);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(83, 30);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Entrada do Estoque";
            // 
            // textBoxCodigoProduto
            // 
            this.textBoxCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoProduto.Location = new System.Drawing.Point(213, 56);
            this.textBoxCodigoProduto.Name = "textBoxCodigoProduto";
            this.textBoxCodigoProduto.ReadOnly = true;
            this.textBoxCodigoProduto.Size = new System.Drawing.Size(171, 23);
            this.textBoxCodigoProduto.TabIndex = 11;
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduto.Location = new System.Drawing.Point(213, 122);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.ReadOnly = true;
            this.textBoxProduto.Size = new System.Drawing.Size(171, 23);
            this.textBoxProduto.TabIndex = 12;
            this.textBoxProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProduto_KeyPress);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(213, 161);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.ReadOnly = true;
            this.textBoxMarca.Size = new System.Drawing.Size(171, 23);
            this.textBoxMarca.TabIndex = 13;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantidade.Location = new System.Drawing.Point(213, 195);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(171, 23);
            this.textBoxQuantidade.TabIndex = 14;
            this.textBoxQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantidade_KeyPress_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data Vencimento";
            // 
            // maskedTextBoxDataEntrada
            // 
            this.maskedTextBoxDataEntrada.Location = new System.Drawing.Point(249, 224);
            this.maskedTextBoxDataEntrada.Mask = "00/00/0000";
            this.maskedTextBoxDataEntrada.Name = "maskedTextBoxDataEntrada";
            this.maskedTextBoxDataEntrada.ResetOnPrompt = false;
            this.maskedTextBoxDataEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBoxDataEntrada.Size = new System.Drawing.Size(86, 26);
            this.maskedTextBoxDataEntrada.TabIndex = 17;
            this.maskedTextBoxDataEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxDataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxVencimento
            // 
            this.maskedTextBoxVencimento.Location = new System.Drawing.Point(249, 258);
            this.maskedTextBoxVencimento.Mask = "99/99/9999";
            this.maskedTextBoxVencimento.Name = "maskedTextBoxVencimento";
            this.maskedTextBoxVencimento.Size = new System.Drawing.Size(86, 26);
            this.maskedTextBoxVencimento.TabIndex = 18;
            this.maskedTextBoxVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entradaEstoqueBindingSource
            // 
            this.entradaEstoqueBindingSource.DataMember = "EntradaEstoque";
            // 
            // dataGridViewEntradaEstoque
            // 
            this.dataGridViewEntradaEstoque.AutoGenerateColumns = false;
            this.dataGridViewEntradaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntradaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn});
            this.dataGridViewEntradaEstoque.DataSource = this.entradaEstoque1BindingSource1;
            this.dataGridViewEntradaEstoque.Location = new System.Drawing.Point(12, 341);
            this.dataGridViewEntradaEstoque.Name = "dataGridViewEntradaEstoque";
            this.dataGridViewEntradaEstoque.Size = new System.Drawing.Size(581, 150);
            this.dataGridViewEntradaEstoque.TabIndex = 19;
            this.dataGridViewEntradaEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntradaEstoque_CellClick);
            // 
            // codigoProdutoDataGridViewTextBoxColumn
            // 
            this.codigoProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProduto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigoProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.codigoProdutoDataGridViewTextBoxColumn.HeaderText = "CodigoProduto";
            this.codigoProdutoDataGridViewTextBoxColumn.Name = "codigoProdutoDataGridViewTextBoxColumn";
            this.codigoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoProdutoDataGridViewTextBoxColumn.Width = 140;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 117;
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrada";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataEntradaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataEntradaDataGridViewTextBoxColumn.Width = 126;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataVencimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 154;
            // 
            // entradaEstoque1BindingSource1
            // 
            this.entradaEstoque1BindingSource1.DataMember = "EntradaEstoque1";
            // 
            // esteticaDataSet5
            // 
            // 
            // esteticaDataSet5BindingSource
            // 
            this.esteticaDataSet5BindingSource.Position = 0;
            // 
            // entradaEstoque1TableAdapter1
            //             
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Código de Barras";
            // 
            // textBoxCodigoBarras
            // 
            this.textBoxCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoBarras.Location = new System.Drawing.Point(213, 90);
            this.textBoxCodigoBarras.Name = "textBoxCodigoBarras";
            this.textBoxCodigoBarras.Size = new System.Drawing.Size(171, 23);
            this.textBoxCodigoBarras.TabIndex = 21;
            // 
            // FormEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 503);
            this.Controls.Add(this.textBoxCodigoBarras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewEntradaEstoque);
            this.Controls.Add(this.maskedTextBoxVencimento);
            this.Controls.Add(this.maskedTextBoxDataEntrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.textBoxCodigoProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntradaProduto";
            this.Text = "FormEntradaProduto";
            this.Load += new System.EventHandler(this.FormEntradaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entradaEstoque1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaEstoque1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esteticaDataSet5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodigoProduto;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataEntrada;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVencimento;

        private System.Windows.Forms.BindingSource entradaEstoqueBindingSource;


        private System.Windows.Forms.BindingSource entradaEstoque1BindingSource;

        private System.Windows.Forms.DataGridView dataGridViewEntradaEstoque;
        private System.Windows.Forms.BindingSource esteticaDataSet5BindingSource;        
        private System.Windows.Forms.BindingSource entradaEstoque1BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCodigoBarras;
    }
}