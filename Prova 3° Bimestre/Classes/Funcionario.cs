using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3__Bimestre.Classes
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Matricula { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, string cpf, int matricula, DateTime datanascimento, string sexo, double salario) 
        {
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            Datanascimento = datanascimento;
            Sexo = sexo;
            Salario= salario;
        }

    }
}
