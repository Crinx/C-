using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Note : Storable
    {

        public void write(object obj)
        {
            Console.WriteLine("Writing object to disk...");
        }

        public string read()
        {
            return "Reading note from disk...";
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
