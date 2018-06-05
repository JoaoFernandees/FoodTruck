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
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DadosCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encerrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DadosCliente,
            this.DataCompra,
            this.ValorTotal,
            this.Encerrado});
            this.dgPedidos.Location = new System.Drawing.Point(12, 53);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.Size = new System.Drawing.Size(820, 298);
            this.dgPedidos.TabIndex = 4;
            this.dgPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPedidos_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 81.21828F;
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DadosCliente
            // 
            this.DadosCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DadosCliente.DataPropertyName = "DadosCliente";
            this.DadosCliente.FillWeight = 106.2606F;
            this.DadosCliente.HeaderText = "Cliente";
            this.DadosCliente.Name = "DadosCliente";
            this.DadosCliente.ReadOnly = true;
            // 
            // DataCompra
            // 
            this.DataCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataCompra.DataPropertyName = "DataCompra";
            this.DataCompra.FillWeight = 106.2606F;
            this.DataCompra.HeaderText = "Data";
            this.DataCompra.Name = "DataCompra";
            this.DataCompra.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "Valor";
            this.ValorTotal.Name = "ValorTotal";
            // 
            // Encerrado
            // 
            this.Encerrado.DataPropertyName = "Encerrado";
            this.Encerrado.HeaderText = "Encerrado";
            this.Encerrado.Name = "Encerrado";
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(586, 11);
            this.btFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(246, 37);
            this.btFinalizar.TabIndex = 11;
            this.btFinalizar.Text = "Encerrar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(313, 11);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(246, 37);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click_1);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 11);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(254, 37);
            this.btAdicionar.TabIndex = 9;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // TelaListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 364);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgPedidos);
            this.Name = "TelaListaPedidos";
            this.Text = "TelaListaPedidos";
            this.Load += new System.EventHandler(this.TelaListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DadosCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Encerrado;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btAdicionar;
    }
}