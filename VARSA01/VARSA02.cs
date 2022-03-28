using System;

namespace VARSA
{
    internal partial class Program
    {
        public static class VARSA02
        {
            public static void AnaKod()
            {
                int maks, mins;
                maks = System.Int16.MaxValue;
                mins = System.Int16.MinValue;

                int maks32 = System.Int32.MaxValue;
                int mins32 = System.Int32.MinValue;

                byte maksby = System.Byte.MaxValue;
                byte minsby = System.Byte.MinValue;


                //int sayi = 23;
                //sayi = sayi * 2;
                //Console.WriteLine(sayi);

                Console.WriteLine("Int16 -> Min : {0}\t Mak: {1} ", mins, maks);

                Console.WriteLine("Int32 -> Min : {0}\t Mak: {1} ", mins32, maks32);

                Console.WriteLine("Byte -> Min : {0}\t Mak: {1} ", minsby, maksby);
            }

            public static void BoxingUnBoxing()
            {
                // kutulama - Boxing 
                int i = 23;
                object o = i;

                // kutuden cikarma - unboxing
                i *= 2;  // i = i*2;
                i = (int)o;  // cast

                Console.WriteLine("Deger turu: {0}", i);
                Console.WriteLine("Referans turu: {0}", o);


            }
        }
    }
}
