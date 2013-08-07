using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class TesterExceptions
    {
        public void Method1()
        {
            Console.WriteLine("Method 1 begins");
            Method2();
            Console.WriteLine("Method 1 Ends");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 begins");
            try
            {
                Method3();
            }catch (Exception e)
            {
                Console.WriteLine("Exceptions: {0}",e.Message);
            }
            finally
            {
                Console.WriteLine("Finnaly Exceptions: ");
            }

            Console.WriteLine("Method 2 Ends");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3 begins");

            //try
            //{
                var x = 0;
                var y = 12 / x;//uma exceptions e dada aqui, divisao por 0
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exceptions: {0}",e.Message);
            //}

            Console.WriteLine("Method 3 Ends");
        }


        public double DoDivide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            if (x == 0)
            {
                throw new MyCustomException("Dividendo igual a zero");
            }

            return x / y;
        }
    }

    //Costum Exceptions
    public class MyCustomException : Exception
    {
        public MyCustomException(string message):
            base(message)
        {
            //...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TesterExceptions testes = new TesterExceptions();
            testes.Method1();

            try
            {
                double res = testes.DoDivide(1 , 2);
                Console.WriteLine("Res = {0}",res);
                res = testes.DoDivide(0 , 2);
                Console.WriteLine("Res = {0}", res);
                res = testes.DoDivide(1 , 0);
                Console.WriteLine("Res = {0}", res);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MyCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
