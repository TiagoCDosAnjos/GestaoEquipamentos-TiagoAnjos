﻿namespace GestaoEquipamentos.WinFormsApp.ModuloAutenticacao
{
    public partial class FormAutenticacaoView : Form
    {

        //Controllador
        AutenticadorController AutenticadorController { get; set; }

        public FormAutenticacaoView()
        {
            InitializeComponent();
            AutenticadorController = new AutenticadorController();

            //dataGridView1.DataSource = AutenticadorController.ObterUsuarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            try
            {
                if (AutenticadorController.Autenticar(login, senha))
                {
                    Hide();
                    TelaPrincipalForm gestaoEquipamentosForm = new TelaPrincipalForm();
                    gestaoEquipamentosForm.ShowDialog(this);

                    Close();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelInfo.Text = ex.Message;
            }

        }
    }
}
