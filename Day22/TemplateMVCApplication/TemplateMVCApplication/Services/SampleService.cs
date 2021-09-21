using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMVCApplication.Services
{
    public class SampleService
    {
        int iNum1;
        public SampleService()
        {
            iNum1 = 0;
        }
        public int PrintNumber()
        {
            iNum1++;
            //throw new DivideByZeroException();
            return iNum1;
        }
    }
}
