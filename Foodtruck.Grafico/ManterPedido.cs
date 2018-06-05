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

        private void ManterPedido_Load(object sender, EventArgs e)
        {
            CarregaComboBoxes();
            CarregaDatagrids();
            CarregaTotal();
        }

        private void ManterPedidos_Shown(object sender, EventArgs e)
        {

        }

        private void CarregaTotal()
        {
            if (PedidoSelecionado != null)
            {
                label4.Text = PedidoSelecionado.ValorTotal.ToString();
            }
            else
            {
                label4.Text = pedido.ValorTotal.ToString();
            }

        }

        private void CarregaComboBoxes()
        {
            cbClientes.DisplayMember = "Descricao";
            cbClientes.ValueMember = "Id";
            cbClientes.DataSource = Program.Gerenciador.TodosOsClientes();

            cbLanches.DisplayMember = "Nome";
            cbLanches.ValueMember = "Id";
            cbLanches.DataSource = Program.Gerenciador.TodosOsLanches();

            cbBebidas.DisplayMember = "Nome";
            cbBebidas.ValueMember = "Id";
            cbBebidas.DataSource = Program.Gerenciador.TodasAsBebidas();
        }

        private void CarregaDatagrids()
        {
            if (PedidoSelecionado != null)
            {
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
                CarregaTotal();
            }
            else
            {
                dgBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgBebidas.MultiSelect = false;
                dgBebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgBebidas.AutoGenerateColumns = false;
                dgBebidas.DataSource = pedido.Bebidas.ToList();

                dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgLanches.MultiSelect = false;
                dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgLanches.AutoGenerateColumns = false;
                dgLanches.DataSource = pedido.Lanches.ToList();

                CarregaTotal();
            }
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAdicionaBebida_Click(object sender, EventArgs e)
        {
            if (PedidoSelecionado == null)
            {
                Bebida bebidaSelecionada = (Bebida)cbBebidas.SelectedItem;
                pedido.Bebidas.Add(bebidaSelecionada);
                CarregaDatagrids();
            }
            else
            {
                Bebida bebidaSelecionada = (Bebida)cbBebidas.SelectedItem;
                PedidoSelecionado.Bebidas.Add(bebidaSelecionada);
                CarregaDatagrids();
            }
        }



        private void cbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btAdicionaLanche_Click(object sender, EventArgs e)
        {
            if (PedidoSelecionado == null)
            {
                Lanche lancheSelecionado = cbLanches.SelectedItem as Lanche;
                pedido.Lanches.Add(lancheSelecionado);
                CarregaDatagrids();
            }

            else
            {
                Lanche lancheSelecionado = cbLanches.SelectedItem as Lanche;
                PedidoSelecionado.Lanches.Add(lancheSelecionado);
                CarregaDatagrids();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacao validacao;

                pedido.Cliente = cbClientes.SelectedItem as Cliente;
                pedido.DataCompra = DateTime.Now;

                if (PedidoSelecionado == null)
                {
                    validacao = Program.Gerenciador.CadastraPedido(pedido);
                }
                else
                {
                    PedidoSelecionado.Cliente = cbClientes.SelectedItem as Cliente;
                    validacao = Program.Gerenciador.AlterarPedido(PedidoSelecionado);
                }

                if (validacao.Valido)
                {
                    MessageBox.Show("Pedido salvo com sucesso!");
                }
                else
                {
                    String msg = "";
                    foreach (var mensagem in validacao.Mensagens)
                    {
                        msg += mensagem + Environment.NewLine;
                    }
                    MessageBox.Show(msg, "Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro grave, fale com o administrador");
            }
            this.Close();
        }

        private bool VerificarSelecaoBebida()
        {
            if (dgBebidas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private bool VerificarSelecaoLanche()
        {
            if (dgLanches.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btRetiraBebida_Click(object sender, EventArgs e)
        {
            if (PedidoSelecionado == null)
            {
                if (VerificarSelecaoBebida())
                {
                    Bebida bebidaSelecionada = (Bebida)dgBebidas.SelectedRows[0].DataBoundItem;
                    pedido.Bebidas.Remove(bebidaSelecionada);
                    CarregaDatagrids();
                }
            }
            else
            {
                Bebida bebidaSelecionada = (Bebida)dgBebidas.SelectedRows[0].DataBoundItem;
                PedidoSelecionado.Bebidas.Remove(bebidaSelecionada);
                CarregaDatagrids();
            }
        }

        private void btRetiraLanche_Click(object sender, EventArgs e)
        {
            if (PedidoSelecionado == null)
            {
                if (VerificarSelecaoLanche())
                {
                    Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                    pedido.Lanches.Remove(lancheSelecionado);
                    CarregaDatagrids();
                }
            }
            else
            {
                Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                PedidoSelecionado.Lanches.Remove(lancheSelecionado);
                CarregaDatagrids();
            }
        }

        private void dgLanches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
