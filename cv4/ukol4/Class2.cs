using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv4
{
    class NelzeVlozitDoNadrzeException : Exception
    {
        public string Message = "";

        public NelzeVlozitDoNadrzeException(string m)
        {
            Message = m;
        }
    }
    class NelzeOdebratZNadrzeException : Exception
    {
        public string Message = "";

        public NelzeOdebratZNadrzeException(string m)
        {
            Message = m;
        }
    }
}
