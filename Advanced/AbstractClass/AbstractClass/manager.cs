using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class manager: Empregado
    {
        public override void GiveRaise()
        {
            salario = salario + 100;
        }
    }
}
