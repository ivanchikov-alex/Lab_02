using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    class Program
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
            int num2;
            uint unum = 120000;
            long lng = 150000;
            ulong ulng = 300000;
            short srt = 32000;
            ushort usrt = 64000;

            string str1 = "literal1";
            string str2 = "literal2";

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

            object obj = num;
            int num = (int)obj;
        }
    }
}
