﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjAtividade_3.Models
{
    public class Produtos
    {
        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}