using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Empregado
    {
        //private int Idade;
        //uma propriedade para tratr de um field ( idade )
        //public int idade
        //{
        //    get { return Idade; }
        //    set { Idade = value; }
        //}

        public int idade { get; set; }
        public string nome { get; set; }
        public DateTime start { get; set; }

        public Empregado(string nom)
        {
            nome = nom;
        }

        public Empregado()
        {
        }

        public void addYears(int y)
        {
            idade = idade + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Empregado obj = new Empregado(){
                nome = "luis",
                start = new DateTime(2013, 8, 7)
            };

            obj.idade = 23;

            Console.WriteLine("Idade do {0} = {1} e o seu start = {2}", obj.nome, obj.idade, obj.start);

            obj.addYears(10);
            Console.WriteLine("Idade do {0} = {1} e o seu start = {2}", obj.nome, obj.idade, obj.start);

            Console.WriteLine();

            Empregado obj2 = new Empregado("pedro");
            Console.WriteLine("Nome do obj2 = {0}", obj2.nome);
        }
    }
}
