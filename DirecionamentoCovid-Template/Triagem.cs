using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirecionamentoCovid_Template
{
    class Triagem
    {
		public Pessoa DadosPessoas { get; set; }

		/*public void Cadastramento()
		{
			Console.Write("Paciente tem alguma comorbidade?: ");
			bool comorbidade = bool.Parse(Console.ReadLine());
			Console.Write("Quanto tempo está com o sintomas?: ");
			int tempo = int.Parse(Console.ReadLine()); 
			Pessoa p = new Pessoa
			{
				Comorbidade = comorbidade,
				TempoDeSintomas = tempo
			};
		}*/

		static public int Exame()
		{
			int resultado;
			Console.WriteLine("Coletando amostras para exame!!");
			Console.WriteLine("Processando exame... aguarde!");
			Console.WriteLine("Menu para resultados de exame: ");
			do
			{
				Console.WriteLine("1 - Positivo Sintomatico ");
				Console.WriteLine("2 - Positivo Assintomatico");
				Console.WriteLine("3 - Negativo");
				resultado = int.Parse(Console.ReadLine());
				Console.Write("Digite de 1 a 3 para inserir possiveis resultados do exame: ");
			} while ((resultado > 0) && (resultado < 4));

			if (resultado == 1)
				return 1;
			else if (resultado == 2)
				return 2;
			else
				return 3;

		}
	}
}
