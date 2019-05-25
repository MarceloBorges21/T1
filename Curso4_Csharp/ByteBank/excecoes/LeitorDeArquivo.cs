using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.excecoes
{
	class LeitorDeArquivo : IOException
	{
		public string Arquivo { get; }

		public LeitorDeArquivo(string arquivo)
		{
			Arquivo = arquivo;

			
			Console.WriteLine("Abrindo arquivo: " + arquivo);
		}

		public string LerProximaLinha()
		{
			Console.WriteLine("Lendo linha. . .");

			throw new IOException();
		}

		public void Dispose()
		{
			Console.WriteLine("Fechando arquivo.");
		}
	}
}
