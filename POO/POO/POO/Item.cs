using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO
{
    class Item
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        //metodo dados a todos os que sao items...
        public virtual void purchase()
        {
            Console.WriteLine("Compra {0}", Nome);
        }
    }

    class Software : Item
    {
        public string ISBN { get; set; }

        public override void purchase()
        {
            //base.purchase();
            Console.WriteLine("My ID is {0} and my ISBN is {1}",ID,ISBN);
        }
    }

    class Hardware : Item
    {
        public string Serial { get; set; }
    }

    class Computer : Hardware
    {
        public string CPU { get; set; }
        public string Disks { get; set; }

        public override void purchase()
        {
            base.purchase();
            Console.WriteLine("o meu CPU = {0}", CPU);
        }
    }

    class Peripheral : Hardware
    {
        public string Description { get; set; }
    }
}
