using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjAtividade_3.Models
{
    public class Shampoo: Produtos
    {
        private string tipoSabao;

        public string TipoSabao { get => tipoSabao; set => tipoSabao = value; }

        public Shampoo(int id, string Nome, string TipoSabao)
        {
            this.Id = id;
            this.Nome = Nome;
            this.tipoSabao = TipoSabao;
        }
    }
}