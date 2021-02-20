using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirecionamentoCovid_Template
{
    class Pessoa
    {
		public string Nome { get; set; }
		public int Idade { get; set; }
		public string Sexo { get; set; }
		public long Cpf { get; set; }
		public long CarteiraVacin { get; set; }
		public int Telefone { get; set; }
		public int TempoDeSintomas { get; set; }
		public string Comorbidade { get; set; }
		public int ResultadoExame { get; set; }
		public Pessoa Proximo { get; set; }

		public override string ToString()
		{
			return ">>>>>>> Dados do Paciente <<<<<<\nNome: " + Nome +
				"\nIdade: " + Idade + "\nSexo: " + Sexo +
				"\nCPF: " + Cpf + "\nCarteira de Vacinação: " + CarteiraVacin +
				"\nComorbidade: " + Comorbidade + "\nTempo de Sintomas: " + TempoDeSintomas +
				"\nPositivo: " + Positivo;
		}

	}
}
