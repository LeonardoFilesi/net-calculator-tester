using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class CalcoliHelper
    {
        //-------------------------SOMMA--------------------------
        public static float Calculate2NumSum(float num1, float num2)
        {
            return num1 + num2;
        }
        //-------------------------DIFFERENZA--------------------------
        public static float Calculate2NumDif(float num1, float num2)
        {
            return num1 - num2;
        }
        //----------------------DIVISIONE----------------------------------
        public static float Calculate2NumDivis(float num1, float num2)
        {
            return num1 / num2;
        }
        //-------------------------MOLTIPLICAZIONE--------------------------
        public static float Calculate2NumMoltipl(float num1, float num2)
        {
            return num1 * num2;
        }
    }

}
