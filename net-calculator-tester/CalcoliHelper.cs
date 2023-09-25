using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    internal class CalcoliHelper
    {
        //-------------------------SOMMA--------------------------
        public static int Calculate2NumSum(int intNum1, int intNum2)
        {
            return intNum1 + intNum2;
        }
        public static double Calculate2NumSum(double decNum1, double decNum2)
        {
            return decNum1 + decNum2;
        }
        //-------------------------DIFFERENZA--------------------------
        public static int Calculate2NumDif(int intNum1, int intNum2)
        {
            return intNum1 - intNum2;
        }
        public static double Calculate2NumDif(double decNum1, double decNum2)
        {
            return decNum1 - decNum2;
        }
        //----------------------DIVISIONE----------------------------------
        public static int Calculate2NumDivis(int intNum1, int intNum2)
        {
            return intNum1 / intNum2;
        }
        //-------------------------MOLTIPLICAZIONE--------------------------
        public static int Calculate2NumMoltipl(int intNum1, int intNum2)
        {
            return intNum1 * intNum2;
        }
    }

}
