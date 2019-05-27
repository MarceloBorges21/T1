using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Produto() {Nome = "Suco de frutas", Categoria = "Bebidas", PrecoUnitario = 1.00, Unidade = "Litros" };
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario =7.80, Unidade = "Gramas" };
            var p3 = new Produto() { Nome = "Bolacha", Categoria = "Alimento", PrecoUnitario = 2.00, Unidade = "Gramas" };

            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);


            using (var contexto = new LojaContext())
            {
                var promocao = contexto.Promocoes.Find(3);

                contexto.Promocoes.Remove(promocao);

                ExibeEntries(contexto.ChangeTracker.Entries());

               // contexto.SaveChanges();
               
            }

			Console.ReadKey();
        }

		private static void ExibeEntries(IEnumerable<EntityEntry> entries)
		{
			Console.WriteLine("======================");
			foreach (var e in entries)
			{
				Console.WriteLine(e.Entity.ToString() + " - " + e.State);
			}
		}
	}
}
