using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinForms
{
    public class Logic
    {
        public static int DSCount(string s)
        {
            //string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(",", "").Length) / ",".Length;
            return count;
        }

        private static decimal Result = 0;
        private static string oper;

        public static string ResultString (string s, string p)
        {
            var mathOp = new MathOperation();
            oper = p;
            var nomber = Convert.ToDecimal(s);
            Result = mathOp.Calc(nomber, oper);
            return Result.ToString();
        }

    }
    public struct MathOperation
    {
        // хранимое значение
        private decimal m;

        public decimal Calc(decimal s, string p)
        {
            var eq = s;
            m = Convert.ToDecimal(s);
            switch (p)
            {
                case "+": 
                    eq = eq + m;
                    break;
                case "-":
                    eq = eq - m;
                    break;
                case "*":
                    eq = eq * m;
                    break;
                case "/":
                    if (eq != 0) eq = eq / m;
                    break;
            }
            return eq;
        }

    }
}
