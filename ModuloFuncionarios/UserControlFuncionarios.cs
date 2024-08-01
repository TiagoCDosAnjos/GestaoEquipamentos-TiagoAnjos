using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloFuncionarios
{
    public partial class UserControlFuncionarios : ViewUserControl
    {
        FuncionarioController funcionarioController;
        public UserControlFuncionarios(FuncionarioController funcionarioController)
        {
            InitializeComponent();
            this.funcionarioController = funcionarioController;
            Atualizar();
        }

        public override void Atualizar()
        {
            this.listBoxFuncionarios.DataSource = null;
            this.listBoxFuncionarios.DataSource = funcionarioController.ObterFuncionarios();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcionarioController.MostrarViewFormFuncionario();
            Atualizar();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxFuncionarios.SelectedItems[0] is FuncionarioModel funcionarioModel)
            {
                funcionarioController.MostrarViewFormFuncionario(funcionarioModel);
                Atualizar();
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxFuncionarios.SelectedItems[0] is FuncionarioModel funcionarioModel)
            {
                funcionarioController.MostrarViewFormDeleteFuncionario(funcionarioModel);
                Atualizar();
            }
        }
    }
}
