using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class worker : Empregado
    {

        public override void GiveRaise()
        {
            salario = salario + 10;
        }
    }
}
