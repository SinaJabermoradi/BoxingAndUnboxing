using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {


            // Boxing   =====   ValueType ==CastingTo==> Object Or ReferenceType

            int i = 100;
            float f = 10.5656f;
            double d = 1540.54645;
            char c = 's';
            bool b = true;

            Object ob0;
            Object ob1;
            Object ob2;
            Object ob3;
            Object ob4;

            ob0 = (Object)i;
            ob1 = (Object)f;
            ob2 = (Object)d;
            ob3 = (Object)c;
            ob4 = (Object)b;



            // UnBoxing   =====   Object Or ReferenceType ==CastingTo==> ValueType  



            Object o1 = 100;
            Object o2 = 10.5656f;
            Object o3 = 1540.54645;
            Object o4 = 's';
            Object o5 = true;

            int b0;
            float b1;
            double b2;
            char b3;
            bool b4;

            b0 = (int)o1;
            b1 = (float)o2;
            b2 = (double)o3;
            b3 = (char)o4;
            b4 = (bool)o5;
        }
    }
}
