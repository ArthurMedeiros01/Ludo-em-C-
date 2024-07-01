using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ludo;

class program
{
    static void Main(string[] args)
    {
        static StreamWriter arq = new StreamWriter("LogDaPartida.txt", false, Encoding.UTF8);

        Console.WriteLine("Selecione a quantidade de jogadores: \nDigite 2 Caso jogue com 2 jogadores e 4 caso jogue com 4 jogadores");
        int quantJogadores = int.Parse(Console.ReadLine());
        
        if (quantJogadores == 4 || quantJogadores == 2)
        {
            string nome
            for (int c = 0; c < quantJogadores; c++)
            {
            Console.WriteLine("Digite o nome do jogador " + c);
            string nome = Console.ReadLine();
            Jogador jogador1 = new Jogador("vermelho", c, nome);
            }
            Tabuleiro ludo = new Tabuleiro(jogador1, jogador2, jogador3, jogador4, quantJogadores);

            Tabuleiro ludo = new Tabuleiro(jogador1, jogador3, quantJogadores);

            //Partida 4 jogadores
            while (ludo.jogadores[0].Vitoria() == false || ludo.jogadores[1].Vitoria() == false || ludo.jogadores[2].Vitoria() == false || ludo.jogadores[3].Vitoria() == false)
            {
                for (int i = 0; i < ludo.jogadores.Length; i++)
                {
                    Console.WriteLine($"Vez do jogador {ludo.jogadores[i].nome} ({ludo.jogadores[i].cor})");
                    ludo.jogadores[i].LancarDados();

                    for (int j = 0; j < ludo.jogadores.Length; i++)
                    {    
                    ludo.jogadores[j].Vitoria();
                    }
                }
            }

        }
        else
        {
            Console.WriteLine("Quantidade de jogadores inválida");
        }


    }
}
