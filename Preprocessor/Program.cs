#undef TRAIL
using System;

namespace Preprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
#if (TRAIL)
            Console.WriteLine("this is a trail version");
#elif (PROFESSIONAL)
            Console.WriteLine("this qqqqqq");
#else
            Console.WriteLine("this is qqqqqqq");

#endif
            Console.WriteLine("hello");




        }
    }
}
            