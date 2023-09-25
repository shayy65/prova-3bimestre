using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3__Bimestre.Classes
{
    internal class Medico : Funcionario
    {
        public string CRM { get; set; }
        public double Valorhoraextra { get; set; }
        public string Especialidade { get; set; }

        public Medico() { }

        public Medico(string crm, double valorhoraextra,string especialidade, string nome, string cpf, int matricula, DateTime datanascimento, string sexo, double salario) 
            : base (nome, cpf, matricula, datanascimento, sexo, salario)
        {
            CRM = nome;
            Valorhoraextra = valorhoraextra;
            Especialidade = especialidade;
        }

        public void Auxilío()
        {
            double auxilio = 0.20 * Salario;
            Salario += auxilio;
        }
    }
}
