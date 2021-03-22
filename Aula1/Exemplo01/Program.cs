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

        public static void ex_06()
        {
            int numero;
            Console.Write("Digite um valor: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("Positivo");
            else
                Console.WriteLine("Negativo");

        }

        public static void ex_07()
        {
            int ano_nascimento, idade;
            Console.Write("Informe o ano de nascimento: ");
            ano_nascimento = Convert.ToInt32( Console.ReadLine());

            idade = 2021 - ano_nascimento;

            Console.WriteLine("Você tem " + idade + " anos.");
        }

        public static void ex_08()
        {
            int ano_nascimento, idade;
            Console.Write("Informe a sua idade (neste ano): ");
            idade = Convert.ToInt32(Console.ReadLine());

            ano_nascimento = 2021 - idade;

            Console.WriteLine("Você nasceu em " + ano_nascimento + ".");
        }

        public static void ex_09()
        {
            int valor, calculado;
            Console.Write("Digite a sua idade ou o ano de nascimento:");
            valor = Convert.ToInt32(Console.ReadLine());

            calculado = 2021 - valor;
            if (valor < 150)
                Console.WriteLine("Você nasceu em " + calculado + ".");
            else
                Console.WriteLine("Você tem " + calculado + " anos de idade.");
        }

        public static void ex_10()
        {
            int valor;
            Console.Write("Digite um valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            if ((valor % 2) == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
        }


        public static void ex_11()
        {
            int par_impar, numero_usuario, numero_computador, total;
            var numero = new Random();

            Console.WriteLine("Jogo do par ou impar.");
            Console.Write("Escolha 0 para Par ou 1 para Impar: ");
            par_impar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um valor de 0 a 10: ");
            numero_usuario = Convert.ToInt32(Console.ReadLine());

            numero_computador = numero.Next(11);
            total = numero_usuario + numero_computador;

            Console.WriteLine("O computador escolheu o valor " + numero_computador, ".");
            if ((total % 2) == par_impar)
                Console.WriteLine("Você ganhou!!");
            else
                Console.WriteLine("Você perdeu!!");

        }

        public static void ex_12()
        {
            int par_impar, numero_usuario, numero_computador, total;
            var numero = new Random();

            Console.WriteLine("Jogo do par ou impar.");
            Console.Write("Escolha 0 para Par ou 1 para Impar: ");
            par_impar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um valor de 0 a 10: ");
            numero_usuario = Convert.ToInt32(Console.ReadLine());

            numero_computador = numero.Next(11);

            // COMPUTADOR PERDEU??
            if (((numero_usuario + numero_computador) % 2) == par_impar)
            {
                Console.WriteLine("\nJogo Roubado!! Computado tinha escolhido o valor " + numero_computador + ", HAHAHAHA.");
                numero_computador++;
            }

            total = numero_usuario + numero_computador;
            Console.WriteLine("O computador escolheu o valor " + numero_computador, ".");
            if ((total % 2) == par_impar)
                Console.WriteLine("Você ganhou!!");
            else
                Console.WriteLine("Você perdeu!!");

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
                    case 1:     Program.ex_01();    break;
                    case 2:     Program.ex_02();    break;
                    case 3:     Program.ex_03();    break;
                    case 4:     Program.ex_04();    break;
                    case 5:     Program.ex_05();    break;
                    case 6:     Program.ex_06();    break;
                    case 7:     Program.ex_07();    break;
                    case 8:     Program.ex_08();    break;
                    case 9:     Program.ex_09();    break;
                    case 10:    Program.ex_10();    break;
                    case 11:    Program.ex_11();    break;
                    case 12:    Program.ex_12();    break;
                    default:
                        Console.WriteLine("Programa não disponível"); break;
                }
            } while (prog != 0);

        }
    }
}
