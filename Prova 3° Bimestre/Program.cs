using Prova_3__Bimestre.Classes;

public class Program
{
	static void Main(string[] args)
	{
		List<Funcionario> listafuncionario = new List<Funcionario>();
		List<Medico> listamedico = new List<Medico>();
		List<Administrativo> listaadministrativo = new List<Administrativo>();
		while(true)
		{
			Console.WriteLine("Escolha uma opção. \n" +
				"0-Sair. \n" +
				"1-Cadastrar Funcionário. \n" +
				"2-Imprimir listas de funcionários.");

			int opcao = Convert.ToInt32(Console.ReadLine());

			if(opcao== 0)
			{
				goto exit;
			}
			else if(opcao == 1)
			{
				Console.WriteLine("Qual tipo de funcionário deseja cadastrar? \n" +
					"1-Normal. \n" +
					"2-Médico. \n" +
					"3-Administrativo");
				int opcaofun = Convert.ToInt32(Console.ReadLine());

				if(opcaofun == 1)
				{
					Funcionario funcionario = new Funcionario();
					Console.WriteLine("Digite o nome:");
					funcionario.Nome = Console.ReadLine();
					Console.WriteLine("Digite o CPF:");
					funcionario.Cpf = Console.ReadLine();
					Console.WriteLine("Digite o número de Matrícula: ");
					funcionario.Matricula = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Digite a data de nascimento:");
					funcionario.Datanascimento = Convert.ToDateTime(Console.ReadLine());
					Console.WriteLine("Digite o sexo:");
					funcionario.Sexo = Console.ReadLine();
					Console.WriteLine("Digite o Salário:");
					funcionario.Salario = Convert.ToDouble(Console.ReadLine());

					listafuncionario.Add(funcionario);
				}
				else if(opcaofun == 2)
				{
                    Medico medico = new Medico();
                    Console.WriteLine("Digite o nome:");
                    medico.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o CPF:");
                    medico.Cpf = Console.ReadLine();
                    Console.WriteLine("Digite o número de Matrícula: ");
                    medico.Matricula = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a data de nascimento:");
                    medico.Datanascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o sexo:");
                    medico.Sexo = Console.ReadLine();
                    Console.WriteLine("Digite o Salário:");
                    medico.Salario = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Digite a CRM:");
					medico.CRM = Console.ReadLine();
					Console.WriteLine("Digite o valor da hora extra:");
					medico.Valorhoraextra = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Digite a Especialidade:");
					medico.Especialidade = Console.ReadLine();

					listamedico.Add(medico);

					
                }
				else if(opcaofun == 3)
				{
                    Administrativo administrativo = new Administrativo();
                    Console.WriteLine("Digite o nome:");
                    administrativo.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o CPF:");
                    administrativo.Cpf = Console.ReadLine();
                    Console.WriteLine("Digite o número de Matrícula: ");
                    administrativo.Matricula = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a data de nascimento:");
                    administrativo.Datanascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o sexo:");
					administrativo.Sexo = Console.ReadLine();
                    Console.WriteLine("Digite o Salário:");
                    administrativo.Salario = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Digite a função:");
					administrativo.Funcao = Console.ReadLine();

					listaadministrativo.Add(administrativo);
                }
				else
				{
					Console.WriteLine("Opção Inválida!");
				}
			}
            else if (opcao == 2)
            {
				Console.WriteLine("Funcionários:");
                foreach (Funcionario f in listafuncionario)
                {
                    Console.WriteLine($"{f.Nome}\n{f.Cpf}\n{f.Matricula}\n{f.Datanascimento}\n{f.Sexo}\n{f.Salario}");
                }

				Console.WriteLine("Médicos: ");
				foreach (Medico m in listamedico)
				{
					Console.WriteLine($"{m.Nome}\n{m.Cpf}\n{m.Matricula}\n{m.Datanascimento}\n{m.Sexo}\n{m.Salario}\n{m.CRM}\n{m.Valorhoraextra}\n{m.Especialidade}");
				}

				Console.WriteLine("Funcionários Administrativos:");
				foreach (Administrativo a in listaadministrativo)
				{
					Console.WriteLine($"{a.Nome}\n{a.Cpf}\n{a.Matricula}\n{a.Datanascimento}\n{a.Sexo}\n{a.Salario}\n{a.Funcao}");
				}
            }
            else
			{
				Console.WriteLine("Opção Inválida!");
			}
		}exit:;
	}
}


