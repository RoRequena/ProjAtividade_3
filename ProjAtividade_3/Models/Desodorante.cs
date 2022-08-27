using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjAtividade_3.Models
{
    public class Desodorante: Produtos
    {
        private string tipoAplicacao;

        public string TipoAplicacao { get => tipoAplicacao; set => tipoAplicacao = value; }

        public Desodorante(int id, string Nome, string Tipo)
        {
            this.Id = id;
            this.Nome = Nome;
            this.TipoAplicacao = Tipo;
        }
    }
}