using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.Input
{
    interface IInputFilter
    {
        string[] Filter(string[] content);
    }
}
