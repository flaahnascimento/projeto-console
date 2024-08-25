using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptojeto.console
{
    internal class exemplo02
    {

        static void Main(string[] args)
        {
         
            int i = 0;

           
            Console.WriteLine("numeros de 0 a 100");
           

            
            while (i <= 100)
            {

                Console.WriteLine(i);
                i++;
            }

            //saida 
            Console.WriteLine("fim do programa...");
            Console.ReadKey();




            #region
            /*
             * variavel do tipo inteiro que inicia no 0 porque e ordem crescente
             * na entrada imprimi mensagem
             * enquanto o i for naior ou igual a 1, execute as chaves (adiciona incrementador e some +1 ate a condicao for false)
             * condicao e o incrementadorser menor ou igual a 100, senao por condiçao da loop infinito
             * saida foi imprimindo mensagem* 
             */
            #endregion
        }
    }
}



