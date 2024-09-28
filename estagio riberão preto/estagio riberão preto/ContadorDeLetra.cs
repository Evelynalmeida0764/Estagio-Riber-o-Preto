using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estagio_riberão_preto
{
    public class ContadorDeLetra
    {
        public int Contar(string frase)
        {
            var contador = 0;
            foreach (char c in frase) 
            {
                if (c == 'A' || c == 'a')
                {
                    contador = contador + 1;
                }
            }
            var quantidade = contador;
            return quantidade;
        }
    }
}
