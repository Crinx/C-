using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class DBEntry: Storable
    {

        public void write(object obj)
        {
            Console.WriteLine("Writing object to Data Base...");
        }

        public string read()
        {
            return "Reading note from Data Base...";
        }


        private ReturnStatus Status;
        public ReturnStatus status
        {
            get
            {
                return Status;
            }
            set
            {
                Status = value;
            }
        }

        public void otherMethod()
        {
            Console.WriteLine("see another method...");
        }
    }
}
