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

        public void LancarDados(out int valorDado1, out int valorDado2, out int valorDado3)
        {
            Random dado = new Random();
            valorDado2 = 0;
            valorDado3 = 0;

            valorDado1 = dado.Next(1, 7);
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
                    }
                }
            }
        }

        public int MoverPeao(int peaoIdentificador, int valorDado)
        {
            peoes[peaoIdentificador].posicao += valorDado;
            return peoes[peaoIdentificador].posicao;

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
