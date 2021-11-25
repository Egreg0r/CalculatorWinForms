using System;

namespace CalculatorWinForms
{
    public class Logic
    {
        /// <summary>
        /// =
        /// </summary>
        /// <returns>результат вычислений</returns>
        public static string ResultString()
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

        /// <summary>
        /// Ввод операции
        /// </summary>
        /// <param name="p">символ операции</param>
        /// <returns></returns>
        public static string EnterOper(string p)
        {

            if (oper == "")
            {
                result = Convert.ToDecimal(nomber);
            }
            else if (!edit)
            {
                ResultString();
            }
            oper = p;
            edit = true;
            nomber = result.ToString();
            return result.ToString();
        }

        
        public static string EnterNomber(string nom)
        {
            if (!edit)
            {
                if (nomber != "0")
                {
                    nomber += nom;
                }
                else
                    nomber = checkZero(nom);
            }
            else
            {
                nomber = checkZero(nom);
                edit = false;
            }
            return nomber;
        }

        public static string Backspace ()
        {
            nomber = nomber.Remove(nomber.Length - 1);
            if (nomber == "") nomber = "0"; 
            return nomber;
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
        public static bool DSCount(string s)
        {
            int count = (s.Length - s.Replace(",", "").Length) / ",".Length;
            if ((count < 1) || edit )
                return true;
            else
                return false;
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

        private static string checkZero (string nom)
        {
            if (nom == ",")
                nom = "0" + nom;
            return nom;
        }


    }
}
