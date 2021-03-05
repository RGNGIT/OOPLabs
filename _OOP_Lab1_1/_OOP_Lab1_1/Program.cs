using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Lab1_1
{
    class Program
    {

        static int[] iArray;
        static string sAction;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку формата <Число> +, -, *, / <Число>");
            while (true)
            {
                vDivide(Console.ReadLine());
                Console.WriteLine($"Результат: {vCalc()}");
            }
        }

        static void vDivide(string Get)
        {
            string sTemp = string.Empty;
            sAction = string.Empty;
            iArray = new int[2];
            for(int i = 0; i < Get.Length; i++)
            {
                if(Char.IsDigit(Get[i]))
                {
                    sTemp += Get[i].ToString();
                }
                else if(Get[i] != ' ')
                {
                    sAction = Get[i].ToString();
                    iArray[0] = Convert.ToInt32(sTemp);
                    sTemp = string.Empty;
                }
            }
            iArray[1] = Convert.ToInt32(sTemp);
        }

        static int vCalc()
        {
            switch(sAction)
            {
                case "+":
                    return iArray[0] + iArray[1];
                case "-":
                    return iArray[0] - iArray[1];
                case "*":
                    return iArray[0] * iArray[1];
                case "/":
                    return iArray[0] / iArray[1];
                default:
                    return 0;
            }
        }

    }
}
