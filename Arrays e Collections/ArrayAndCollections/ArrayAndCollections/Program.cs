using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = new int[5];

            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next();
            }

            Console.WriteLine("Numeros: ");
            foreach (int numero in array)
            {
                Console.WriteLine("{0}",numero);
            }
            Console.WriteLine();
            int offset = 1;
            array[offset] = 23;
            foreach (int numero in array)
            {
                Console.WriteLine("{0}", numero);
            }

            //clica em Sort e pressiona F1... libraria do msdn para a funcao Sort...
            //exemplo... a classe Array tem dezenas de metodos que se podem usar...
            Array.Sort(array);
            Console.WriteLine();
            foreach (int numero in array)
            {
                Console.WriteLine("{0}", numero);
            }

            Console.WriteLine();
            //Lists
            List<int> lista = new List<int>();
            lista.Add(5);
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista.ElementAt(i));
            //}
            foreach (int numero in lista){
                Console.WriteLine(numero);
            }

            //Queue... FIFO type
            var myQ = new Queue<int>();
            myQ.Enqueue(100);
            myQ.Enqueue(101);
            int val = myQ.Dequeue();
            Console.WriteLine("val: {0}", val);
            val = myQ.Dequeue();
            Console.WriteLine("val: {0}", val);

            //Stack... Last In Last Out 
            var myS = new Stack<int>();
            myS.Push(102);
            myS.Push(103);
            val = myS.Pop();
            Console.WriteLine("val: {0}", val);
            val = myS.Pop();
            Console.WriteLine("val: {0}", val);

            //Dictionary
            Dictionary<string, string> cidades = new Dictionary<string, string>();
            cidades.Add("Norte", "Porto");
            cidades.Add("Centro", "Coimbra");
            cidades.Add("Sul", "Faro");

            Console.Write("Insere ( Norte, Centro ou Sul): ");
            string resp = Console.ReadLine();
            Console.WriteLine("A cidade do {0} e a {1}",resp,cidades[resp]);


        }
    }
}
