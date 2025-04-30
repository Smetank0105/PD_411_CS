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
            Console.WriteLine("DataTypes");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sbyte");
            Console.WriteLine(typeof(sbyte));
            Console.WriteLine(sizeof(sbyte));
            Console.WriteLine($"{sbyte.MinValue}...{sbyte.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Byte");
            Console.WriteLine(typeof(byte));
            Console.WriteLine(sizeof(byte));
            Console.WriteLine($"{byte.MinValue}...{byte.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Short");
            Console.WriteLine(typeof(short));
            Console.WriteLine(sizeof(short));
            Console.WriteLine($"{short.MinValue}...{short.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Ushort");
            Console.WriteLine(typeof(ushort));
            Console.WriteLine(sizeof(ushort));
            Console.WriteLine($"{ushort.MinValue}...{ushort.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Integer");
            Console.WriteLine(typeof(int));
            Console.WriteLine(sizeof(int));
            Console.WriteLine($"{int.MinValue}...{int.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Uninteger");
            Console.WriteLine(typeof(uint));
            Console.WriteLine(sizeof(uint));
            Console.WriteLine($"{uint.MinValue}...{uint.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Long");
            Console.WriteLine(typeof(long));
            Console.WriteLine(sizeof(long));
            Console.WriteLine($"{long.MinValue}...{long.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ulong");
            Console.WriteLine(typeof(ulong));
            Console.WriteLine(sizeof(ulong));
            Console.WriteLine($"{ulong.MinValue}...{ulong.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Double");
            Console.WriteLine(typeof(double));
            Console.WriteLine(sizeof(double));
            Console.WriteLine($"{double.MinValue}...{double.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Float");
            Console.WriteLine(typeof(float));
            Console.WriteLine(sizeof(float));
            Console.WriteLine($"{float.MinValue}...{float.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Decimal");
            Console.WriteLine(typeof(decimal));
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine($"{decimal.MinValue}...{decimal.MaxValue}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Boolean");
            Console.WriteLine(typeof(bool));
            Console.WriteLine(sizeof(bool));
            Console.WriteLine($"Boolean is a logical type and accepts values TRUE or FALSE");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Character");
            Console.WriteLine(typeof(char));
            Console.WriteLine(sizeof(char));
            Console.WriteLine($"Character accepts values from U+0000 till U+FFFF");
            Console.ResetColor();
        }
    }
}
