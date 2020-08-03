using System;

namespace Parameters
{
    class Pass
    {
        public static void value(ref int param)
        {
            Console.WriteLine($"        in method value is {param}");
            param = 42;
            Console.WriteLine($"        in method value is now {param}");
        }
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"        in method Reference is {param}");
            param.Number = 42;
            Console.WriteLine($"        in method value is now {param}");
        }
    }
}
