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

        public void LancarDados2()
        {
            Random dado = new Random();
            int dado1 = 0;
            int dado2 = 0;
            int dado3 = 0;

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
                        Console.WriteLine("Você tirou três 6 seguidos no dado, você perdeu a vez");
                    }
                    else
                    {
                        Console.WriteLine($"Valores dos dados: {valorDado1}, {valorDado2}, {valorDado3}");
                        for(int p = 0; p < 4;p++)
                        {
                            Console.WriteLine($"O seu peão {p} está na posição: {ludo.jogador[i].peoes[p].posicao}");
                        }
                        Console.Write("Escolha o peão para mover (0, 1, 2 ou 3): "); // pode trocar isso por um método que mostra no console apenas os peoes disponiveis
                        int peaoEscolhido = int.Parse(Console.ReadLine());
                        Console.WriteLine

                        for(int p = 0; p < 4;p++)
                        {
                            Console.WriteLine($"O seu peão {p} está na posição: {ludo.jogador[i].peoes[p].posicao}");
                        }
                        Console.Write("Escolha o peão para mover com o dado que tirou {valordado2} (0, 1, 2 ou 3): "); // pode trocar isso por um método que mostra no console apenas os peoes disponiveis
                        int peaoEscolhido = int.Parse(Console.ReadLine());
                        //verificação..........
                        for(int p = 0; p < 4;p++)
                        {
                            Console.WriteLine($"O seu peão {p} está na posição: {ludo.jogador[i].peoes[p].posicao}");
                        }
                        Console.Write("Escolha o peão para mover com o dado que tirou {valordado3} (0, 1, 2 ou 3): "); // pode trocar isso por um método que mostra no console apenas os peoes disponiveis
                        int peaoEscolhido = int.Parse(Console.ReadLine());
                        //verificação..........
                    }    
                }
                else
                {
                    Console.WriteLine($"Valores dos dados: {valorDado1}, {valorDado2}");
                    for(int p = 0; p < 4;p++)
                    {
                        Console.WriteLine($"O seu peão {p} está na posição: {ludo.jogador[i].peoes[p].posicao}");
                    }
                    Console.Write("Escolha o peão para mover com o dado que tirou {valordado1} (0, 1, 2 ou 3): "); // pode trocar isso por um método que mostra no console apenas os peoes disponiveis
                    int peaoEscolhido = int.Parse(Console.ReadLine());
                    //verificação..........

                    for(int p = 0; p < 4;p++)
                    {
                        Console.WriteLine($"O seu peão {p} está na posição: {ludo.jogador[i].peoes[p].posicao}");
                    }
                    Console.Write("Escolha o peão para mover com o dado que tirou {valordado2} (0, 1, 2 ou 3): "); // pode trocar isso por um método que mostra no console apenas os peoes disponiveis
                    int peaoEscolhido = int.Parse(Console.ReadLine());
                    //verificação..........
                    
                }
            }
            else
            {
                Console.WriteLine($"Valor do dado: {valorDado1}");
                for(int p = 0; p < 4;p++)
                {
                    Console.WriteLine($"O seu peão {p} está na posição: {ludo.jogador[i].peoes[p].posicao}");
                }
                Console.Write("Escolha o peão para mover (0, 1, 2 ou 3): "); // pode trocar isso por um método que mostra no console apenas os peoes disponiveis
                int peaoEscolhido = int.Parse(Console.ReadLine());
                //verificação..........
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

        public void velidarJogada(peaoIdentificador, int ValorDado)
        {
            if(peoes[peaoIdentificador].posicao == 0 && valorDado ==6)
            {
                peoes[peaoIdentificador].posicao == 1;
            }
            else if (peoes[peaoIdentificador].posicao != 0)
            {
                 if((peoes[peaoIdentificador].posicao + valorDado) <= 57)
                 {
                 MoverPeao(peaoIdentificador, valorDado);
                	if(peoes[peaoIdentificador].posicao == 57)
                    {
                	Console.WriteLine(“Você chegou a casa final, agora você pode rolar mais um dado”);
                    LancarDados();
                        //mudar LancarDados dps***********
                	}
             }
            else{
            Console.WriteLine(“Para chegar à casa final (triângulo), deve-se tirar o valor exato remanescente”);
            }
            	
            }
            else{
            Console.WriteLine(“O peão só pode ser movido para o início da corrida, na casa de sua respectiva cor, quando um jogador lançar um 6 no dado”);
            }
        }

        public bool disponibilizarPeao(int ValorDado, int peaoIdentificador)
        {
            if(peoes[peaoIdentificador].posicao == 0 && valorDado ==6)
            {
                return true;
            }
            else if (peoes[peaoIdentificador].posicao != 0)
            {
                 if((peoes[peaoIdentificador].posicao + valorDado) <= 57)
                 {
                     return true;
                	if(peoes[peaoIdentificador].posicao == 57)
                    {
                	    return false;
                	}
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
