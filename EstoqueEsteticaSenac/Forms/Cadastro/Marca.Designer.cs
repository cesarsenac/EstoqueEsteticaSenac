namespace EstoqueEsteticaSenac.Forms
{
    partial class Marca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marca));
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxObservacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueEsteticaDataSet = new EstoqueEsteticaSenac.EstoqueEsteticaDataSet();
            this.tblMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new EstoqueEsteticaSenac.EstoqueEsteticaDataSetTableAdapters.MarcaTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueEsteticaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMarcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(77, 32);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(70, 23);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(236, 29);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(203, 23);
            this.textBoxMarca.TabIndex = 6;
            // 
            // textBoxObservacao
            // 
            this.textBoxObservacao.Location = new System.Drawing.Point(35, 93);
            this.textBoxObservacao.Multiline = true;
            this.textBoxObservacao.Name = "textBoxObservacao";
            this.textBoxObservacao.Size = new System.Drawing.Size(484, 128);
            this.textBoxObservacao.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Observação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.Location = new System.Drawing.Point(38, 295);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(95, 33);
            this.buttonInserir.TabIndex = 11;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletar.Location = new System.Drawing.Point(157, 295);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(95, 33);
            this.buttonDeletar.TabIndex = 12;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Location = new System.Drawing.Point(292, 295);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(95, 33);
            this.buttonPesquisar.TabIndex = 13;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(424, 295);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(95, 33);
            this.buttonAtualizar.TabIndex = 14;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.marcaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(508, 214);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.estoqueEsteticaDataSet;
            // 
            // estoqueEsteticaDataSet
            // 
            this.estoqueEsteticaDataSet.DataSetName = "EstoqueEsteticaDataSet";
            this.estoqueEsteticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMarcaBindingSource
            // 
            this.tblMarcaBindingSource.DataMember = "Tbl_Marca";
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Marca";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nome_Marca";
            this.dataGridViewTextBoxColumn5.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Observacao_Marca";
            this.dataGridViewTextBoxColumn6.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxObservacao);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Marca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.Marca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueEsteticaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMarcaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxObservacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblMarcaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private EstoqueEsteticaDataSet estoqueEsteticaDataSet;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private EstoqueEsteticaDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}