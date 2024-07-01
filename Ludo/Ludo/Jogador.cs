using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    class Jogador
    {
        public string cor;
        public int identificador;
        public string nome;
        public Peao[] peoes = new Peao[4];
        private Tabuleiro tabuleiro;


        public Jogador(string cor, int identificador, string nome)
        {

            this.cor = cor;
            this.identificador = identificador;
            this.nome = nome;
            for (int i = 0; i < peoes.Length; i++)
            {
                Peao peao = new Peao(cor, i, 0);
                peoes[i] = peao;
            }
        }


        public void LancarDados()
        {
            Random dado = new Random();
            int valorDado2 = 0;
            int valorDado3 = 0;

            int valorDado1 = dado.Next(1, 7);
            if (valorDado1 == 6)
            {
                valorDado2 = dado.Next(1, 7);
                if (valorDado2 == 6)
                {
                    valorDado3 = dado.Next(1, 7);
                    if (valorDado3 == 6)
                    {
                        valorDado1 = 0;
                        valorDado2 = 0;
                        valorDado3 = 0;

                        Console.WriteLine("Você tirou três 6 seguidos no dado, você perdeu a vez");
                    }
                    else
                    {
                        Console.WriteLine($"Valores dos dados: {valorDado1}, {valorDado2}, {valorDado3}");
                        for (int p = 0; p < 4; p++)
                        {
                            Console.WriteLine($"O seu peão {p} está na posição: {peoes[p].posicao}");
                        }

                        int peaoEscolhido;
                        do
                        {
                            Console.Write($"Escolha o peão para mover com o dado que tirou {valorDado1} (0, 1, 2 ou 3): ");
                            peaoEscolhido = int.Parse(Console.ReadLine());
                        } while (!VerificarDisponibilidadePeao(peaoEscolhido, valorDado1));

                        validarJogada(peaoEscolhido, valorDado1);

                        for (int p = 0; p < 4; p++)
                        {
                            Console.WriteLine($"O seu peão {p} está na posição: {peoes[p].posicao}");
                        }

                        int peaoEscolhido2;
                        do
                        {
                            Console.Write($"Escolha o peão para mover com o dado que tirou {valorDado2} (0, 1, 2 ou 3): ");
                            peaoEscolhido2 = int.Parse(Console.ReadLine());
                        } while (!VerificarDisponibilidadePeao(peaoEscolhido, valorDado2));

                        validarJogada(peaoEscolhido2, valorDado2);

                        for (int p = 0; p < 4; p++)
                        {
                            Console.WriteLine($"O seu peão {p} está na posição: {peoes[p].posicao}");
                        }

                        int peaoEscolhido3;
                        do
                        {
                            Console.Write($"Escolha o peão para mover com o dado que tirou {valorDado3} (0, 1, 2 ou 3): ");
                            peaoEscolhido3 = int.Parse(Console.ReadLine());
                        } while (!VerificarDisponibilidadePeao(peaoEscolhido3, valorDado3));

                        validarJogada(peaoEscolhido3, valorDado3);

                    }
                }
                else
                {
                    Console.WriteLine($"Valores dos dados: {valorDado1}, {valorDado2}");
                    for (int p = 0; p < 4; p++)
                    {
                        Console.WriteLine($"O seu peão {p} está na posição: {peoes[p].posicao}");
                    }

                    int peaoEscolhido;
                    do
                    {
                        Console.Write($"Escolha o peão para mover com o dado que tirou {valorDado1} (0, 1, 2 ou 3): ");
                        peaoEscolhido = int.Parse(Console.ReadLine());
                    } while (!VerificarDisponibilidadePeao(peaoEscolhido, valorDado1));

                    validarJogada(peaoEscolhido, valorDado1);

                    for (int p = 0; p < 4; p++)
                    {
                        Console.WriteLine($"O seu peão {p} está na posição: {peoes[p].posicao}");
                    }

                    int peaoEscolhido2;
                    do
                    {
                        Console.Write($"Escolha o peão para mover com o dado que tirou {valorDado2} (0, 1, 2 ou 3): ");
                        peaoEscolhido2 = int.Parse(Console.ReadLine());
                    } while (!VerificarDisponibilidadePeao(peaoEscolhido, valorDado2));

                    validarJogada(peaoEscolhido2, valorDado2);
                }
            }
            else
            {
                Console.WriteLine($"Valores dos dados: {valorDado1}");
                for (int p = 0; p < 4; p++)
                {
                    Console.WriteLine($"O seu peão {p} está na posição: {peoes[p].posicao}");
                }

                int peaoEscolhido;
                do
                {
                    Console.Write($"Escolha o peão para mover com o dado que tirou {valorDado1} (0, 1, 2 ou 3): ");
                    peaoEscolhido = int.Parse(Console.ReadLine());
                } while (!VerificarDisponibilidadePeao(peaoEscolhido, valorDado1));

                validarJogada(peaoEscolhido, valorDado1);
            }
        }


        public int MoverPeao(int peaoEscolhido, int valorDado)
        {
            peoes[peaoEscolhido].posicao += valorDado;
            Console.WriteLine($"O peão {peoes[peaoEscolhido].identificador} foi movido para a posição {peoes[peaoEscolhido].posicao}");
            return peoes[peaoEscolhido].posicao;
        }

        public void validarJogada(int peaoEscolhido, int valorDado)
        {
            if (peoes[peaoEscolhido].posicao == 0 && valorDado == 6)
            {
                peoes[peaoEscolhido].posicao = 1;
            }
            else if (peoes[peaoEscolhido].posicao != 0)
            {
                if ((peoes[peaoEscolhido].posicao + valorDado) <= 57)
                {
                    MoverPeao(peaoEscolhido, valorDado);
                    tabuleiro.VerificarCaptura(identificador, peoes[peaoEscolhido].identificador);
                    if (peoes[peaoEscolhido].posicao == 57)
                    {
                        Console.WriteLine("Você chegou a casa final, agora você pode rolar mais um dado");
                        LancarDados();
                    }
                }

                else
                {
                    Console.WriteLine("Para chegar à casa final (triângulo), deve-se tirar o valor exato remanescente");
                }

            }
            else
            {
                Console.WriteLine("O peão só pode ser movido para o início da corrida, na casa de sua respectiva cor, quando um jogador lançar um 6 no dado");
            }
        }

        public bool VerificarDisponibilidadePeao(int peaoEscolhido, int ValorDado)
        {
            if (peoes[peaoEscolhido].posicao == 0 && ValorDado == 6)
            {
                return true;
            }
            else if (peoes[peaoEscolhido].posicao != 0)
            {
                if ((peoes[peaoEscolhido].posicao + ValorDado) <= 57)
                {
                    return true;

                }
                else if (peoes[peaoEscolhido].posicao == 57)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }


        public bool Vitoria()
        {
            if (peoes[0].posicao == 57 && peoes[1].posicao == 57 && peoes[2].posicao == 57 && peoes[3].posicao == 57)
            {
                Console.WriteLine($"O jogador {nome} venceu o jogo!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
