using System;

namespace Rekursif_ve_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif fonksiyonlar (Öz Yinelemeli)
            // kendini çağıran fonksiyonlardır, aynı işlem for döngüleriyle yapılabilir

            // 3^4 = 3*3*3*3
            int result = 1;
            for (int i = 0; i < 4; i++)
                result=result*3;
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            // Extension Metotlar
            string ifade = "burak oranlıer";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi ={9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstString());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us<2)
                return sayi;
            return Expo(sayi, us-1) * sayi;
        }
    }

    public static class Extension//extension class ve metotlar statik olmalı
    {
        public static bool CheckSpaces(this string param)// this ifadesi eklenince artık bu bir extension metotdur
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] arry)
        {
            Array.Sort(arry);
            return  arry;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;

        }

        public static string GetFirstString(this string param)
        {
            return param.Substring(0,1);

        } 
    }
}
