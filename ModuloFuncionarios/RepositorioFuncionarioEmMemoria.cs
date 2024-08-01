using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloFuncionarios
{
    public class RepositorioFuncionarioEmMemoria :
        BaseRepositorioEmMemoria<FuncionarioModel>,
        IRepositorio<FuncionarioModel>,
        IRepositorioFuncionario
    {

        public override void Semear()
        {
            base.ItensRepositorio.Add(new FuncionarioModel()
            {
                Indice = Indice(),
                Nome = "Samsung",
                DataInicio = DateTime.Now,
                Supervisor = "Academia do programador"
            });
        }

        public bool VerificarPorNome(string nome)
        {
            foreach (var funcionario in ItensRepositorio)
            {
                if (funcionario.Nome == nome)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
