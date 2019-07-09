using System;

namespace BuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min/Max Values for C# types");
            Console.WriteLine("---------------------------");
            Console.WriteLine(" ");

            Console.WriteLine($"byte: minimum {byte.MinValue}, maximum {byte.MaxValue}");
            Console.WriteLine($"sbyte: minimum {sbyte.MinValue}, maximum {sbyte.MaxValue}");
            Console.WriteLine($"char: minimum {char.MinValue}, maximum {char.MaxValue}");
            Console.WriteLine($"decimal: minimum {decimal.MinValue}, maximum {decimal.MaxValue}");

            Console.WriteLine(" ");
            Console.WriteLine($"float: minimum {float.MinValue}, maximum {float.MaxValue}");
            Console.WriteLine($"double: minimum {double.MinValue}, maximum {double.MaxValue}");


            var x = 234;
            Console.WriteLine(x.GetType());
            Console.WriteLine($"int: minimum {int.MinValue}, maximum {int.MaxValue}");
            Console.WriteLine($"uint: minimum {uint.MinValue}, maximum {uint.MaxValue}");
            Console.WriteLine($"long: minimum {long.MinValue}, maximum {long.MaxValue}");
            Console.WriteLine($"ulong: minimum {ulong.MinValue}, maximum {ulong.MaxValue}");

            Console.WriteLine($"short: minimum {short.MinValue}, maximum {short.MaxValue}");
            Console.WriteLine($"ushort: minimum {ushort.MinValue}, maximum {ushort.MaxValue}");

            Console.WriteLine(" ");
            Console.WriteLine("bool, object and string do not have default Min/MaxValues");
            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");

            float f = 123.456789012345678f;
            double d = 123.456789012345678;
            Console.WriteLine($"f is {f:F99}");
            Console.WriteLine($"d is {d:F99}");

            //var y = 123.4;
            //Console.WriteLine(y.GetType());

            decimal z = 123.45678901234567890123456789023456789023456789m;
            Console.WriteLine();
            Console.WriteLine($"decimal: minimum {decimal.MinValue}, maximum {decimal.MaxValue}");
            Console.WriteLine($"z is {z:F99}");
        }
    }
}
