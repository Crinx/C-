using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var storableObjects = new List<Storable>();

            Note myNote = new Note();
            storableObjects.Add(myNote);

            DBEntry myDBEntry = new DBEntry();
            storableObjects.Add(myDBEntry);

            foreach (Storable storable in storableObjects)
            {
                storable.write(null);
                Console.WriteLine(storable.read());
            }
        }
    }
}
