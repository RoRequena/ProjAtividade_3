using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjAtividade_3.Models;
using ProjAtividade_3.Service;
using System.Text;

namespace ProjAtividade_3.Controllers
{
    public class ProcessaProdutoController : Controller
    {
        // GET: ProcessaProduto
        public ActionResult Index()
        {
            return View();
        }

        public static void IncluirProduto(int Tipo, int Id, String Nome, string CaracTipo)
        {
            switch (Tipo)
            {
                case 1: // Caso seja um Shampoo
                    Shampoo sham = new Shampoo(Id, Nome, CaracTipo);
                    CreateRead.IncluirShampoo(sham);
                    break;
                case 2: // Caso seja um Perfume
                    Perfume perf = new Perfume(Id, Nome, CaracTipo);
                    CreateRead.IncluirPerfume(perf);
                    break;
                case 3: // Caso seja um Desodorante
                    Desodorante deso = new Desodorante(Id, Nome, CaracTipo);
                    CreateRead.IncluirDesodorante(deso);
                    break;
            }
               
        }
    }
}