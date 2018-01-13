using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace AcordesIntergalacticos
{
    class Program
    {

        static private void PosAcorde(int Qa, int Qb, int NotaMaior, ref int[] tecla)
        {
            for (int qa = Qa; qa <= Qb; qa++)
            {
                tecla[qa] = tecla[qa] + NotaMaior;

                if (tecla[qa] > 8)
                    tecla[qa] = tecla[qa] - 9;

            }
        }


        static private int Acorde(int Qa, int Qb, int[] tecla, int MaxNota, int MinNota)
        {
            int z = 0;
            int[] contagem = new int[MaxNota + 1];

            for (int qa = Qa; qa <= Qb; qa++)
            {

                switch (tecla[qa])
                {
                    case 0:
                        contagem[0]++;
                        break;

                    case 1:
                        contagem[1]++;
                        break;

                    case 2:
                        contagem[2]++;
                        break;

                    case 3:
                        contagem[3]++;
                        break;

                    case 4:
                        contagem[4]++;
                        break;

                    case 5:
                        contagem[5]++;
                        break;

                    case 6:
                        contagem[6]++;
                        break;

                    case 7:
                        contagem[7]++;
                        break;

                    case 8:
                        contagem[8]++;
                        break;

                    case 9:
                        contagem[9]++;
                        break;

                }

            }

            for (int y = MinNota; y < MaxNota; y++)
            {
                if(contagem.Max() == contagem[y])
                {
                    z = y;
                }

            }

            return z;
        } 

            
        static private void CadaTecla(int[] tecla)
        {
            foreach (int element in tecla)
            {
                Console.Write(element + " ");
            }

        }


        static void Main(string[] args)
        {

            Random random = new Random();
            int MinNota = 0;
            int MaxNota = 9;
            int N, Q, Qa, Qb;
            int NotaMaior = 0;
            int[] notasMusicais = new int[9];




            inicio:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Teclado Intergalático Mitra");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine("Digite o número de teclas no teclado:");
            int.TryParse(Console.ReadLine(), out N);

            if (N >= 2 && N <= 100000)
            {

                Console.WriteLine("Teclado com {0} teclas", N);
            }

            else
            {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Quantidade de teclas fora do limite especificado");
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(1500);
                Console.WriteLine("Voltando ao início...");
                Thread.Sleep(1500);
                goto inicio;
            }

            int[] teclas = new int[N];



            for (int element = 0; element <= teclas.Length - 1; element++)
            {

                teclas[element] = random.Next(MinNota, MaxNota);

            }

            CadaTecla(teclas);


            Console.WriteLine(" ");
            Console.WriteLine("Carregando...");
            Thread.Sleep(1500);

            acordes:
            Console.Clear();
            Console.WriteLine("Digite Número de acordes: ");
            int.TryParse(Console.ReadLine(), out Q);
            if (Q >= 1 && Q <= 100000)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Acordes:" + Q);
            }

            else
            {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Quantidade de acordes fora do limite especificado");
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(1500);
                Console.WriteLine("Repetindo o processo...");
                Thread.Sleep(1500);
                goto acordes;
            }


            Console.WriteLine("Carregando...");
            Thread.Sleep(1500);

            Console.WriteLine("Teclado Mitra configurado!");
            Thread.Sleep(1500);

            Console.Clear();

            Console.WriteLine("Comece a tocar");
            Console.WriteLine(" ");

            for (int q = Q; q >= 1; q--)
            {
                Console.WriteLine(" ");
                Qa = int.Parse(Console.ReadLine());
                Console.Write(" ");
                Qb = int.Parse(Console.ReadLine());
                Console.Write(" ");
                Console.Write(" ");
                

                NotaMaior = Acorde(Qa, Qb, teclas, MaxNota, MinNota);
                Console.WriteLine("Nota Frequente: {0}",NotaMaior);
                CadaTecla(teclas);

                PosAcorde(Qa, Qb, NotaMaior, ref teclas);
                Console.WriteLine("");
                Console.WriteLine("Pós-Acorde");
                CadaTecla(teclas);



            }
            
            Console.WriteLine("Digite ENTER para sair");
            Console.ReadLine();
        }
    }
}
