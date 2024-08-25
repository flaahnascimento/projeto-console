using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptojeto.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int i = 100;

            
            Console.WriteLine("numeros de 100 a 1");

           
            while (i >= 1)
            {
               
                Console.WriteLine(i);
                 i --; 
            }
            //saida

            Console.WriteLine("fim do programa...");
            Console.ReadKey();



            #region
            /*
             * variavel do tipo inteiro que inicia no 100 porque e ordem decrescente
             * na entrada imprimi mensagem
             * enquanto o i for naior ou igual a 1, execute as chaves (adiciona incrementador e subtraia 1 ate a condicao for false)   
             * saida foi imprimindo mensagem* 
             */
            #endregion
        }
    }
}

