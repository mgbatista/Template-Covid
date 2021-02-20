using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirecionamentoCovid_Template
{
    class Program
    {
        static void Main(string[] args)
        {
			//FilaOS minhaFila = new FilaOS { Head = null, Tail = null, Cont = 0 };

			int op, senha = 0;

			do
			{
				Console.WriteLine("\n>>> MENU <<<\n"
					+ "1 - Retirar Senha\n"
					+ "2 - Realizar Triagem\n"
					+ "3 - Resultados do exame\n"
					+ "4 - Internar paciente\n"
					+ "5 - Dar Alta\n"
					+ "0 - Sair");
				Console.Write("\nInforme a opcao desejada: ");
				op = int.Parse(Console.ReadLine());



				switch (op)
				{
					case 1:
						RetirarSenha(ref senha);
						break;
					case 2:
						

						//minhaFila.Pop();
						break;
					case 3:
						
						//Result exame
						//minhaFila.Print();
						break;
					case 4:
						//Internar paciente

						break;
					case 5:
						//dar Alta
						break;
					case 0:
						break;
				}
			} while (op != 0);

			Console.ReadKey();
		}


		static public void RetirarSenha(ref int senha)
        {
			
            Console.WriteLine("RETIRE SUA SENHA");
            Console.WriteLine("1- Atendimento Preferêncial(60 anos ou mais)");
            Console.WriteLine("2- Atendimento Comum");
			int tipoAtendimento = int.Parse(Console.ReadLine());
			
			if(tipoAtendimento == 1)
            {
				minhafilapreferencial.push(senha);
            }
            else
            {
				minhafilacomum.push(senha);
            }
			senha++;
        }

		static public void ChamarSenha()
        {
			// chamar pessoa FilaPreferencial (2)
			// chamar pessoa Filacomum (1)
        }

		static public void RealizarTriagem()
        {
			Pessoa p = new Pessoa();
			ChamarSenha();
            Console.Write("Cadastre o paciente:");
			Console.Write("Nome do paciente: ");
			p.Nome = Console.ReadLine();
			Console.Write("Idade: ");
			p.Idade = int.Parse(Console.ReadLine());
			Console.Write("Sexo: ");
			p.Sexo = Console.ReadLine();
			Console.Write("CPF: ");
			p.Cpf = int.Parse(Console.ReadLine());
			Console.Write("Carteira de vacinação: ");
			p.CarteiraVacin = long.Parse(Console.ReadLine());
			Console.Write("Telefone: ");
			p.Telefone = int.Parse(Console.ReadLine());
            Console.Write("Tempo de sintomas: ");
			p.TempoDeSintomas = int.Parse(Console.ReadLine());
			Console.Write("Tem comorbidade?: ");
			p.Comorbidade = Console.ReadLine();

			p.ResultadoExame = Triagem.Exame();

			if(p.ResultadoExame == 1 && p.Idade >= 60)
            {
				minhaFilaRisco.push();
            }else

			//minhaFila.Push(p);
		}




	}
}
