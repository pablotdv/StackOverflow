namespace ExibirDataFormatadaDataGridView
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gaveteiroLanchesDataSet = new ExibirDataFormatadaDataGridView.GaveteiroLanchesDataSet();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new ExibirDataFormatadaDataGridView.GaveteiroLanchesDataSetTableAdapters.PessoaTableAdapter();
            this.pessoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraCadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rgNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoMunicipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriminatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaveteiroLanchesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pessoaIdDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfCnpjDataGridViewTextBoxColumn,
            this.usuarioCadDataGridViewTextBoxColumn,
            this.dataHoraCadDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.rgNumeroDataGridViewTextBoxColumn,
            this.inscricaoMunicipalDataGridViewTextBoxColumn,
            this.nomeFantasiaDataGridViewTextBoxColumn,
            this.discriminatorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // gaveteiroLanchesDataSet
            // 
            this.gaveteiroLanchesDataSet.DataSetName = "GaveteiroLanchesDataSet";
            this.gaveteiroLanchesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.gaveteiroLanchesDataSet;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // pessoaIdDataGridViewTextBoxColumn
            // 
            this.pessoaIdDataGridViewTextBoxColumn.DataPropertyName = "PessoaId";
            this.pessoaIdDataGridViewTextBoxColumn.HeaderText = "PessoaId";
            this.pessoaIdDataGridViewTextBoxColumn.Name = "pessoaIdDataGridViewTextBoxColumn";
            this.pessoaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cpfCnpjDataGridViewTextBoxColumn
            // 
            this.cpfCnpjDataGridViewTextBoxColumn.DataPropertyName = "CpfCnpj";
            this.cpfCnpjDataGridViewTextBoxColumn.HeaderText = "CpfCnpj";
            this.cpfCnpjDataGridViewTextBoxColumn.Name = "cpfCnpjDataGridViewTextBoxColumn";
            // 
            // usuarioCadDataGridViewTextBoxColumn
            // 
            this.usuarioCadDataGridViewTextBoxColumn.DataPropertyName = "UsuarioCad";
            this.usuarioCadDataGridViewTextBoxColumn.HeaderText = "UsuarioCad";
            this.usuarioCadDataGridViewTextBoxColumn.Name = "usuarioCadDataGridViewTextBoxColumn";
            // 
            // dataHoraCadDataGridViewTextBoxColumn
            // 
            this.dataHoraCadDataGridViewTextBoxColumn.DataPropertyName = "DataHoraCad";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataHoraCadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataHoraCadDataGridViewTextBoxColumn.HeaderText = "DataHoraCad";
            this.dataHoraCadDataGridViewTextBoxColumn.Name = "dataHoraCadDataGridViewTextBoxColumn";
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            // 
            // rgNumeroDataGridViewTextBoxColumn
            // 
            this.rgNumeroDataGridViewTextBoxColumn.DataPropertyName = "RgNumero";
            this.rgNumeroDataGridViewTextBoxColumn.HeaderText = "RgNumero";
            this.rgNumeroDataGridViewTextBoxColumn.Name = "rgNumeroDataGridViewTextBoxColumn";
            // 
            // inscricaoMunicipalDataGridViewTextBoxColumn
            // 
            this.inscricaoMunicipalDataGridViewTextBoxColumn.DataPropertyName = "InscricaoMunicipal";
            this.inscricaoMunicipalDataGridViewTextBoxColumn.HeaderText = "InscricaoMunicipal";
            this.inscricaoMunicipalDataGridViewTextBoxColumn.Name = "inscricaoMunicipalDataGridViewTextBoxColumn";
            // 
            // nomeFantasiaDataGridViewTextBoxColumn
            // 
            this.nomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "NomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.HeaderText = "NomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.Name = "nomeFantasiaDataGridViewTextBoxColumn";
            // 
            // discriminatorDataGridViewTextBoxColumn
            // 
            this.discriminatorDataGridViewTextBoxColumn.DataPropertyName = "Discriminator";
            this.discriminatorDataGridViewTextBoxColumn.HeaderText = "Discriminator";
            this.discriminatorDataGridViewTextBoxColumn.Name = "discriminatorDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 476);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaveteiroLanchesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GaveteiroLanchesDataSet gaveteiroLanchesDataSet;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private GaveteiroLanchesDataSetTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraCadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricaoMunicipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriminatorDataGridViewTextBoxColumn;
    }
}

