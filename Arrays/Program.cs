using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] students = { "Engin", "Derin", "Salih" };

            //foreach(var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[7, 3]
            {
                {"İstanbul","İzmit","Kırıkkale" },
                {"Ankara","Eskişehir","Konya" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir", "Muğla","Manisa" },
                {"Diyarbakır","Şanlıurfa","Hatay" },
                {"Ağrı","Iğdır","Erzincan" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)  // 0 dimension index
            {
                for(int j = 0; j <= regions.GetUpperBound(1); j++)   // 1 dimension index
                {
                    Console.WriteLine(regions[i,j]);
                }

                Console.WriteLine("\t");
            }


            Console.ReadLine();
        }
    }
}
