using System;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CommonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ArrayList - список с элементами любого типа данных
                Console.WriteLine("ArrayList : ");
                ArrayList list = new ArrayList() { 1, 2, 3, 4, 6, "help", '+', 3, 99 };


                Get get = new Get();
                get.GetList(list);
                list.Add(5);
                list.Add(5.7);
                list.Add(new string[] { "Hello", "World" });
                list.AddRange(new string[] { "Hello", "World" });
                get.GetList(list);
                list.RemoveRange(3, 2);
                list.RemoveAt(list.LastIndexOf(3));
                get.GetList(list);
                list.Reverse();
                get.GetList(list);
                list.Reverse();
                get.GetList(list);
                Console.WriteLine(value: $"\nКоличество элементов в списке равно {list.Count}");
                Console.WriteLine("\n-----------------------------------------------------\n");


                Console.WriteLine("List : ");

                List<int> numlist = new List<int> { 1, 5, 9, 8, 2, 4, 2 };
                numlist.Add(9999);
                numlist.AddRange(new int[] { 33, 55, 88 });
                get.GetList(numlist);
                numlist.RemoveAt(4);
                numlist.Remove(2);
                get.GetList(numlist);
                numlist.Reverse();
                get.GetList(numlist);
                Console.WriteLine(value: $"\nКоличество элементов в списке равно {numlist.Count}");
                Console.WriteLine();

                List<Person> personlist = new List<Person>(1);
                personlist.Add(new Person() { Name = "Petya", Age = 9 });
                personlist.Add(new Person() { Name = "Vasya", Age = 42 });
                personlist.Add(new Person() { Name = "Tom", Age = 24 });
                personlist.Add(new Person() { Name = "Sam", Age = 95 });
                personlist.Add(new Person() { Name = "Katya", Age = 19 });
                get.GetList(personlist);
                personlist.RemoveAt(3);
                get.GetList(personlist);
                Console.WriteLine(value: $"\nКоличество элементов в списке равно {personlist.Count}");


                Console.WriteLine("\n-----------------------------------------------------\n");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(value: $"\n {ex.Message}");
                Console.ReadKey();
            }




        }
    }
}
