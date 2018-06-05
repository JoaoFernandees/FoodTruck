namespace Foodtruck.Grafico
{
    partial class ManterPedido
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
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.btAdicionaBebida = new System.Windows.Forms.Button();
            this.btRetiraBebida = new System.Windows.Forms.Button();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLanches = new System.Windows.Forms.ComboBox();
            this.dgLanches = new System.Windows.Forms.DataGridView();
            this.NomeLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdicionaLanche = new System.Windows.Forms.Button();
            this.btRetiraLanche = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(63, 11);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(186, 21);
            this.cbClientes.TabIndex = 5;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bebidas:";
            // 
            // cbBebidas
            // 
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Location = new System.Drawing.Point(63, 47);
            this.cbBebidas.Margin = new System.Windows.Forms.Padding(2);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(186, 21);
            this.cbBebidas.TabIndex = 8;
            // 
            // btAdicionaBebida
            // 
            this.btAdicionaBebida.Location = new System.Drawing.Point(253, 47);
            this.btAdicionaBebida.Margin = new System.Windows.Forms.Padding(2);
            this.btAdicionaBebida.Name = "btAdicionaBebida";
            this.btAdicionaBebida.Size = new System.Drawing.Size(49, 22);
            this.btAdicionaBebida.TabIndex = 9;
            this.btAdicionaBebida.Text = "+";
            this.btAdicionaBebida.UseVisualStyleBackColor = true;
            this.btAdicionaBebida.Click += new System.EventHandler(this.btAdicionaBebida_Click);
            // 
            // btRetiraBebida
            // 
            this.btRetiraBebida.Location = new System.Drawing.Point(306, 47);
            this.btRetiraBebida.Name = "btRetiraBebida";
            this.btRetiraBebida.Size = new System.Drawing.Size(40, 22);
            this.btRetiraBebida.TabIndex = 15;
            this.btRetiraBebida.Text = "-";
            this.btRetiraBebida.UseVisualStyleBackColor = true;
            this.btRetiraBebida.Click += new System.EventHandler(this.btRetiraBebida_Click);
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Tamanho,
            this.Valor});
            this.dgBebidas.Location = new System.Drawing.Point(14, 87);
            this.dgBebidas.Margin = new System.Windows.Forms.Padding(2);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.RowTemplate.Height = 33;
            this.dgBebidas.Size = new System.Drawing.Size(358, 207);
            this.dgBebidas.TabIndex = 16;
            this.dgBebidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBebidas_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor total:";
            // 
            // cbLanches
            // 
            this.cbLanches.FormattingEnabled = true;
            this.cbLanches.Location = new System.Drawing.Point(481, 47);
            this.cbLanches.Margin = new System.Windows.Forms.Padding(2);
            this.cbLanches.Name = "cbLanches";
            this.cbLanches.Size = new System.Drawing.Size(143, 21);
            this.cbLanches.TabIndex = 18;
            // 
            // dgLanches
            // 
            this.dgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeLanche,
            this.ValorLanche});
            this.dgLanches.Location = new System.Drawing.Point(426, 87);
            this.dgLanches.Margin = new System.Windows.Forms.Padding(2);
            this.dgLanches.Name = "dgLanches";
            this.dgLanches.RowTemplate.Height = 33;
            this.dgLanches.Size = new System.Drawing.Size(346, 207);
            this.dgLanches.TabIndex = 19;
            // 
            // NomeLanche
            // 
            this.NomeLanche.DataPropertyName = "Nome";
            this.NomeLanche.HeaderText = "Nome";
            this.NomeLanche.Name = "NomeLanche";
            // 
            // ValorLanche
            // 
            this.ValorLanche.DataPropertyName = "Valor";
            this.ValorLanche.HeaderText = "Valor";
            this.ValorLanche.Name = "ValorLanche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lanches:";
            // 
            // btAdicionaLanche
            // 
            this.btAdicionaLanche.Location = new System.Drawing.Point(628, 45);
            this.btAdicionaLanche.Margin = new System.Windows.Forms.Padding(2);
            this.btAdicionaLanche.Name = "btAdicionaLanche";
            this.btAdicionaLanche.Size = new System.Drawing.Size(42, 23);
            this.btAdicionaLanche.TabIndex = 21;
            this.btAdicionaLanche.Text = "+";
            this.btAdicionaLanche.UseVisualStyleBackColor = true;
            this.btAdicionaLanche.Click += new System.EventHandler(this.btAdicionaLanche_Click);
            // 
            // btRetiraLanche
            // 
            this.btRetiraLanche.Location = new System.Drawing.Point(675, 45);
            this.btRetiraLanche.Name = "btRetiraLanche";
            this.btRetiraLanche.Size = new System.Drawing.Size(31, 23);
            this.btRetiraLanche.TabIndex = 22;
            this.btRetiraLanche.Text = "-";
            this.btRetiraLanche.UseVisualStyleBackColor = true;
            this.btRetiraLanche.Click += new System.EventHandler(this.btRetiraLanche_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(665, 298);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(107, 30);
            this.btSalvar.TabIndex = 23;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // ManterPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btRetiraLanche);
            this.Controls.Add(this.btAdicionaLanche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgLanches);
            this.Controls.Add(this.cbLanches);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.btRetiraBebida);
            this.Controls.Add(this.btAdicionaBebida);
            this.Controls.Add(this.cbBebidas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClientes);
            this.Name = "ManterPedido";
            this.Text = "ManterPedido";
            this.Load += new System.EventHandler(this.AdicionaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBebidas;
        private System.Windows.Forms.Button btAdicionaBebida;
        private System.Windows.Forms.Button btRetiraBebida;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLanches;
        private System.Windows.Forms.DataGridView dgLanches;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLanche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdicionaLanche;
        private System.Windows.Forms.Button btRetiraLanche;
        private System.Windows.Forms.Button btSalvar;
    }
}