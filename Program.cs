using System;
using ProjetoEvento;
using ProjetoEvento.ClassePai;
using ProjetoEvento.ClassePai.ClassesFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 9;
            do{
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Shows");
                Console.WriteLine("2 - Teatro");
                Console.WriteLine("3 - Cinema");
                Console.WriteLine("9 - Sair");
                opcao = Int16.Parse(Console.ReadLine());
            } while(opcao != 9 );
            
            switch(opcao){
                case 1: MenuShow(); break;
                case 2: Teatro(); break;
                case 3: Cinema(); break;
                case 9: Environment.Exit(0); break;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        }

        static void MenuShow(){
            int opcao = 9;
            do{
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 - Cadastrar Show");
                Console.WriteLine("2 - Pesquisar Show");
                Console.WriteLine("9 - Voltar");
            } while(opcao != 9);

            switch (opcao)
            {
                case 1: Show show = iniciarDadosShow();
                        show.Cadastrar();
                        break;
                case 2: 
                        break;
                case 9: 
                        break;
                default: Console.WriteLine("Opção inválida!");
                        break;
            }
        }
        static Show iniciarDadosShow(){
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

        static void Teatro(){

        }

        static void Cinema(){

        }

    }
}