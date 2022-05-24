using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khim
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input number phone : ");
            string a = Console.ReadLine(); //"096209572"
            char[] charArr = a.ToCharArray(); //"0 9 6 2 0 9 5 7 2"
            int[] intArray = new int[10];
            for (int i = 0; i < 10; i++) { intArray[i] = Convert.ToInt32(charArr[i].ToString()); }
            double avg = check_num(intArray); //"0,9,6,2,0,9,5,7,2"
            Console.WriteLine("The result is {0:f2}", avg);
            if (avg >= 99)
                Console.WriteLine("THE AUSPICIOUS NUMBER!");
            else if (avg >= 85 & avg <= 98)
                Console.WriteLine("THAT'S A GREAT NUMBER!");
            else if (avg >= 76 & avg <= 85)
                Console.WriteLine("Good number");
            else if (avg >= 61 & avg <= 75)
                Console.WriteLine("Not that bad");
            else if (avg < 40 && avg > 10)
                Console.WriteLine("Have a hard time");
            else if (avg < 10) { Console.WriteLine("THE UNAUSPICIOUS NUMBER!"); }
            Console.WriteLine("เจ้าของโปรแกรม น่ารักคับ");
            Console.ReadKey();
        }
        static double check_num(int[] pct)
        {
            int n = pct.Length;
            int sum = 0;
            int i = 3;
            while (i < n - 1)
            {
                int a, b;
                a = pct[i];
                b = pct[i + 1];
                if (a == 0 && b == 0) sum += -100;
                if (a == 0 && b == 1 || a == 1 && b == 0) sum += -88;
                if (a == 0 && b == 2 || a == 2 && b == 0) sum += -95;
                if (a == 0 && b == 3 || a == 3 && b == 0 || a == 3 && b == 1 || a == 8 && b == 1 || a == 1 && b == 8) sum += -85;
                if (a == 0 && b == 4 || a == 4 && b == 0) sum += -60;
                if (a == 0 && b == 5 || a == 5 && b == 0 || a == 1 && b == 1) sum += -49;
                if (a == 0 && b == 6 || a == 6 && b == 0 || a == 1 && b == 2 || a == 2 && b == 1) sum += -80;
                if (a == 0 && b == 7 || a == 7 && b == 0) sum += -37;
                if (a == 0 && b == 8 || a == 8 && b == 0) sum += -75;
                if (a == 0 && b == 9 || a == 9 && b == 0 || a == 7 && b == 5) sum += -2;
                if (a == 1 && b == 3) sum += -93;
                if (a == 1 && b == 7 || a == 7 && b == 1 || a == 6 && b == 7 || a == 7 && b == 6 || a == 8 && b == 4 || a == 4 && b == 8) sum += -45;
                if (a == 3 && b == 4 || a == 4 && b == 3) sum += -50;
                if (a == 3 && b == 7 || a == 7 && b == 3) sum += -20;
                if (a == 3 && b == 8 || a == 8 && b == 3) sum += -25;
                if (a == 2 && b == 7 || a == 7 && b == 2) sum += -55;
                if (a == 5 && b == 8 || a == 8 && b == 5) sum += -56;
                if (a == 5 && b == 7) sum += -5;
                if (a == 2 && b == 5 || a == 5 && b == 2) sum += 95;
                if (a == 3 && b == 3) sum += 68;
                if (a == 4 && b == 7 || a == 7 && b == 4) sum += 80;
                if (a == 6 && b == 8 || a == 8 && b == 6) sum += 30;
                if (a == 8 && b == 8) sum += 40;
                if (a == 7 && b == 7)
                    sum += 50;
                else
                    sum += 100;

                i = i + 1;
            }
            double avg = sum / 6;
            return avg;
        }
    }
}
