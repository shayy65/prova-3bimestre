using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3__Bimestre.Classes
{
    internal class Administrativo : Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo() { }

        public Administrativo(string funcao, string nome, string cpf, int matricula, DateTime datanascimento, string sexo, double salario) 
            : base (nome, cpf, matricula, datanascimento, sexo, salario)
        {
            Funcao = funcao;
        }

        public void Auxilío(double salario)
        {
            double auxilio = salario + 150 + (0.17 * salario);

            Salario += auxilio;
        }

    }
}
