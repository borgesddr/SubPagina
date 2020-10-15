using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substituicao_pagina
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] msecundaria = new int[] { -1, -1, -1, -1 };
            int[] mram = new int[] { 20, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            var falta_pagina = 0;

            for (int c = 0; c < mram.Length;)
            {

                for (int i = 0; i < msecundaria.Length; i++)
                {
                    if (mram.Length > 0)
                    {
                        if (msecundaria.Contains(mram[c]))
                        {

                            var lista = mram.ToList(); // cria um objeto do tipo List<string> a partir do vetor
                            lista.RemoveAt(c); // remove o item na posição 1
                            mram = lista.ToArray(); // recria o vetor a partir da lista
                        }

                        else
                        {
                            falta_pagina += 1;
                            msecundaria[i] = mram[c];

                            var lista = mram.ToList(); // cria um objeto do tipo List<string> a partir do vetor
                            lista.RemoveAt(c); // remove o item na posição 1
                            mram = lista.ToArray(); // recria o vetor a partir da lista
                        }
                    }
                }
            }

            Console.WriteLine("Houve " + falta_pagina + " Falta de paginas\n\n");
            Console.Read();

        }
    }
}
