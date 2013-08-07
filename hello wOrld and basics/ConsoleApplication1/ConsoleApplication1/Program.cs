using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Enumerate constant
        enum Color
        {
            red,
            green,
            blue
        }

        static void Main(string[] args)
        {
            Console.WriteLine("HellO wOrld !! xD;");
            //se usar o Start, executa e termina... 
            //se usar CTRL+F5(Start), executa e termina quando carregar uma tecla
            Console.WriteLine("\n");

            //Building Blocks tutorial:
            //namespace... class... function... and some vars...
            var myString = "hello wOrld";
            //var faz com que o compiler identifique o tipo...
            //poderia ser:
            //string myString = "again...";
            Console.WriteLine(myString);

            int num = 23;
            double num2 = 23.5;
            //int + double = double, o compiler transforma o int em um double...
            double sum = num + num2;
            Console.WriteLine(sum);
            Console.WriteLine("\n");

            //true and false...
            //&& - and
            //|| - or
            //! - not
            Boolean value = 3 + 2 == 5;
            Console.WriteLine(value);
            value = 2 + 3 < 0;
            //Console.WriteLine(value);
            Boolean oneIsTrue = !value;
            Console.WriteLine("O valor vai ser {0} == false and Not == {1}",value,oneIsTrue);
            //o print de variaveis dentro de string executa-se assim, {0} ou {1}, por ai fora... depende do numero de variaveis que se quer na string
            Console.WriteLine("\n");

            //Program Flows...
            Console.Write("Num ?:");
            string numero = Console.ReadLine();
            num = int.Parse(numero);

            if (num > 18)
            {
                Console.WriteLine("Num recebido = {0} > 18", num);
            }
            else if (num < 18)
            {
                Console.WriteLine("Num recebido = {0} < 18", num);
            }
            else
            {
                Console.WriteLine("Num recebido = {0} = 18", num);
            }

            int idade = num;
            while (idade > 0)
            {
                Console.WriteLine("Happy Birthday {0}",idade);
                idade--;
                //idade = idade - 1;
                //idade -= 1;

            }
            Console.WriteLine("\n");

            for (int i = num; i > 0; i--)
            {
                idade++;
            }
            Console.WriteLine("\n");

            do
            {
                Console.WriteLine("Happy Birthday {0}", idade);
                idade--;
            } while (idade > 0);

            Console.WriteLine("\n");

            //Comentarios... existe o botao verde e vermelho para comentar e descomentar...
            //...
            /* coment... */

            //increment...
            //int age = ++num; increment and then assign
            //int age = num++; assign and then increment


            //forever loop
            num = 0;
            for ( ; ; )
            {
                Console.WriteLine("forever...");
                ++num;

                if (num == 5)
                {
                    Console.WriteLine("FIVE !!");
                    continue;
                }

                if (num > 10) {
                    break;
                }
            }

            Console.WriteLine("\n");

            Console.Write("Insert num: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("ONE");
                    break;
                case "2":
                    Console.WriteLine("TWO");
                    break;
                case "3":
                    Console.WriteLine("TREE");
                    break;
                default:
                    Console.WriteLine("!= of 1,2 and 3.");
                    break;
            }

            Console.WriteLine("\n");

            //Enumerate constant

            Color favorita = Color.green;
            Console.WriteLine("Enumration: var type Color, my favorite is {0}", favorita);


        }
    }
}
