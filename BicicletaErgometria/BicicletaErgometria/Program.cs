using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BicicletaErgometria
{
    class Program
    {
        static int contador (int tempo, int[] vetor)
        {

            
            return contador(tempo--, vetor[]); 
        }
        
        static void Main(string[] args)
        {
            



            int t, min, max;

            #region Início
            inicio:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Sistema de Cálculo de Programa de Bicicleta Ergométrica");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            #endregion

            #region TempoDuração
            TempoDuracao:
            Console.WriteLine("Digite o tempo de duração em minutos: ");
            int.TryParse(Console.ReadLine(), out int auxt) ;
            if (auxt >=1 && auxt <=50)
            {
                t = auxt;
            }

            else
            {
                Console.WriteLine("Tempo deve ser entre 1 e 50 minutos");
                Thread.Sleep(2000);
                goto TempoDuracao;
            }

            #endregion

            #region MinimoMaximo
            m_e_M:
            Console.WriteLine("Digite a dificuldade mínima do Programa: ");
            int.TryParse(Console.ReadLine(), out int auxmin);

            Console.WriteLine("Digite a dificuldade máxima do Programa: ");
            int.TryParse(Console.ReadLine(), out int auxmax);

            if ((auxmin >= 1  &&  auxmax <= 100000) && auxmax> auxmin)
                {
                min = auxmin;
                max = auxmax;
            }

            else 
            {
                Console.WriteLine("Erro inesperado: digite as informações novamente");
                Thread.Sleep(2000);
                goto m_e_M;
            }

            #endregion


            

            int[] vetor = new int[max+1];

                     

          for (int a = min; a <=  max; a++ )
            {
                vetor[a] = a;
                Console.WriteLine(String.Format("vetor[{0}] = {0}", a));

            }


            
            Console.ReadLine();



           
            


      
        }
    }
}
