using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class TelaListaPedidos : Form
    {
        private object e;

        public TelaListaPedidos()
        {
            InitializeComponent();
        }

        private void TelaListaPedidos_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarPedidos();
        }

        private void CarregarPedidos()
        {
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.AutoGenerateColumns = false;
            List<Pedido> pedidos = Program.Gerenciador.TodosOsPedidos();
            dgPedidos.DataSource = pedidos;

            CarregaTotal(pedidos);
        }

        private void CarregaTotal(List<Pedido> pedidos)
        {
            decimal totalPedidos = 0;
            foreach (Pedido pedido in pedidos)
            {
                totalPedidos += Convert.ToDecimal(pedido.ValorTotal);
            }
            PTotal.Text = Convert.ToString(totalPedidos);
        }

        private void dgBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido PedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;

            dgBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBebidas.MultiSelect = false;
            dgBebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBebidas.AutoGenerateColumns = false;
            dgBebidas.DataSource = PedidoSelecionado.Bebidas.ToList();

            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.MultiSelect = false;
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLanches.AutoGenerateColumns = false;
            dgLanches.DataSource = PedidoSelecionado.Lanches.ToList();
        }

        private bool VerificarSelecao()
        {
            if (dgPedidos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void AbreTelaInclusaoAlteracao(Pedido pedidoSelecionado)
        {
            ManterPedido tela = new ManterPedido();
            tela.MdiParent = this.MdiParent;
            tela.PedidoSelecionado = pedidoSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(pedidoSelecionado);
            }
        }
    }
}
