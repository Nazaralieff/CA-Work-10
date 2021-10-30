using System;

namespace VolumeOfBox
{
    class Program
    {
        static void Main(string[] args)
        {

            static int VolueOfBox(int widht, int length, int height)
            {
                return widht * length * height;
            }

            Console.WriteLine(VolueOfBox(length : 2, widht : 2, height : 2));
        }

    }
}
