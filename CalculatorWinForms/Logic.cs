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
        public static string ResultString (string p)
        {
            try
            {
                Calc();
            }
            catch {
                return "Error";
            }
            edit = true;
            return result.ToString();
        }

        public static string EnterOper (string p)
        {
            if (oper == "")
            {
                result = Convert.ToDecimal(nomber);
            }
            else if (!edit)
            {
                ResultString(p);
            }
            oper = p;
            edit = true;
            return result.ToString();
        }


        public static string EnterNomber(string nom)
        {
            string resString = nomber;
            if (!edit)
            {
                if (resString != "0" & nom ==",")
                    resString = resString + nom;
                else
                    resString = nom;
            }
            else
            {
                resString = nom;
                edit = false;
            }
            nomber = resString;
            return resString;
        }

        public static void Clear()
        {
            result = 0;
            nomber = "0";
            oper = "";
            edit = false;
        }

        /// <summary>
        /// Подсчет колличества запятых в строке.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int DSCount(string s)
        {
            int count = (s.Length - s.Replace(",", "").Length) / ",".Length;
            return count;
        }



        private static decimal result = 0;
        private static string nomber = "0";
        private static string oper = "";
        private static bool edit = false;



        /// <summary>
        /// 
        /// </summary>
        /// <param name="res">first nomber</param>
        /// <param name="nom">second nomber</param>
        /// <param name="p"> operation</param>
        /// <returns></returns>
        private static void Calc()
        {
            var nom = Convert.ToDecimal(nomber);
            switch (oper)
            {
                case "+":
                    result = result + nom;
                    break;
                case "-":
                    result = result - nom;
                    break;
                case "*":
                    result = result * nom;
                    break;
                case "/":
                    //if (nom != 0)
                        if (result != 0) result = result / nom;
                    break;
            }

        }

    }
}
