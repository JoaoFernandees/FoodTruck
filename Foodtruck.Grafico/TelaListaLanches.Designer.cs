namespace Foodtruck.Grafico
{
    partial class TelaListaLanches
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
            this.dgLanches = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLanches
            // 
            this.dgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.Valor});
            this.dgLanches.Location = new System.Drawing.Point(12, 51);
            this.dgLanches.Name = "dgLanches";
            this.dgLanches.Size = new System.Drawing.Size(491, 268);
            this.dgLanches.TabIndex = 5;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "iD";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 12);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(89, 33);
            this.btAdicionar.TabIndex = 6;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(107, 12);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(88, 33);
            this.btAlterar.TabIndex = 7;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(201, 12);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(85, 33);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click_1);
            // 
            // TelaListaLanches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 335);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgLanches);
            this.Name = "TelaListaLanches";
            this.Text = "TelaListaLanches";
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLanches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btRemover;
    }
}