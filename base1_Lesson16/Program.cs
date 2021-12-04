using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;


namespace base1_Lesson16
{
    class Program
    {

        static void Main(string[] args)
        {
            string pathD = "F:/Обучение 2035/ProjectC/Lesson16/base1_Lesson16/base1_Lesson16";
            const int a = 5;
            const int b = 3;
            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();
            Product product4 = new Product();
            Product product5 = new Product();
            Console.WriteLine(" Введите массив товаров и характеристик");

            string[,] array = new string[a, b];
            int[] array1 = new int[a];
            string[] array2 = new string[a];
            double[] array3 = new double[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Good {0}: input code, name, price", i + 1);
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < a; i++)
            {
                array1[i] = Convert.ToInt32(array[i, 0]);
                array2[i] = array[i, 1];
                array3[i] = Convert.ToDouble(array[i, 2]);
            }

            product1.Code = array1[0];
            product1.Name = array2[0];
            product1.Price = array3[0];
            product2.Code = array1[1];
            product2.Name = array2[1];
            product2.Price = array3[1];
            product3.Code = array1[2];
            product3.Name = array2[2];
            product3.Price = array3[2]; 
            product4.Code = array1[3];
            product4.Name = array2[3];
            product4.Price = array3[3];
            product5.Code = array1[4];
            product5.Name = array2[4];
            product5.Price = array3[4];
            string JsonString1 = JsonSerializer.Serialize(product1);
            //Console.WriteLine(JsonString1);
            string JsonString2 = JsonSerializer.Serialize(product2);
            //Console.WriteLine(JsonString2);
            string JsonString3 = JsonSerializer.Serialize(product3);
            //Console.WriteLine(JsonString3);
            string JsonString4 = JsonSerializer.Serialize(product4);
            //Console.WriteLine(JsonString4);
            string JsonString5 = JsonSerializer.Serialize(product5);
            //Console.WriteLine(JsonString5);

            Directory.SetCurrentDirectory(pathD);
            StreamWriter file = new StreamWriter("Product.json", false);
            file.WriteLine(JsonString1);
            file.WriteLine(JsonString2);
            file.WriteLine(JsonString3);
            file.WriteLine(JsonString4);
            file.WriteLine (JsonString5);
            file.Close();

            Console.ReadKey();
        }
    }

    class Product
    {
        public static int code;
        public static string name;
        public static double price;
        public int Code { get; set; }
        public  string Name { get; set; }
        public double Price { get; set; }
    }
}