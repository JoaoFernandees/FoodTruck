namespace Foodtruck.Grafico
{
    partial class TelaListaPedidos
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
            this.btAlterar = new System.Windows.Forms.Button();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.NomeBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamanhoBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLanches = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).BeginInit();
            this.SuspendLayout();
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(12, 12);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(118, 35);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar Pedido";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Cliente,
            this.Total,
            this.Data});
            this.dgPedidos.Location = new System.Drawing.Point(12, 53);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.Size = new System.Drawing.Size(466, 436);
            this.dgPedidos.TabIndex = 4;
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Código.DataPropertyName = "Id";
            this.Código.FillWeight = 81.21828F;
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "NomeCliente";
            this.Cliente.FillWeight = 106.2606F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "ValorTotal";
            this.Total.FillWeight = 106.2606F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.DataPropertyName = "DataCompra";
            this.Data.FillWeight = 106.2606F;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeBebida,
            this.ValorBebida,
            this.TamanhoBebida});
            this.dgBebidas.Location = new System.Drawing.Point(484, 53);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.Size = new System.Drawing.Size(348, 221);
            this.dgBebidas.TabIndex = 5;
            // 
            // NomeBebida
            // 
            this.NomeBebida.DataPropertyName = "Nome";
            this.NomeBebida.HeaderText = "Nome";
            this.NomeBebida.Name = "NomeBebida";
            // 
            // ValorBebida
            // 
            this.ValorBebida.DataPropertyName = "Valor";
            this.ValorBebida.HeaderText = "Preço";
            this.ValorBebida.Name = "ValorBebida";
            // 
            // TamanhoBebida
            // 
            this.TamanhoBebida.DataPropertyName = "Tamanho";
            this.TamanhoBebida.HeaderText = "Tamanho";
            this.TamanhoBebida.Name = "TamanhoBebida";
            this.TamanhoBebida.ReadOnly = true;
            // 
            // dgLanches
            // 
            this.dgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Preço});
            this.dgLanches.Location = new System.Drawing.Point(484, 280);
            this.dgLanches.Name = "dgLanches";
            this.dgLanches.Size = new System.Drawing.Size(348, 209);
            this.dgLanches.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Preço
            // 
            this.Preço.DataPropertyName = "Valor";
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            // 
            // ssss
            // 
            this.ssss.AutoSize = true;
            this.ssss.Location = new System.Drawing.Point(12, 492);
            this.ssss.Name = "ssss";
            this.ssss.Size = new System.Drawing.Size(51, 13);
            this.ssss.TabIndex = 7;
            this.ssss.Text = "Total: R$";
            // 
            // TelaListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 534);
            this.Controls.Add(this.ssss);
            this.Controls.Add(this.dgLanches);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.btAlterar);
            this.Name = "TelaListaPedidos";
            this.Text = "TelaListaPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamanhoBebida;
        private System.Windows.Forms.DataGridView dgLanches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.Label ssss;
    }
}