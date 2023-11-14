using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaTemelleri
{
    public class StringMetotlari
    {
        public static void StringCalistir()
        {
            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.Write("surname: ");
            string surname = Console.ReadLine();

            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());

            //    string str = "My name is "+ name+ " "+ surname+ " and I'm " +age+ " years old.";
            //    string str = string.Format("My name is {0} {1} and I'm {2} years old.",name,surname,age);
            string str = $"My name is {name} {surname} and I'm {age} years old.";


            Console.WriteLine(str);
        }
        public static void StringMetotlariCalistir()
        {
            string msg = "Hello There. My name is Abdullah Akyol";

            //Console.WriteLine(msg.Length);
            //Console.WriteLine(msg.ToLower());
            //Console.WriteLine(msg.ToUpper());
            //Console.WriteLine(msg.Trim());
            //Console.WriteLine(msg.Split()[3]);
            //Console.WriteLine(msg[6]);
            Console.WriteLine(msg.StartsWith("Hello"));
            //Console.WriteLine(msg.EndsWith("."));
            //Console.WriteLine(msg.Contains("Here"));
            //Console.WriteLine(msg.IndexOf("name"));
            //Console.WriteLine(msg.Substring(5));
            //Console.WriteLine(msg.Substring(5, 10));

            int index = msg.IndexOf("name");
            Console.WriteLine(msg.Substring(index));
            Console.WriteLine(msg.Replace(" ", "-").Replace(".", "").Replace("@", "").ToLower());
            Console.WriteLine(msg.Insert(0, "..."));
            Console.WriteLine(msg.Insert(msg.Length, "..."));
            Console.WriteLine(msg.Remove(5, 10));
        }
    }
}
