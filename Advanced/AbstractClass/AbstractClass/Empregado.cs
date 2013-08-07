using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Empregado
    {
        public string nome { get; set; }
        public int salario { get; set; }
        private DateTime startDate;

        public virtual void Hire()
        {
            startDate = DateTime.Now;
        }

        public abstract void GiveRaise();
    }
}
