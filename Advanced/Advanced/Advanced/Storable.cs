using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public enum ReturnStatus
    {
        OK,
        Fail
    };

    public interface Storable
    {
        void write(object obj);
        String read();
        ReturnStatus status { get; set; }  
    }
}
