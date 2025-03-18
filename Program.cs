using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Aula03Colecoes.Models;
using Aula03Colecoes.Models.Enuns;

namespace Aula03Colecoes
{
    public class Program
    {
        static List<Funcionario> lista = new List<Funcionario>();
        static void Main(string[] args)
        {
            CriarLista();
            ExemplosListasColecoes();
        }

    
    public static void ExemplosListasColecoes()
    {
    Console.WriteLine("==================================================");  
    Console.WriteLine("****** Exemplos - Aula 03 Listas e Coleções ******");  
    Console.WriteLine("==================================================");  
    CriarLista();
    int opcaoEscolhida = 0;
    do
    {
        Console.WriteLine("=================================================="); 
        Console.WriteLine("---Digite o número referente a opção desejada: ---");  
        Console.WriteLine("1 - Obter Por Id");
        Console.WriteLine("2 - Adicionar funcionario");
        Console.WriteLine("3 - Obter por Id digitado");
        Console.WriteLine("4 - Obter por salário digitado");
        Console.WriteLine("5 - Ordenar");
        Console.WriteLine("6 - Contar funcionario");
        Console.WriteLine("7 - Somar salario");
        Console.WriteLine("8 - Exibir aprendizes");
        Console.WriteLine("9 - Obter por nome aproximado");
        Console.WriteLine("10 - Buscar por CPF e remover");
        Console.WriteLine("11 - Remover Id menor a 4");
        Console.WriteLine("12 - Obter por nome");
        Console.WriteLine("13 - Obter por funcionarios recentes");
        Console.WriteLine("14 - Obter estatistica de salarios");
        Console.WriteLine("15 -  Obter por tipo de Funcionario.");
        Console.WriteLine("==================================================");  
        Console.WriteLine("-----Ou tecle qualquer outro número para sair-----");  
        Console.WriteLine("==================================================");  

        opcaoEscolhida = int.Parse(Console.ReadLine());
        string mensagem = string.Empty;
        switch (opcaoEscolhida)
            {
                case 1:
                    ObterPorId();
                    break;
                case 2:
                    AdicionarFuncionario();
                    break;
                case 3:
                    Console.WriteLine("Digite o ID do funcionário que você deseja buscar");
                    int id = int.Parse(Console.ReadLine());
                    ObterPorIdDigitado(id);
                    break;
                case 4: 
                    Console.WriteLine("Digite o salrio para obter todos acima do valor digitado");
                    decimal salario = decimal.Parse(Console.ReadLine());
                    ObterPorSalario(salario);
                    break;
                case 5: 
                    Ordenar();
                    break;
                case 6:
                    ContarFuncionario();
                    break;
                case 7:
                    SomarSalario();
                    break;
                case 8:
                    ExibirAprendizes();
                    break;
                case 9:
                    BuscarPorNomeAproximado();
                    break;
                case 10:
                    BuscarPorCpfRemover();
                    break;
                case 11:
                    RemoverIdMenor4();
                    break;
                case 12:
                    ObterPorNome();
                    break;
                case 13:
                    ObterFuncionariosRecentes();
                    break;
                case 14:
                    ObterEstatisticas();
                    break;
                case 15:
                    ObterPorTipo();
                    break;
                default:
                    Console.WriteLine("Saindo do sistema....");
                    break;
            }
    } while (opcaoEscolhida >= 1 && opcaoEscolhida <= 15);

    Console.WriteLine("==================================================");  
    Console.WriteLine("* Obrigado por utilizar o sistema e volte sempre *");  
    Console.WriteLine("==================================================");  
    }


        public static void ExibirLista()
    {
        string dados = "";
        for (int i = 0; i < lista.Count; i++)
        {
            dados += "===============================\n";
            dados += string.Format("Id: {0} \n", lista[i].Id);
            dados += string.Format("Nome: {0} \n", lista[i].Nome);
            dados += string.Format("CPF: {0} \n", lista[i].Cpf);
            dados += string.Format("Admissão: {0:dd/MM/yyyy} \n", lista[i].DataAdmissao);
            dados += string.Format("Salário: {0:c2} \n", lista[i].Salario);
            dados += string.Format("Tipo: {0} \n", lista[i].TipoFuncionario);
            dados += "===============================\n";
        }
        Console.WriteLine(dados);
    }
        public static void  CriarLista()
        {
            Funcionario f1 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Neymar";
            f1.Cpf = "12345678910";
            f1.DataAdmissao = DateTime.Parse("01/01/2000");
            f1.Salario = 150.000M;
            f1.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f1);

            Funcionario f2 = new Funcionario();
            f2.Id = 2;
            f2.Nome = "Cristiano Ronaldo";
            f2.Cpf = "01987654321";
            f2.DataAdmissao = DateTime.Parse("30/06/2002");
            f2.Salario = 150.000M;
            f2.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f2);

            Funcionario f3 = new Funcionario();
            f3.Id = 3;
            f3.Nome = "Messi";
            f3.Cpf = "135792468";
            f3.DataAdmissao = DateTime.Parse("01/11/2003");
            f3.Salario = 70.000M;
            f3.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            lista.Add(f3);

            Funcionario f4 = new Funcionario();
            f4.Id = 4;
            f4.Nome = "Mbappe";
            f4.Cpf = "246813579";
            f4.DataAdmissao = DateTime.Parse("15/09/2005");
            f4.Salario = 80.000M;
            f4.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            lista.Add(f4);
            
            Funcionario f5 = new Funcionario();
            f5.Id = 5;
            f5.Nome = "Lewa";
            f5.Cpf = "246813579";
            f5.DataAdmissao = DateTime.Parse("20/10/1998");
            f5.Salario = 90.000M;
            f5.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            lista.Add(f5);
            
            Funcionario f6 = new Funcionario();
            f6.Id = 6;
            f6.Nome = "Rodrigo Garro";
            f6.Cpf = "246813579";
            f6.DataAdmissao = DateTime.Parse("13/12/1997");
            f6.Salario = 300.000M;
            f6.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f6);
        }

        public static void ObterPorId()
        {
            lista = lista.FindAll(x => x.Id == 4); // FindAll metodo que vai retornar todos e depois a condição retorne iguais a 1
            ExibirLista();
        }

        public static void AdicionarFuncionario()
        {
            Funcionario f = new Funcionario();
            
            Console.WriteLine("Digite o nome: ");
            f.Nome = Console.ReadLine();

             if (string.IsNullOrWhiteSpace(f.Nome))
            {
                Console.WriteLine("****O campo Nome deve ser prenchido****");
                return ;
            }
            else if(f.Nome.Length < 2 )
            {
                Console.WriteLine("**** Precisa ter no minimo 2 letras!****");
                return;
            }

            Console.WriteLine("Digite o salario: ");
            f.Salario = decimal.Parse(Console.ReadLine());
            if(f.Salario ==0)
                Console.WriteLine("****O salario não pode ser 0 (Zero)!!****");

            Console.WriteLine("Digite a data de admissão: ");
            f.DataAdmissao = DateTime.Parse(Console.ReadLine());

            if(f.DataAdmissao.Date < DateTime.Now.Date)
                {
                    Console.WriteLine("Data invalida!");
                }
            else
            {
                lista.Add(f);
                ExibirLista();
            }          
        }

        public static void ObterPorIdDigitado(int id)
        {
            Funcionario fbusca = lista.Find(x => x.Id == id);

            Console.WriteLine($"Personagem encontrado: {fbusca.Nome}");
        }

        public static void ObterPorSalario(decimal valor)
        { 
            lista = lista.FindAll(x => x.Salario >= valor);
            ExibirLista();
        }
        public static void Ordenar()
        {
            lista = lista.OrderBy(x => x.Nome).ToList();
            ExibirLista();
        }

        public static void ContarFuncionario()
        {
            int qtd = lista.Count();
            Console.WriteLine($"Existem {qtd} funcionario.");
        }

        public static void SomarSalario()
        {
            decimal somatorio = lista.Sum(x=> x.Salario);
            Console.WriteLine(string.Format("A soma dos salários é {0:c2}."));
        }

        public static void ExibirAprendizes()
        {
            lista = lista.FindAll(x => x.TipoFuncionario == TipoFuncionarioEnum.Aprendiz);
            ExibirLista();
        }

        public static void BuscarPorNomeAproximado()
        {
      

            lista = lista.FindAll(x => x.Nome.ToLower().Contains("ronaldo"));
            ExibirLista();
        }

        public static void BuscarPorCpfRemover()
        {
            Funcionario fBusca = lista.Find( x => x.Cpf == "01987654321");
            lista.Remove(fBusca);
            Console.WriteLine($"Personagem removido: {fBusca.Nome} \nLista Atualizada:\n");

            ExibirLista();
        }

        public static void RemoverIdMenor4()
        {
            
            lista.RemoveAll( x => x.Id <4);
            ExibirLista();
        }

        public static void ObterPorNome()
        {
            Funcionario f = new Funcionario();
            
            Console.WriteLine("Escreva o nome:");
            string nome = Console.ReadLine();

            if(nome.Equals(f.Nome))
            {
                Console.WriteLine("errou");
            }
            else
            {
                Console.WriteLine("O nome é: "+ f.Nome);
            }

        }

        public static void ObterFuncionariosRecentes()
        {
             Funcionario f = new Funcionario();
            lista.RemoveAll( x => x.Id <4);
            var listDecr = lista.OrderByDescending(f => f.Salario).ToList();
            lista = listDecr;

            ExibirLista();
        }

        public static void  ObterEstatisticas()
        {
           Funcionario f = new Funcionario();
            Console.WriteLine("====================================");
            int quantidadeFuncionarios = lista.Count();
            decimal somaTotSal = lista.Sum(f => f.Salario);

            Console.WriteLine($"A ao todo {quantidadeFuncionarios} funcionarios, e a soma Total de Salário é : {somaTotSal}.");
        }

        public static void ObterPorTipo()
        {
            Console.WriteLine("1 - Funcionario CLT");
            Console.WriteLine("2 - Funcionario Aprendiz");
            decimal tipo = int.Parse(Console.ReadLine());
          if( tipo == 1)
          {
            var funcionarioClt = lista.FindAll(f => f.TipoFuncionario == TipoFuncionarioEnum.CLT).ToList();
            lista = funcionarioClt;
            ExibirLista(); 
          }
          else
          {
             var funcionarioApren = lista.FindAll(f => f.TipoFuncionario == TipoFuncionarioEnum.Aprendiz).ToList();
            lista = funcionarioApren;
            ExibirLista(); 
          }
        }



        
    }
}