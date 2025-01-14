﻿using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public class RepositorioEquipamentos : BaseRepositorioEmMemoria<EquipamentoModel>
    {
        public RepositorioEquipamentos()
        {
        }

        public override void Semear()
        {
            ItensRepositorio.Add(
                new EquipamentoModel()
                {
                    DataDeFabricacao = new DateTime(2020, 12, 09),
                    DataUltimaManutencao = new DateTime(2020, 12, 09),
                    Fabricante = "HP",
                    Nome = "Laserjet J6545",
                    Numero = 1,
                    NumeroDeSerie = "123456789",
                    Preco = 1000,
                    Indice = Indice()
                });

            ItensRepositorio.Add(new EquipamentoModel()
            {
                DataDeFabricacao = new DateTime(2021, 12, 09),
                DataUltimaManutencao = new DateTime(2021, 12, 09),
                Fabricante = "SAMSUNG",
                Nome = "S21",
                Numero = 2,
                NumeroDeSerie = "987654321",//MEI
                Preco = 5000,
                Indice = Indice()
            });

            ItensRepositorio.Add(new EquipamentoModel()
            {
                DataDeFabricacao = new DateTime(2021, 12, 09),
                DataUltimaManutencao = new DateTime(2021, 12, 09),
                Fabricante = "LEX",
                Nome = "SSS",
                Numero = 2,
                NumeroDeSerie = "987654321",//MEI
                Preco = 5000,
                Indice = Indice()
            });
        }
    }
}
