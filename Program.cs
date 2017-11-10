using System;
using System.Collections.Generic;
using ProjetoEvento.ClassePai.ClassesFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int opcao = 9;
            do{
                //Console.Clear();
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Shows");
                Console.WriteLine("2 - Teatro");
                Console.WriteLine("3 - Cinema");
                Console.WriteLine("9 - Sair");
                Console.Write("Digite o número da opção: ");
                opcao = Int16.Parse(Console.ReadLine());

                switch(opcao){
                    case 1: MenuShow(); break;
                    case 2: MenuTeatro(); break;
                    case 3: MenuCinema(); break;
                    case 9: Environment.Exit(0); break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            } while(opcao != 9 );
        }

        static void MenuShow(){
            int opcao = 9;
            do{
                //Console.Clear();
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 - Cadastrar Show");
                Console.WriteLine("2 - Pesquisar Show pelo Título");
                Console.WriteLine("3 - Pesquisar Show pela Data");
                Console.WriteLine("9 - Voltar\n");

                Console.Write("Digite o número da opção: ");
                opcao = Int16.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1: { 
                        Show show = iniciarDadosShow();
                        bool cadastroSucesso = show.Cadastrar();
                        if(cadastroSucesso){
                            Console.WriteLine("Show cadastrado com sucesso!");
                        } else {
                            Console.WriteLine("ERRO: O show não foi cadastrado...");
                        }
                        break;
                    }
                    case 2: {
                        Console.Write("Digite o título do show: ");
                        string titulo = Console.ReadLine();
                        Show show = new Show();
                        string resultado = show.Pesquisar(titulo);
                        Console.WriteLine(resultado);
                        break;
                    }
                    case 3: {
                        Console.Write("Digite a data do show: ");
                        DateTime data = DateTime.Parse(Console.ReadLine());
                        Show show = new Show();
                        List<string> resultado = show.Pesquisar(data);
                        Console.WriteLine(resultado);
                        break;
                    }
                    case 9: {
                        break;
                    }
                    default: {
                        Console.WriteLine("Opção inválida!");
                        break;
                    }
                }
            } while(opcao != 9);
        }
        static Show iniciarDadosShow(){
            //Console.Clear();
            Console.WriteLine("Cadastro do Show:");
            Console.Write("Digite o Título do Show: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o Local do Show: ");
            string local = Console.ReadLine();
            Console.Write("Digite a Lotação do Show: ");
            int lotacao = int.Parse(Console.ReadLine());
            Console.Write("Digite a Duração do Show: ");
            string duracao = Console.ReadLine();
            Console.Write("Digite a Classificação do Show (Idade indicativa): ");
            int classificacao = Int16.Parse(Console.ReadLine());
            Console.Write("Digite a Data do Show: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o nome do Artista ou Banda do Show: ");
            string artista = Console.ReadLine();
            Console.Write("Digite o Gênero do Show: ");
            string generoMusical = Console.ReadLine();

            Show show = new Show(titulo, local, lotacao, duracao, classificacao, data, artista, generoMusical);
            return show;
        }

        static void MenuTeatro(){

        }

        static void MenuCinema(){

        }
    }
}