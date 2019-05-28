using Microsoft.EntityFrameworkCore;
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
            using (var contexto = new LojaContext())
            {
                var cliente = contexto
                    .Clientes
                    .Include(e => e.EnderecoDeEntrega)
                    .FirstOrDefault();

                Console.WriteLine($"Endereço de entrga: {cliente.EnderecoDeEntrega.Logradouro}");


                var produto = contexto
                             .Produtos
                             .Where(p => p.Id == 2004)
                             .FirstOrDefault();

                contexto.Entry(produto)
                    .Collection(p => p.Compras)
                    .Query()
                    .Where(c => c.Preco > 10)
                    .Load();

                Console.WriteLine($"Mostrando as compras do produto {produto.Nome}");
                foreach (var item in produto.Compras)
                {
                    Console.WriteLine(item);
                }

            }

            Console.ReadKey();
        }

        private static void ExibeProdutosPromocao()
        {
            using (var contexto2 = new LojaContext())
            {
                var promocao = contexto2
                               .Promocoes
                               .Include(p => p.Produtos)
                               .ThenInclude(pp => pp.Produto)
                               .FirstOrDefault();

                Console.WriteLine("\nMostrando os produtos da promoção..");

                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }

        public static void IncluiUmaPromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima Total Janeiro 2017";
                promocao.DataInicio = new DateTime(2017, 1, 1);
                promocao.DataTermino = new DateTime(2017, 1, 31);

                var produtos = contexto.Produtos
                    .Where(p => p.Categoria == "Bebidas").ToList();

                foreach (var item in produtos)
                {
                    promocao.IncluiProduto(item);
                }
                contexto.Promocoes.Add(promocao);

                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.SaveChanges();
            }
        }

        public static void UmParaUm()
        {
            var fulano = new Cliente();
            fulano.Nome = "Fulano";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua do tal",
                Complemento = "Apartamento",
                Bairro = "Centro",
                Cidade = "Blumenau"
            };
            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();

                ExibeEntries(contexto.ChangeTracker.Entries());

            }
        }
           


        private static void MuitosParaMuitos()
        {
            var p1 = new Produto() { Nome = "Suco de frutas", Categoria = "Bebidas", PrecoUnitario = 1.00, Unidade = "Litros" };
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 7.80, Unidade = "Gramas" };
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
                var promocao = contexto.Promocoes.Find(1);

                contexto.Promocoes.Remove(promocao);

                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.SaveChanges();

            }
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
