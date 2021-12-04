using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;
using System.Text.Json.Serialization;


namespace base2_Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 5;
            const int b = 3;
            string pathD = "F:/Обучение 2035/ProjectC/Lesson16/base1_Lesson16/base1_Lesson16";
            Directory.SetCurrentDirectory(pathD);
            StreamReader streamReader = new StreamReader("Product.json");
            string jsonString1 = streamReader.ReadLine();
            string jsonString2 = streamReader.ReadLine();
            string jsonString3 = streamReader.ReadLine();
            string jsonString4 = streamReader.ReadLine();
            string jsonString5 = streamReader.ReadLine();

            Product product1 = JsonSerializer.Deserialize<Product>(jsonString1);
            //Console.WriteLine(jsonString1);
            Product product2 = JsonSerializer.Deserialize<Product>(jsonString2);
            //Console.WriteLine(jsonString2);
            Product product3 = JsonSerializer.Deserialize<Product>(jsonString3);
            //Console.WriteLine(jsonString3);
            Product product4 = JsonSerializer.Deserialize<Product>(jsonString4);
            //Console.WriteLine(jsonString4);
            Product product5 = JsonSerializer.Deserialize<Product>(jsonString5);
            //Console.WriteLine(jsonString5);

            double[] array1 = new double[a] {product1.Price, product2.Price, product3.Price, product4.Price, product5.Price};
            string[] array2 = new string[a] { product1.Name, product2.Name, product3.Name, product4.Name, product5.Name};

            double max = 0;
            int count = 0;
            for (int i=0; i < a; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                    count = i;
                }
            }
            Console.WriteLine(" Наибольшая стоимость товара - {0} = {1}", array2[count], max);
            Console.ReadKey();
        }
        class Product
        {
            public static int code;
            public static string name;
            public static double price;
            public int Code { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }
    }
}
