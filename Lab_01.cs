using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    class Lab_01
    {
        static void Main(string[] args)
        {
            bool bl = true;
            byte bt = 255;
            sbyte sbt = 100;
            char ch = 'c';
            decimal dec = 4m;
            double dbl = 4.5;
            float flt = 4.5F;
            int num = -60000;
            uint unum = 120000;
            long lng = 150000;
            ulong ulng = 300000;
            short srt = 32000;
            ushort usrt = 64000;

            object obj = num;
            int unboxedNum = (int)obj;
            var implictStringVariable = "sting";
            var implictIntVariable = 16;
            //var implictVariable = "sting";
            //implictVariable =16;

            Nullable<int> nullNum = null;

            string lit1 = "literal1";
            string lit2 = "literal2";
            string str1 = "string number one";
            string str2 = "string2";
            string str3 = "string number3";
            string nullString = null;
            string emptyString = "";

            StringBuilder strbuilder = new StringBuilder("Строка StringBuilder");

            int[,] arr2d = { { 0, 1, 2 }, { 4, 5, 6 } };
            string[] strArr = { "str1", "str2", "str3" };
            int rows = arr2d.GetUpperBound(0) + 1;
            int cols = arr2d.GetUpperBound(1) + 1;
            double[,] lederArr = new double[3,4];

            var varArr = new[] {1,2,3 };
            var varStr = "неявно типизированая строка";

            (int, string, char, string, ulong) tuple = (num,lit1,ch,lit2,ulng);
            var tuple2 = (implictIntVariable, implictStringVariable, ch, lit2, ulng);
            int unboxedItem1 = tuple.Item1;
            string unboxedItem2 = tuple.Item2, unboxedItem4 = tuple.Item4;
            char unboxedItem3 = tuple.Item3;
            ulong unboxedItem5 = tuple.Item5;
            (unboxedItem1, unboxedItem2, unboxedItem3, unboxedItem4, unboxedItem5) = tuple2;

            //------------------------------------------------------------------

            lng = num;
            dbl = flt;
            lng = srt;
            dec = unum;
            ulng = usrt;

            num = (int)lng;
            srt = (short)num;
            sbt = (sbyte)bt;
            usrt = Convert.ToUInt16(ulng);
            flt = (float)dbl;

            if (nullNum == null)
                Console.WriteLine("empty");
            nullNum = 0;
            Console.WriteLine("nullNum= ", nullNum);

            str1 += str2;
            str2 = str3;
            str3.Substring(0, 12);
            str1.Split(' ');
            str2.Insert(13, str1);
            str3.Remove(10);
            Console.WriteLine($"str1 = {str1}, str3 = {str3}");//инттерполяция

            Console.WriteLine($"Строка emptyString пустая {String.IsNullOrEmpty(emptyString)}\nCтрока nullString = null {String.IsNullOrEmpty(nullString)}");
            Console.WriteLine($"Длина emptyString = {emptyString.Length}");

            strbuilder.Insert(0, "Вставка в начало");
            strbuilder.Append("Вставка в конец");
            Console.WriteLine($"{strbuilder}");

            for(int i=0; i< rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    Console.Write($"{arr2d[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine($"{strArr[i]}");
            }

            Console.WriteLine("Введите индекс(0-2) и строку для замены");
            int index = Convert.ToInt32(Console.ReadLine());
            string replStr = Console.ReadLine();
            strArr[index] = replStr;

            for(int i = 0; i<strArr.Length;i++)
            {
                Console.WriteLine($"{strArr[i]}");
            }
            Console.WriteLine($"Длина массива strArr = {strArr.Length}");

            for(int i=0, col=2;i<3;i++)
            {
                for(int j=0; j<col; j++)
                {
                    Console.WriteLine("Введите число");
                    lederArr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                col++;
            }

            Console.WriteLine();
            for (int i = 0, col = 2; i < 3; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{lederArr[i, j]} \t");
                }
                col++;
                Console.WriteLine();
            }

            Console.WriteLine($"\nКортеж1\n{tuple}\nКортеж2{tuple2}");
            Console.WriteLine($"Кортеж1 = Кортеж2 -> {tuple==tuple2}");
            Console.WriteLine($"{tuple.Item1} {tuple.Item3} {tuple.Item4}");

            (int, int, int, char) LocalFunc(int[] arr,string str)
            {
                return (arr.Max(),arr.Min(),arr.Sum(),str[0]);
            }

            Console.WriteLine($"Максимальный, минимальный элементы массива, сумма элементов, первая буква строки {LocalFunc(varArr, varStr)}");

            //int GetOverflow()
            //{
            //    return checked(int.MaxValue + 1);
            //}

            int GetMin()
            {
                return unchecked(int.MaxValue + 1);
            }

            Console.WriteLine($"unchecked значение = {GetMin()}");
            //GetOverflow();//при использовании cheked - ошибка
        }
    }
}
