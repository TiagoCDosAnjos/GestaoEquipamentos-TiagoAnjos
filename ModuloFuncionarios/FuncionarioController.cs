using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using GestaoEquipamentos.WinFormsApp.ModuloFabricantes;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.WinFormsApp.ModuloFuncionarios
{
    public class FuncionarioController : BaseController, IAdicionar<FuncionarioModel>, IAtualizar<FuncionarioModel>
    {
        private IRepositorio<FuncionarioModel> _repositorio { get; set; }
        private IRepositorioFuncionario _repositorioFuncionario { get; set; }

        public FuncionarioController(
            IRepositorio<FuncionarioModel> repositorio,
            IRepositorioFuncionario repositorioFuncionario
            )
        {
            _repositorio = repositorio;
            _repositorioFuncionario = repositorioFuncionario;

            base.View = new UserControlFuncionarios(this);
        }

        public FuncionarioController()
        {
        }

        public List<FuncionarioModel> ObterFuncionarios()
        {
            return _repositorio.ObterTodos();
        }
        public void MostrarViewFormFuncionario(FuncionarioModel funcionarioModel = null)
        {
            FormFuncionario formFuncionario =
                new FormFuncionario(this, this, funcionarioModel);
            formFuncionario.ShowDialog();
        }

        public void Adicionar(FuncionarioModel funcionario)
        {
            var resultado = funcionario.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                if (_repositorioFuncionario.VerificarPorNome(funcionario.Nome))
                {
                    resultado = "Já existe funcionario com este nome cadastrado! ";
                    throw new FuncionarioException(resultado);
                }
                _repositorio.Adicionar(funcionario);
                return;
            }
            throw new FuncionarioException(resultado);
        }

        public void Atualizar(FuncionarioModel funcionarioModel)
        {
            var resultado = funcionarioModel.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                if (_repositorioFuncionario.VerificarPorNome(funcionarioModel.Nome))
                {
                    resultado = "Já existe fabricante com este nome cadastrado! ";
                    throw new FabricanteException(resultado);
                }
                _repositorio.Atualizar(funcionarioModel);
                return;
            }
            throw new FuncionarioException(resultado);
        }

        public void MostrarViewFormDeleteFuncionario(FuncionarioModel funcionarioModel)
        {
            var resultado =
            MessageBox.
            Show(
                 $"Você confirma a remoção do funcionario {funcionarioModel.Nome}",
                 "Remover funcionario",
                 MessageBoxButtons.YesNoCancel);

            if (DialogResult.Yes == resultado)
            {
                _repositorio.Excluir(funcionarioModel);
            }
        }

        public class FuncionarioException : Exception
        {
            public FuncionarioException(string erro) : base(erro)
            {
            }
        }
    }
}

