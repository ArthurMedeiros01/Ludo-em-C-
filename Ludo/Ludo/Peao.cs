using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    class Peao
    {
        public string cor;
        public int identificador;
        public int posicao;

        public Peao(string cor, int identificador, int posicao)
        {
            this.posicao = posicao;
            this.identificador = identificador;
            this.cor = cor;

        }


        public int RetornarCasa()
        {
            return posicao = 0;
        }

    }
}
