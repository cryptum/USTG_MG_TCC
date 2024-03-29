﻿using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("Escolaridades")]
    public  class Escolaridade: EntityBase
    {
        public string Descricao { get; set; }

        public override void Validar()
        {
            _CampoObrigatorio("Descrição", Descricao);
            base.Validar();
        }
    }

    public interface IEscolaridadeRepository : IRepositoryBase<Escolaridade> { }
}
