using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    class Tabuleiro
    {
        public Jogador[] jogadores;

        public Tabuleiro(Jogador jogador1, Jogador jogador2, Jogador jogador3, Jogador jogador4, int quantJogadores)
        {

            jogadores = new Jogador[quantJogadores];
            jogadores[0] = jogador1;
            jogadores[1] = jogador2;
            jogadores[2] = jogador3;
            jogadores[3] = jogador4;

        }

        public Tabuleiro(Jogador jogador1, Jogador jogador3, int quantJogadores)
        {

            jogadores = new Jogador[quantJogadores];
            jogadores[0] = jogador1;

            jogadores[1] = jogador3;


        }



        public bool VerificarCasaSegura(int posicaoDopeao)
        {
            if (posicaoDopeao == 1 || posicaoDopeao == 9 || posicaoDopeao == 14 || posicaoDopeao == 22 || posicaoDopeao == 27 || posicaoDopeao == 35 || posicaoDopeao == 40 || posicaoDopeao == 48 || posicaoDopeao == 0 || posicaoDopeao > 51)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int PosicaoNoTabuleiro(int idDoJogadorQueMoveu, int idDoJogadorParado, int idDoPeaoDoJogadorQueMoveu, int idDoPeaoParado)
        {
            int diferenca = idDoJogadorQueMoveu - idDoJogadorParado;
            if (diferenca == 2 || diferenca == -2)
            {

                if (jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao > 26)
                {
                    return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao - 26;
                }
                else
                {
                    return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao + 26;
                }

            }
            else if (diferenca == 3 || diferenca == -3)
            {
                if (diferenca == 3)
                {
                    if (jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao > 39)
                    {
                        return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao - 13;
                    }
                    else
                    {
                        if (jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao < 39 && jogadores[idDoJogadorParado].peoes[idDoPeaoParado].posicao < 39)
                        {
                            return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao - 13;
                        }
                        else
                        {
                            return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao + 39;
                        }
                    }
                }
                else
                {
                    if (jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao > 39)
                    {
                        return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao - 39;
                    }
                    else
                    {
                        return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao + 13;
                    }
                }
            }
            else
            {
                if (diferenca == 1)
                {
                    if (jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao > 39 && jogadores[idDoJogadorParado].peoes[idDoPeaoParado].posicao < 13)
                    {
                        return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao - 39;
                    }
                    else
                    {
                        return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao + 13;
                    }
                }
                else
                {

                    if (jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao < 13 && jogadores[idDoJogadorParado].peoes[idDoPeaoParado].posicao > 39)
                    {
                        return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao + 39;
                    }
                    else
                    {
                        return jogadores[idDoJogadorQueMoveu].peoes[idDoPeaoDoJogadorQueMoveu].posicao - 13;
                    }
                }

            }
        }

        public bool VerificarCaptura(int idDoJogadorQueMoveu, int idDoPeaoDoJogadorQueMoveu)
        {
            for (int i = 0; i < jogadores.Length; i++)
            {
                if (i != idDoJogadorQueMoveu)
                {
                    for (int j = 0; j < jogadores[i].peoes.Length; j++)
                    {
                        if (PosicaoNoTabuleiro(idDoJogadorQueMoveu, i, idDoPeaoDoJogadorQueMoveu, j) == jogadores[i].peoes[j].posicao)
                        {
                            if (!VerificarCasaSegura(jogadores[i].peoes[j].posicao))
                            {
                                Console.WriteLine($"O peão {j} do jogador {i} foi capturado! \nParabens agora você pode fazer mais uma lançamento de dados");
                                jogadores[i].peoes[j].posicao = 0;
                                jogadores[idDoJogadorQueMoveu].LancarDados();
                                return true;
                            } 
                        }
                    }
                }
            }
            return false;
        }

    }
}
