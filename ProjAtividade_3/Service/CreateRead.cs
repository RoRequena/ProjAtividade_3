using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using ProjAtividade_3.Models;

namespace ProjAtividade_3.Service
{
    public class CreateRead
    {
        private static string PersistirShampoo
        { get{ return HttpContext.Current.Server.MapPath("~/ProdutosShampoo.txt"); } }

        private static string PersistirPerfume
        { get { return HttpContext.Current.Server.MapPath("~/ProdutosPerfume.txt"); } }

        private static string PersistirDesodorante
        { get { return HttpContext.Current.Server.MapPath("~/ProdutosDesodorante.txt"); } }

        public static void IncluirShampoo(Shampoo shampoo)
        {
            using (var escritor = new StreamWriter(PersistirShampoo, true, Encoding.UTF8))
            {
                escritor.WriteLine($"Shampoo: {shampoo.Id}  - {shampoo.Nome} - Sabão: {shampoo.TipoSabao}");
            }
        }

        public static void IncluirPerfume(Perfume perfume)
        {
            using (var escritor = new StreamWriter(PersistirPerfume, true, Encoding.UTF8))
            {
                escritor.WriteLine($"Perfume: {perfume.Id} - {perfume.Nome}  - Aroma: {perfume.Aroma}");
            }
        }

        public static void IncluirDesodorante(Desodorante desodorante)
        {
            using (var escritor = new StreamWriter(PersistirDesodorante, true, Encoding.UTF8))
            {
                escritor.WriteLine($"Desodorante: {desodorante.Id} - {desodorante.Nome} - Aplicação: {desodorante.TipoAplicacao}");
            }
        }

        public static string ObterShampoo()
        {
            if (!File.Exists(PersistirShampoo))
              {  return "Nenhum Shampoo Cadastrado"; }
            using (var leitor = new StreamReader(PersistirShampoo))
              { return leitor.ReadToEnd(); }
        }

        public static string ObterPerfume()
        {
            if (!File.Exists(PersistirPerfume))
            { return "Nenhum Perfume Cadastrado"; }
            using (var leitor = new StreamReader(PersistirPerfume))
            { return leitor.ReadToEnd(); }
        }

        public static string ObterDesodorante()
        {
            if (!File.Exists(PersistirDesodorante))
            { return "Nenhum Desodorante Cadastrado"; }
            using (var leitor = new StreamReader(PersistirDesodorante))
            { return leitor.ReadToEnd(); }
        }

        public static string ContagemProduto(int Tipo)
        {
            int i = 0;
            switch (Tipo)
            {
                case 1: // Caso seja um Shampoo
                    if (File.Exists(PersistirShampoo))
                    {
                        using (var leitor = new StreamReader(PersistirShampoo))
                        {
                            while (leitor.ReadLine() != null) { i++; }
                        }
                    }
                    break;
                case 2: // Caso seja um Perfume
                    if (File.Exists(PersistirPerfume))
                    {
                        using (var leitor = new StreamReader(PersistirPerfume))
                        {
                            while (leitor.ReadLine() != null) { i++; }
                        }
                    }
                    break;
                case 3: // Caso seja um Desodorante
                    if (File.Exists(PersistirDesodorante))
                    {
                        using (var leitor = new StreamReader(PersistirDesodorante))
                        {
                            while (leitor.ReadLine() != null) { i++; }
                        }
                    }
                    break;
            }
            return Convert.ToString(i+1);
        }
    }
}