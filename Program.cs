using System;

namespace passagem
{
    class Program
    {
        static void Main(string[] args)

        { 
             //variaveis
             bool SenhaValida;
             int escolha;
             int contador = 0;
             string resposta;
             //passagens
             string[] nomes = new string [5];
             string[] origem = new string [5];
             string[] destino = new string [5];
             string[] data = new string [5];
             
            
           


            //tema
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------");
            Console.WriteLine("Sistema de Passagens");
            Console.WriteLine("---------------------");

            do{
            //login
            Console.ForegroundColor = ConsoleColor.Cyan;
             Console.WriteLine("*************************************");
            Console.WriteLine("por favor, insira a senha para acessar:");
            Console.WriteLine("*************************************");
              string senha = Console.ReadLine();
              SenhaValida = EfetuarLogin(senha);
            }while(!SenhaValida);


            //menu
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("     Menu Principal");
                Console.WriteLine("Selecione uma das opção abaixo");
                 Console.WriteLine("__________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagem");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("cadastrar passageiro");
                        do
                        {    Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"digite o nome do {contador + 1}° passageiro:");
                            nomes[contador] = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Digite o Destino:");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a origem:");
                            origem[contador] = Console.ReadLine();
                             Console.WriteLine("Digite a data do voo:");
                            data[contador] = Console.ReadLine();


                            contador ++;
                             Console.ForegroundColor = ConsoleColor.Blue;
                             Console.WriteLine("gostaria de cadastrar um novo passageiro? S/N");
                             resposta = Console.ReadLine();
                        } while (resposta.ToUpper() == "S");
                        Console.Clear();
                        break;
                    //---------------------------------------------------------------
                    //---------------------------------------------------------------

                        case 2:

                        for (var i = 0; i < contador; i++)
                        {
                             Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Passageiro: {nomes[i]} ------------ data do voo: {data[i]}");
                            
                            
                        }
                    
                        break;
                    //---------------------------------------------------------------
                        case 0:
                           Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("obrigado por viagar com a nossa agencia");
                        break;
                    //-----------------------------------------------------------------

                    default:
                               Console.WriteLine("opção inválida!!!");
                        break;
                    //-----------------------------------------------------------
                }//fim do "do"
                


            } while (escolha != 0);






            //funções
            bool EfetuarLogin( string senha ){
                if (senha == "12345"){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("senha correta, bem vindo ao sistema de passagens");
                    return true;
                }else{
                   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("senha inválida, tente novamente!");
                     return false;
                }
            }//fim do if

            }



            
            


        }
    }

