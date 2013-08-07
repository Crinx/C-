using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new worker();
            emp.nome = "A";
            emp.salario = 5;

            var man = new manager();
            man.nome = "B";
            man.salario = 10;

            var empregados = new List<Empregado>();
            empregados.Add(emp);
            empregados.Add(man);

            foreach (Empregado workers in empregados)
            {
                Console.WriteLine("O nome: {0}, com o salario {1}",workers.nome, workers.salario);
                workers.GiveRaise();
                Console.WriteLine("O nome: {0}, com o salario {1}", workers.nome, workers.salario);
            }
        }
    }
}
