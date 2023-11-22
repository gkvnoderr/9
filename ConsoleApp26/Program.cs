using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            static void Spisok(List<int> ints)
            {
                foreach (int item in ints)
                {
                    Console.WriteLine(item);
                }
            }

            static void Main(string[] args)
            {
                List<int> ints = new List<int>(666);
                ints.Add(500);
                ints.Add(1);
                ints.Add(10);
                ints.Add(25);
                ints.Add(17);
                ints.Add(10);

                Spisok(ints);
                Indexx(ints);
                ints[0] = ints[1] + 5;

                ints.Remove(10);
                Console.WriteLine("- - - - - - - - - - - ");
                Spisok(ints);
                ints.Remove(17);
                Console.WriteLine("- - - - - - - - - - - ");
                Spisok(ints);
                Console.WriteLine("- - - - - - - - - - - ");
                Chec(ints);
                Console.WriteLine("- - - - - - - - - - - ");
                Sort(ints);
                //Console.WriteLine($"Count: = {ints.Count}");
                //Console.WriteLine($"Capacity: = {ints.Capacity}");
                Console.ReadKey();
            }


            //static void Indexx(List<int> ints)
            //{
            //    Console.WriteLine($"Индекс 25 это номер {ints.IndexOf(25)}");
            //}

            //static void Chec(List<int> ints)
            //{
            //    bool x = ints.Contains(25);
            //    Console.WriteLine(x);
            //}

            //static void Sort(List<int> ints)
            //{
            //    var sort = from i in ints orderby i select i;
            //    foreach (int i in sort)
            //        Console.WriteLine(i);
            //}



            //Задание  2. 
            //static void Main(string[] args)
            //{
            //    List<int> rndm = new List<int>();
            //    Random(rndm);
            //    for (int i= 0; i< rndm.Count;i++)
            //    {
            //        if (rndm[i] % 2 == 0) { }
            //        else { rndm.RemoveAt(i); }
            //    }
            //    Console.WriteLine();
            //    Spisok(rndm);
            //    Console.ReadKey();
            //}
            //static void Random(List<int> rndm)
            //{
            //    Random rnd = new Random();
            //    for (int i = 0; i < 10; i++)
            //    {
            //        rndm.Add(rnd.Next(1, 99));
            //        Console.WriteLine(rndm[i]);
            //    }
            //}
            //static void Spisok(List<int> ints)
            //{
            //    foreach (int item in ints)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //Задание 3. 
            //static void Main(string[] args)
            //{
            //    Console.Write("Введите номер товара, прекращенный в продаже: ");
            //    int n = int.Parse(Console.ReadLine());
            //    List<int> products = new List<int>(20);
            //    Filling(products);
            //    Console.WriteLine($"\nНовый спсиок стоимостей товаров, без списанного товара\n");
            //    for (int i = 0; i < products.Count; i++)
            //    {
            //        if (i == n) {products.RemoveAt(i); }
            //        else { Console.WriteLine($"{products[i]}"); }
            //    }
            //    Console.ReadKey();
            //}
            //static void Filling(List<int> fill )
            //{
            //    for (int i = 0; i <20 ; i++)
            //    {
            //        Console.Write($"Стоимость товара №{i} = ");
            //        fill.Add(int.Parse(Console.ReadLine()));
            //    }
            //}


            //Задание 4. .
            //static void Main(string[] args)
            //{
            //    List<int> rndm = new List<int>();
            //    Random(rndm);
            //    int cratno = 0;
            //    Console.Write("\nЧисла, кратные 5-ти\n");
            //    for (int i = 0; i < rndm.Count; i++)
            //    {
            //        if (rndm[i] % 5 == 0) 
            //        {
            //            Console.WriteLine(rndm[i]);
            //            cratno = cratno + rndm[i];
            //        }
            //        else {}
            //    }
            //    Console.WriteLine($"\nСумма значений, кратных 5-ти = {cratno}");
            //    Console.ReadKey();
            //}
            //static void Random(List<int> rndm)
            //{
            //    Random rnd = new Random();
            //    for (int i = 0; i < 10; i++)
            //    {
            //        rndm.Add(rnd.Next(1, 99));
            //        Console.WriteLine(rndm[i]);
            //    }
            //}


            //Задание 5. 
            //static void Main(string[] args)
            //{
            //    List<int> rndm = new List<int>();
            //    Random(rndm);
            //    Console.Write("\nОтрицательные числа\n");
            //    for (int i = 0; i < rndm.Count; i++)
            //    {
            //        if (rndm[i] < 0)
            //        {
            //            Console.WriteLine(rndm[i]);
            //            rndm.Add(10);
            //        }
            //        else { }
            //    }
            //    Console.WriteLine();
            //    Spisok(rndm);
            //    Console.ReadKey();
            //}
            // static void Random(List<int> rndm)
            //{
            //    Random rnd = new Random();
            //    for (int i = 0; i < 10; i++)
            //    {
            //        rndm.Add(rnd.Next(-99, 99));
            //        Console.WriteLine(rndm[i]);
            //    }
            //}
            // static void Spisok(List<int> ints)
            //{
            //    foreach (int item in ints)
            //    {
            //        Console.WriteLine(item);
            //    }
            }
        }

    }
}

