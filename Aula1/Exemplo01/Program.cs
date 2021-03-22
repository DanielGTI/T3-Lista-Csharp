using System;

namespace Lista_Exercicio_Manha
{
    class Program
    {
        public static void ex_01()
        {
            Console.WriteLine("Daniel");
        }

        public static void ex_02()
        {
            double a, b, soma;
            Console.Write("Digite o 1º valor: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o 2º valor: ");
            b = Convert.ToDouble(Console.ReadLine());

            soma = a + b;
            Console.WriteLine("Soma = " + soma);
        }

        public static double ex_03()
        {
            double nota1, nota2, media;
            Console.Write("Digite o 1º notas: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o 2º notas: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2.0;
            Console.WriteLine("Media = " + media);

            return media;
        }

        public static void ex_04()
        {
            double media;

            media = ex_03();

            if (media >= 6.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }

        public static void ex_05()
        {
            double nota1, nota2, nota3, media, menor;
            Console.Write("Digite o 1º notas: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o 2º notas: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o 3º notas: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            menor = nota1;

            if (nota2 < menor)
                menor = nota2;

            if (nota3 < menor)
                menor = nota3;

            media = (nota1 + nota2 + nota3 - menor) / 2.0;
            Console.WriteLine("Media = " + media);
            if (media >= 6.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }

        static void Main(string[] args)
        {
            int prog = 1;

            do
            {
                Console.Write("\n-----------------------------\n");
                Console.Write("\t| 0 para sair |\nDigite o programa desejado: ");
                prog = Convert.ToInt32(Console.ReadLine());
                Console.Write("-----------------------------\n");

                if (prog == 0)
                    break;  // SAIR DA REPETIÇÃO

                switch (prog)
                {
                    case 1:
                        Program.ex_01(); break;
                    case 2:
                        Program.ex_02(); break;
                    case 3:
                        Program.ex_03(); break;
                    case 4:
                        Program.ex_04(); break;
                    case 5:
                        Program.ex_05(); break;
                    default:
                        Console.WriteLine("Programa não disponível"); break;
                }
            } while (prog != 0);

        }
    }
}
