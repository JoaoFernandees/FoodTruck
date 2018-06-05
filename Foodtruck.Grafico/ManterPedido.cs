using Foodtruck.Negocio;
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
    public partial class ManterPedido : Form
    {
        Pedido pedido = new Pedido();
        public Pedido PedidoSelecionado { get; set; }

        public ManterPedido()
        {
            InitializeComponent();
        }

        private void AdicionaPedido_Load(object sender, EventArgs e)
        {
            CarregaComboBoxes();
            CarregaDataGrids();
            CarregaTotal();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CarregaComboBoxes()
        {
            if (PedidoSelecionado == null)
            {
                cbClientes.DisplayMember = "Descricao";
                cbClientes.ValueMember = "Id";
                cbClientes.DataSource = Program.Gerenciador.TodosOsClientes();
            }

            cbLanches.DisplayMember = "Nome";
            cbLanches.ValueMember = "Id";
            cbLanches.DataSource = Program.Gerenciador.TodosOsLanches();

            cbBebidas.DisplayMember = "Nome";
            cbBebidas.ValueMember = "Id";
            cbBebidas.DataSource = Program.Gerenciador.TodasAsBebidas();
        }

        private void CarregaTotal()
        {
            label4.Text = pedido.ValorTotal.ToString();
        }

        private void btAdicionaBebida_Click(object sender, EventArgs e)
        {
            Bebida bebidaSelecionada = (Bebida)cbBebidas.SelectedItem;
            pedido.Bebidas.Add(bebidaSelecionada);
            CarregaDataGrids();
        }

        private void btRetiraBebida_Click(object sender, EventArgs e)
        {
            Bebida bebidaSelecionada = (Bebida)dgBebidas.SelectedRows[0].DataBoundItem;
            pedido.Bebidas.Remove(bebidaSelecionada);
            CarregaDataGrids();
        }

        private void btAdicionaLanche_Click(object sender, EventArgs e)
        {
            Lanche lancheSelecionado = (Lanche)cbLanches.SelectedItem;
            pedido.Lanches.Add(lancheSelecionado);
            CarregaDataGrids();
        }

        private void btRetiraLanche_Click(object sender, EventArgs e)
        {
            Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
            pedido.Lanches.Remove(lancheSelecionado);
            CarregaDataGrids();
        }

        private void CarregaDataGrids()
        {
            dgBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBebidas.AutoGenerateColumns = false;
            dgBebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBebidas.MultiSelect = false;
            dgBebidas.DataSource = pedido.Bebidas.ToList();

            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.AutoGenerateColumns = false;
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLanches.MultiSelect = false;
            dgLanches.DataSource = pedido.Lanches.ToList();

            CarregaTotal();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            /*try
            {*/
            if (PedidoSelecionado == null)
            {
                pedido.Cliente = cbClientes.SelectedItem as Cliente;
                pedido.DataCompra = DateTime.Now;
                pedido.Cliente.status = "1";
            }

            Validacao validacao;
            if (PedidoSelecionado == null)
            {
                validacao = Program.Gerenciador.CadastraPedido(pedido);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarPedido(pedido, true);
            }

            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var msg in validacao.Mensagens)
                {
                    mensagemValidacao += msg + Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao, "Erro");
            }
            else
            {
                MessageBox.Show("Pedido cadastrado com sucesso");
            }
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionaPedido_Shown(object sender, EventArgs e)
        {
            if (PedidoSelecionado != null)
            {
                this.pedido.Id = PedidoSelecionado.Id;
                this.pedido.Cliente = PedidoSelecionado.Cliente;
                this.pedido.DataCompra = PedidoSelecionado.DataCompra;
                this.cbClientes.Text = PedidoSelecionado.Cliente.Descricao;

                foreach (Bebida beb in PedidoSelecionado.Bebidas)
                {
                    pedido.Bebidas.Add(beb);
                }

                foreach (Lanche lan in PedidoSelecionado.Lanches)
                {
                    pedido.Lanches.Add(lan);
                }
                CarregaDataGrids();
            }
        }

        private void dgLanches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
