using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using GestaoEquipamentos.WinFormsApp.ModuloFabricantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.WinFormsApp.ModuloFuncionarios
{
    public class RepositorioFuncionarioEmArquivo :
        RepositorioEmArquivo<FuncionarioModel>,
        IRepositorioFuncionario
    {
        public RepositorioFuncionarioEmArquivo()
        {
            Semear();
        }

        public bool VerificarPorNome(string nome)
        {
            //LINQ
            //DELEGATE 
            //LAMBDA , expressão anonimo, metodo anonimo
            return _models.Exists(funcionario => funcionario.Nome == nome);
        }

    }
}
