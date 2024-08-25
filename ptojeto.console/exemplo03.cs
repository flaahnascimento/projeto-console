using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptojeto.console
{
    internal class exemplo03
    {
        static void Main(string[] args)
        {
           
            int numero, i = 1;

            
            Console.WriteLine("digite o fim do intervalo: ");
            numero = int.Parse(Console.ReadLine());

           
            while (i <= numero)
            { 
                
                if (i == 4)
            {

                    break;
            }
            
                Console.WriteLine("numero: " + i);
                i++;
            }
           
            Console.WriteLine("fim do programa");
            Console.ReadKey();


            #region
            /*
             * 2 variavel do tipo inteiro, a do incrementador inicia no 1
             * na entrada - escreva e leia (converta)
             * enquanto o i for menor ou igual ao numero, executa o if  
             * se i nao for igual a 4, pula e cai no console
             * caiu em console imprima a mensagem: soma o n com o contador, execute a ultima linha e +1 no contador
             * saida - quando i == 4 para 9break;0  e caia no fim do pragrama 
             */
            #endregion
        }
    }
}