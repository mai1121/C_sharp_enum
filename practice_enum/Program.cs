using System;

namespace practice_enum
{
    class Program
    {
        enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            Argust,
            September,
            October,
            November,
            December,
        }

        [Flags]
        enum xyz
        {
            x=1,
            y=2,
            z = 4,

        }

        static void Main(string[] args)
        {
            Month m = Month.April;
            Console.WriteLine(m);
            Console.WriteLine(m.ToString("D"));
            Console.WriteLine((int)m);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0}月:{1}",i,(Month)i);
            }
            foreach(var name in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{(int)name}月:{name}");
            }

            var xy = xyz.x|xyz.y;
            Console.WriteLine(xy);

            var yz = xyz.y | xyz.z;
            Console.WriteLine(yz);

            var all = xyz.x | xyz.y | xyz.z;
            Console.WriteLine(all);

            var n = xyz.x | xyz.y | xyz.z;
            if (n.HasFlag(xyz.x)&& n.HasFlag(xyz.y)&&n.HasFlag(xyz.z))
            {
                Console.WriteLine("全て有効です");
            }

        }

    }



}
