using System;

namespace helloworld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte b = 1;
            int i = b; //no data loss because int *expands* bytes by 3 for a total of 4 bytes.
            //IMPLICIT data conversion.

            int j = 1;
            byte b2 = (byte) j; //no data loss because j is smaller than 255. Anything larger would result in loss.
            //EXPLICIT data conversion using casting.

            int k = 1000;
            byte b3 = (byte)k; //results in loss because k is larger than 255.

            //Console.WriteLine("{0} {1}", b, i);
            //Console.WriteLine(b2);
            //Console.WriteLine(b3);
            //===========================================

            try
            {
                string str = "true";
                bool boolean = Convert.ToBoolean(str);
                Console.WriteLine(boolean);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The variable could not be converted.");
            }
        }
    }
}