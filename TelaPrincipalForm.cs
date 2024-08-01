using GestaoEquipamentos.WinFormsApp.ModuloClientes;
using GestaoEquipamentos.WinFormsApp.ModuloCSV;
using GestaoEquipamentos.WinFormsApp.ModuloEquipamentos;
using GestaoEquipamentos.WinFormsApp.ModuloFabricantes;
using GestaoEquipamentos.WinFormsApp.ModuloFuncionarios;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;

namespace GestaoEquipamentos.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private EquipamentosController equipamentosController { get; set; }
        private TipoDeEquipamentoController tipoDeEquipamentoController { get; set; }
        private FabricanteController fabricanteController { get; set; }
        private CsvController csvController { get; set; }
        private FuncionarioController funcionarioController { get; set; }
        private ClientesController _clientesController { get; set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            equipamentosController = new EquipamentosController();
            tipoDeEquipamentoController = new TipoDeEquipamentoController();
            funcionarioController = new FuncionarioController();

            var _repositorioFabricanteSemContrato = new RepositorioFabricanteEmArquivo();
            var _repositorioFuncionarioSemContrato = new RepositorioFuncionarioEmArquivo();

            //SOL "I" D 
            //IOC

            fabricanteController = new FabricanteController(
                _repositorioFabricanteSemContrato,
                _repositorioFabricanteSemContrato);

            funcionarioController = new FuncionarioController(
                _repositorioFuncionarioSemContrato,
                _repositorioFuncionarioSemContrato);

            csvController = new CsvController(
                equipamentosController,
                equipamentosController.ObterEquipamentos());

            _clientesController = new ClientesController();
        }

        private void buttonEquipamentos_Click(object sender, EventArgs e)
        {
            Equipamentos();
        }

        private void Equipamentos()
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(equipamentosController.View);
            equipamentosController.View.Atualizar();
        }

        private void TipoEquipamentos()
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(tipoDeEquipamentoController.View);
        }

        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipamentos();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            TipoEquipamentos();
        }

        private void TelaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        private void CSV()
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(csvController.View);
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            CSV();
        }

        private void btnFabricantes_Click(object sender, EventArgs e)
        {
            Fabricantes();
        }

        private void Fabricantes()
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(fabricanteController.View);
        }

        private void Funcionarios()
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(funcionarioController.View);
        }

        private void Clientes()
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(_clientesController.View);
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CSV();
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fabricantes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionarios();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes();
        }

        private void tipoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TipoEquipamentos();
        }
    }
}
