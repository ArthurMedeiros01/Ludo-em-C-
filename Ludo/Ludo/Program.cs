using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ludo;

class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Selecione a quantidade de jogadores: \nDigite 2 Caso jogue com 2 jogadores e 4 caso jogue com 4 jogadores");
        int quantJogadores = int.Parse(Console.ReadLine());
        if (quantJogadores == 2)
        {
            Console.WriteLine("Digite o nome do jogador da cor vermelha");
            string nome1 = Console.ReadLine();
            Jogador jogador1 = new Jogador("vermelho", 0, nome1);

            Console.WriteLine("Digite o nome do jogador da cor amarela");
            string nome2 = Console.ReadLine();
            Jogador jogador3 = new Jogador("Amarelo", 2, nome2);


            Jogador jogador2 = new Jogador("´Verde", 1, "...");
            Jogador jogador4 = new Jogador("Azul", 3, "...");

            Tabuleiro ludo = new Tabuleiro(jogador1, jogador3, quantJogadores);

            while (jogador1.Vitoria() == false || jogador3.Vitoria() == false)
            {
                for (int i = 0; i < 4; i += 2)
                {
                    ludo.VerificarCaptura(ludo.jogadores[i].identificador, ludo.jogadores[i].peoes[i].identificador);
                }
                Console.ReadLine();
            }
        }
        else if (quantJogadores == 4)
        {
            Console.WriteLine("Digite o nome do jogador da cor vermelha");
            string nome1 = Console.ReadLine();
            Jogador jogador1 = new Jogador("vermelho", 0, nome1);

            Console.WriteLine("Digite o nome do jogador da cor verde");
            string nome2 = Console.ReadLine();
            Jogador jogador2 = new Jogador("Verde", 1, nome2);

            Console.WriteLine("Digite o nome do jogador da cor amarelo");
            string nome3 = Console.ReadLine();
            Jogador jogador3 = new Jogador("Amarelo", 1, nome3);

            Console.WriteLine("Digite o nome do jogador da cor azul");
            string nome4 = Console.ReadLine();
            Jogador jogador4 = new Jogador("Azul", 1, nome4);

            Tabuleiro ludo = new Tabuleiro(jogador1, jogador2, jogador3, jogador4, quantJogadores);

            //Partida 4 jogadores
            while (ludo.jogadores[0].Vitoria() == false || ludo.jogadores[1].Vitoria() == false || ludo.jogadores[2].Vitoria() == false || ludo.jogadores[3].Vitoria() == false)
            {
                for (int i = 0; i < ludo.jogadores.Length; i++)
                {
                    Console.WriteLine($"Vez do jogador {ludo.jogadores[i].nome} ({ludo.jogadores[i].cor})");
                    ludo.jogadores[i].LancarDados();

                    ludo.jogadores[0].Vitoria();
                    ludo.jogadores[1].Vitoria();
                    ludo.jogadores[2].Vitoria();
                    ludo.jogadores[3].Vitoria();
                }
            }

        }
        else
        {
            Console.WriteLine("Quantidade de jogadores inválida");
        }


    }
}
