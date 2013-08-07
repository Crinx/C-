using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            //var newWarehouse = new Warehouse("WarehouseOne", 101);

            //var item = newWarehouse.FindAndReturnItem(101);
            //Console.WriteLine("o meu novo item tem o nome " + item.Nome);

            Console.WriteLine();
            var myComputer = new Computer();
            myComputer.ID = 102;

            Item mySecondComputer = new Computer();
            mySecondComputer.ID = 103;

            Computer mySecondComputerTwo = mySecondComputer as Computer;
            string myCPU = mySecondComputerTwo.CPU;
            mySecondComputerTwo.Nome = "Comp";
            mySecondComputerTwo.CPU = "i7";
            mySecondComputerTwo.purchase();

            Software mySof = new Software();
            mySof.ID = 104;
            mySof.Nome = "soft";
            mySof.ISBN = "1234";
            mySof.purchase();

            //static... usar isto coloca o metodo, a var faz parte da classe e nao da instancia... nao precisamos de instanciar um objecto para a chamar...

        }
    }
}
