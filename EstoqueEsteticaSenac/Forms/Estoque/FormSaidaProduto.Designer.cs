namespace EstoqueEsteticaSenac.Forms.Estoque
{
    partial class FormSaidaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaidaProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodigoProduto = new System.Windows.Forms.TextBox();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.saidaEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saidaEstoque2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saidaEstoque2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCodigoBarras = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estoqueesteticaDataSet1 = new EstoqueEsteticaSenac.estoqueesteticaDataSet1();
            this.saidaEstoqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.saidaEstoqueTableAdapter1 = new EstoqueEsteticaSenac.estoqueesteticaDataSet1TableAdapters.SaidaEstoqueTableAdapter();
            this.saidaEstoqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueEsteticaDataSet = new EstoqueEsteticaSenac.EstoqueEsteticaDataSet();
            this.saidaEstoqueTableAdapter = new EstoqueEsteticaSenac.EstoqueEsteticaDataSetTableAdapters.SaidaEstoqueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoque2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoque2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueesteticaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoqueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueEsteticaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saída no Estoque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data saída";
            // 
            // textBoxCodigoProduto
            // 
            this.textBoxCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoProduto.Location = new System.Drawing.Point(281, 58);
            this.textBoxCodigoProduto.MaxLength = 13;
            this.textBoxCodigoProduto.Name = "textBoxCodigoProduto";
            this.textBoxCodigoProduto.ReadOnly = true;
            this.textBoxCodigoProduto.Size = new System.Drawing.Size(171, 23);
            this.textBoxCodigoProduto.TabIndex = 6;
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduto.Location = new System.Drawing.Point(281, 130);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.ReadOnly = true;
            this.textBoxProduto.Size = new System.Drawing.Size(171, 23);
            this.textBoxProduto.TabIndex = 7;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(281, 164);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.ReadOnly = true;
            this.textBoxMarca.Size = new System.Drawing.Size(171, 23);
            this.textBoxMarca.TabIndex = 8;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantidade.Location = new System.Drawing.Point(281, 198);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(171, 23);
            this.textBoxQuantidade.TabIndex = 9;
            this.textBoxQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantidade_KeyPress);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.Location = new System.Drawing.Point(126, 537);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 30);
            this.buttonInserir.TabIndex = 11;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(207, 537);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 30);
            this.buttonAlterar.TabIndex = 12;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click_1);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(288, 537);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 30);
            this.buttonExcluir.TabIndex = 13;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(369, 537);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(83, 30);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data de vencimento";
            // 
            // maskedTextBoxDataSaida
            // 
            this.maskedTextBoxDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataSaida.Location = new System.Drawing.Point(281, 233);
            this.maskedTextBoxDataSaida.Mask = "99/99/9999";
            this.maskedTextBoxDataSaida.Name = "maskedTextBoxDataSaida";
            this.maskedTextBoxDataSaida.Size = new System.Drawing.Size(80, 23);
            this.maskedTextBoxDataSaida.TabIndex = 18;
            this.maskedTextBoxDataSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxDataVencimento
            // 
            this.maskedTextBoxDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataVencimento.Location = new System.Drawing.Point(281, 268);
            this.maskedTextBoxDataVencimento.Mask = "99/99/9999";
            this.maskedTextBoxDataVencimento.Name = "maskedTextBoxDataVencimento";
            this.maskedTextBoxDataVencimento.Size = new System.Drawing.Size(80, 23);
            this.maskedTextBoxDataVencimento.TabIndex = 19;
            this.maskedTextBoxDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saidaEstoqueBindingSource
            // 
            this.saidaEstoqueBindingSource.DataMember = "SaidaEstoque";
            // 
            // saidaEstoque2BindingSource1
            // 
            this.saidaEstoque2BindingSource1.DataMember = "SaidaEstoque2";
            // 
            // saidaEstoque2BindingSource
            // 
            this.saidaEstoque2BindingSource.DataMember = "SaidaEstoque2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(120, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Código de Barras";
            // 
            // textBoxCodigoBarras
            // 
            this.textBoxCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoBarras.Location = new System.Drawing.Point(281, 92);
            this.textBoxCodigoBarras.MaxLength = 13;
            this.textBoxCodigoBarras.Name = "textBoxCodigoBarras";
            this.textBoxCodigoBarras.Size = new System.Drawing.Size(171, 26);
            this.textBoxCodigoBarras.TabIndex = 22;
            this.textBoxCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigoBarras_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 220);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // estoqueesteticaDataSet1
            // 
            this.estoqueesteticaDataSet1.DataSetName = "estoqueesteticaDataSet1";
            this.estoqueesteticaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saidaEstoqueBindingSource2
            // 
            this.saidaEstoqueBindingSource2.DataMember = "SaidaEstoque";
            this.saidaEstoqueBindingSource2.DataSource = this.estoqueesteticaDataSet1;
            // 
            // saidaEstoqueTableAdapter1
            // 
            this.saidaEstoqueTableAdapter1.ClearBeforeFill = true;
            // 
            // saidaEstoqueBindingSource1
            // 
            this.saidaEstoqueBindingSource1.DataMember = "SaidaEstoque";
            this.saidaEstoqueBindingSource1.DataSource = this.estoqueEsteticaDataSet;
            // 
            // estoqueEsteticaDataSet
            // 
            this.estoqueEsteticaDataSet.DataSetName = "EstoqueEsteticaDataSet";
            this.estoqueEsteticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saidaEstoqueTableAdapter
            // 
            this.saidaEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // FormSaidaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxCodigoBarras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBoxDataVencimento);
            this.Controls.Add(this.maskedTextBoxDataSaida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.textBoxCodigoProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaidaProduto";
            this.Text = "FormSaidaProduto";
            this.Load += new System.EventHandler(this.FormSaidaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoque2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoque2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueesteticaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoqueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaEstoqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueEsteticaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodigoProduto;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataSaida;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataVencimento;
        private System.Windows.Forms.BindingSource saidaEstoque2BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource saidaEstoque2BindingSource1;
        private System.Windows.Forms.BindingSource saidaEstoqueBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCodigoBarras;
        private EstoqueEsteticaDataSet estoqueEsteticaDataSet;
        private System.Windows.Forms.BindingSource saidaEstoqueBindingSource1;
        private EstoqueEsteticaDataSetTableAdapters.SaidaEstoqueTableAdapter saidaEstoqueTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private estoqueesteticaDataSet1 estoqueesteticaDataSet1;
        private System.Windows.Forms.BindingSource saidaEstoqueBindingSource2;
        private estoqueesteticaDataSet1TableAdapters.SaidaEstoqueTableAdapter saidaEstoqueTableAdapter1;
    }
}