using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloFuncionarios
{
    public partial class FormFuncionario : Form
    {
        IAdicionar<FuncionarioModel> _adicionar { get; set; }
        IAtualizar<FuncionarioModel> _atualizar { get; set; }

        private FuncionarioModel _funcionarioModel;
        public FormFuncionario(IAdicionar<FuncionarioModel> adicionar, IAtualizar<FuncionarioModel> atualizar, FuncionarioModel funcionarioModel = null)
        {
            InitializeComponent();
            _adicionar = adicionar;
            _atualizar = atualizar;
            if (funcionarioModel != null)
            {
                _funcionarioModel = new FuncionarioModel();
                txtDepartamento.Text = funcionarioModel.Departamento;
                txtNome.Text = funcionarioModel.Nome;
                dateTimeInicio.Value = funcionarioModel.DataInicio;
                txtFuncao.Text = funcionarioModel.Funcao;
                txtEmail.Text = funcionarioModel.Email;
                txtTelefone.Text = funcionarioModel.Telefone;
                txtSupervisor.Text = funcionarioModel.Supervisor;

                _funcionarioModel.Indice = funcionarioModel.Indice;
                btnAdicionar.Text = "Atualizar";
            }
            else
            {
                _funcionarioModel = new FuncionarioModel();
                btnAdicionar.Text = "Adicionar";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _funcionarioModel.DataInicio = this.dateTimeInicio.Value;
            _funcionarioModel.Departamento = this.txtDepartamento.Text;
            _funcionarioModel.Funcao = this.txtFuncao.Text;
            _funcionarioModel.Email = this.txtEmail.Text;
            _funcionarioModel.Nome = this.txtNome.Text;
            _funcionarioModel.Telefone = this.txtTelefone.Text;
            _funcionarioModel.Supervisor = this.txtSupervisor.Text;

            try
            {
                if (_funcionarioModel.Indice == -1)
                {
                    _adicionar.Adicionar(_funcionarioModel);
                }
                else
                {
                    _atualizar.Atualizar(_funcionarioModel);
                }
                //Se deu certo
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = $"Erro: {ex.Message}";
            }
        }
    }
}
