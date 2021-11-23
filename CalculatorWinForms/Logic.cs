using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinForms
{
    public class Logic
    {
        public static int DS_Count(string s)
        {
            string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(substr, "").Length) / substr.Length;
            return count;
        }
    }
    public struct MathOperation
    {
        // хранимое значение
        public decimal m;

        public string Calc(string s, string p)
        {
            m = Convert.ToInt32(s);
            s.Append(Express?.Replace('X', 'x').Replace("pow", "Math.Pow").Replace("sin", "Math.Sin").Replace("cos", "Math.Cos").Replace("log", "Math.Log").Replace("abs", "Math.Abs").Replace("ctg", "1/Math.Tan").Replace("tg", "Math.Tan").Replace("pi", "Math.PI").Replace("exp", "Math.Exp"));

            return m.ToString();
        }

    }
}
