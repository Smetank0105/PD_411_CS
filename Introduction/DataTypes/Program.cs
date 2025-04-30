//#define DATA_TYPES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

#if DATA_TYPES
            Console.WriteLine("DataTypes");
            Console.WriteLine(typeof(sbyte));
            Console.WriteLine(sizeof(byte));
            Console.WriteLine($"Byte:  {byte.MinValue} ... {byte.MaxValue}");
            Console.WriteLine($"SByte:{sbyte.MinValue}... {sbyte.MaxValue}"); 
#endif

            Console.WriteLine("Hello Constants");
            Console.WriteLine('+'.GetType());
            Console.WriteLine(5.GetType());
            Console.WriteLine(true.GetType());

            int a = -2;
            uint b = (uint)a;
            //C-like notation (C-подобная форма записи)
        }
    }
}
