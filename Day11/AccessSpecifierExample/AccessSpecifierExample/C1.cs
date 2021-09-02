using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierExample
{
    public class C1
    {
        public int num1;
    }
    public class C2:C1
    {
        public C2()
        {
            num1 = 100;
        }
    }
}
