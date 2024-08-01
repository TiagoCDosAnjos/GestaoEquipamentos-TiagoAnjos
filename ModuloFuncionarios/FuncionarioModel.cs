using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.WinFormsApp.ModuloFuncionarios
{
    public class FuncionarioModel : BaseModel
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public string Funcao { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Departamento { get; set; }
        public string Supervisor { get; set; }

        public override string Validar()
        {
            string error = string.Empty;
            if (string.IsNullOrEmpty(Nome))
            {
                error += "O campo Nome é obrigatorio";
                return error;
            }
            if (string.IsNullOrEmpty(Supervisor))
            {
                error += " O campo Supervisor é obrigatorio";
                return error;
            }
            if (DataInicio == null)
            {
                error += " O campo Data é obrigatorio";
                return error;
            }
            return error;
        }

        public override string ToString()
        {
            return $"{Nome}, {DataInicio}, {Funcao}, {Email}, {Telefone}, {Departamento}, {Supervisor}";
        }
    }
}
