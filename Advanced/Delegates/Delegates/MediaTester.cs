using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class MediaTester
    {
        public delegate int TestMedia();

        public void runTest(TestMedia testDelegate)
        {
            int res = testDelegate();
            if (res == 0)
            {
                Console.WriteLine("Worked");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
