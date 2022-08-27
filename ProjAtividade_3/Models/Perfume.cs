using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjAtividade_3.Models
{
    public class Perfume: Produtos
    {
        private string aroma;

        public string Aroma { get => aroma; set => aroma = value; }

        public Perfume(int id, string Nome, string Aroma)
        {
            this.Id = id;
            this.Nome = Nome;
            this.aroma = Aroma;
        }
    }
}