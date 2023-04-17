using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus5
{
    internal class Number
    {
        public float Primary_Number { get; set; }
        public float Secondary_Number { get;set; }

        public static float Add(float PN, float SN)
        {
            return PN + SN;
        }
        public static float Subtract(float PN, float SN)
        {
            return PN - SN;
        }
        public static float Multiply(float PN, float SN) 
        {  
            return PN * SN; 
        }
        public static float Divide(float PN, float SN)
        {
            return PN / SN;
        }
    }
}
