using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.Input
{
    public class BluePrismInputFilter : IInputFilter
    {
        public string[] Filter(string[] content)
        {
            return content.Select(x => x.Trim()).Where(x => x.Length == 4).Select(x => x.ToLower()).Distinct().ToArray();
        }
    }
}
