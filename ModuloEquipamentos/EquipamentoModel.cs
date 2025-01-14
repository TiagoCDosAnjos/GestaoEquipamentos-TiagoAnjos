﻿using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;

namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public class EquipamentoModel : BaseModel
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string NumeroDeSerie { get; set; }
        public DateTime DataDeFabricacao { get; set; }
        public string Fabricante { get; set; }
        public DateTime DataUltimaManutencao { get; set; }
        //public int IndiceTipoDeEquipamento { get; set; }
        public virtual TipoDeEquipamentoModel TipoDeEquipamento { get; set; }
        public override string Validar()
        {
            //TODO: Rever todas as regras.
            string error = string.Empty;

            if (string.IsNullOrEmpty(Nome) || Nome.Length < 6)
            {
                error += "Nome inválido deve ter no minimo 6 caracteres.";
            }

            if (string.IsNullOrEmpty(NumeroDeSerie))
            {
                error += "Número de série é obrigatorio.";
            }
            return error;
        }
    }
}
