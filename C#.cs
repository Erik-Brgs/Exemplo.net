using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0; // Declaracao de variavel com valor
            int c, n1, n2; // Declaracao de variavel sem valor
            const int d = 10; // Declaracao de constante
            int[] array = new int[10] { 1, 2 , 3, 4, 5, 6, 7, 8, 9, 10 }; // Declaracao de array com valores definidos

            a = 100;
            b = 50;
            c = (a / b) + d;

            Console.WriteLine($"O total é {c}");

            // Uso do condicional "if":
            if (c == 0)
        {
                Console.WriteLine("Numero nulo!");
        }
            else if (c != 0)
            {
                Console.WriteLine("Numero nao nulo");
            }

            // Uso do condicional "switch":
            switch (c)
            {
                case 0:
                    Console.WriteLine("Numero nulo!");
                    break;
                case 1:
                    Console.WriteLine("Numero nao nulo!");
                    break;
                default:
                    Console.WriteLine($"Resultado {c}");
                    break;
            }
            
            // Uso do condicional "while":
            while (c == 12)
            {
                c++;
                Console.WriteLine($"O novo resultado é {c}");
            }

            // Uso do condicional "do":
            do
            {
                Console.WriteLine($"{c} + 1 = {c = c+1}");
            } while(c == 13);

            // Uso do condicional "for":
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Linha numero {i}!");
            }

            // Uso do condicional "foreach":
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }

            // Uso do "continue":
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Esta linha aparece 2 vezes!");

                if (i == 0)
                {
                continue;
                }
                else 
                {
                    break;
                }
            }

            // Uso do "return":
            static void exemploReturn() // Declaracao de funcao que nao devolve valor
            {
                int soma(int x, int y){ // Declaracao de funcao que devolve valor por parametro
                    return x + y;
                }
            
            Console.WriteLine(soma(1, 2));
            Console.WriteLine(soma(2, 3));
            return; // Tambem pode ser usado para parar execucao de metodos
            }

            exemploReturn(); // Chamada de funcao

            // Uso das instrucoes "Try", "Catch", "Finally", "Throw":   
                int divide( int a, int b)
                {
                    if (b == 0)
                        throw new DivideByZeroException("Impossivel dividir por 0!");

                    try 
                    {
                        if (a == 0 && b ==0)
                        throw new InvalidOperationException("Digite 2 numeros!");
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro generico: {e.Message}");
                    }
                    finally
                    {
                        Console.WriteLine("Obrigado!");
                    }
                    return a / b;
                } 

                // Nota: é meio complicado ler numeros do teclado em C#. Para isso, é necessario converter um entrada para int usando Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite um numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                
                int result = divide(n1, n2);

                Console.WriteLine($"O resultado da divisao é {result}"); 

                // Uso do "using":
                static void exemploUsing()
                {
                    using (System.IO.TextWriter w = System.IO.File.CreateText("ExemploUsing.txt"))
                    {
                        w.WriteLine("Linha 1");
                        w.WriteLine("Linha 2");
                        w.WriteLine("Linha 3");
                    }
                }
        }
    }
}
