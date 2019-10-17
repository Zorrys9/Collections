using System;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;

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

                //List - список элементов с опередленным типом данных
                Console.WriteLine("List<T> : ");

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
                //LinkedList - список хранящий ссылки на следующий и предыдущий элемент списка, а так же содержащий само значение элемента определенного типа данных
                Console.WriteLine("LinkedList<T> : ");

                LinkedList<int> listLink = new LinkedList<int>();
                listLink.AddLast(3);
                listLink.AddFirst(11);
                listLink.AddLast(22);
                listLink.AddAfter(listLink.FindLast(11), 5);
                listLink.AddLast(8);
                listLink.AddFirst(11);
                listLink.AddBefore(listLink.Find(11), 2);
                get.GetList(listLink);

                LinkedList<Person> listPerson = new LinkedList<Person>();
                listPerson.AddLast(new Person { Name = "Alex", Age = 19 });
                LinkedListNode<Person> sam = listPerson.AddBefore(listPerson.First, new Person { Name = "Sam", Age = 21 }); // создание объекта с ссылкой на Sam, предыдущий и следующий элемент
                listPerson.AddFirst(new Person { Name = "Tom", Age = 19 });
                listPerson.AddBefore(listPerson.Last, new Person { Name = "Vasya", Age = 22 });

                get.GetList(listPerson);
                Console.WriteLine(value: $"Имя : {sam.Next.Value.Name}. Возвраст : {sam.Next.Value.Age}");
                Console.WriteLine(value: $"Имя : {sam.Previous.Value.Name}. Возвраст : {sam.Previous.Value.Age}");


                Console.WriteLine(value: $"\n Количество элементов в списке : {listPerson.Count}");


                Console.WriteLine("\n-----------------------------------------------------\n");

                // Queue - очередь, работающая по принципу "Первый вошёл - первый вышел"
                Console.WriteLine("Queue<T> : ");

                Queue<int> numberQue = new Queue<int>();

                numberQue.Enqueue(99);
                numberQue.Enqueue(15);
                numberQue.Enqueue(1);
                numberQue.Enqueue(25);
                get.GetList(numberQue);
                int que = numberQue.Dequeue();
                Console.WriteLine("\n" + que);
                get.GetList(numberQue);
                que = numberQue.Peek();
                Console.WriteLine("\n" + que);
                get.GetList(numberQue);

                Console.WriteLine(value: $"\n Количество элементов в списке : {numberQue.Count}");

                Queue<Person> personQue = new Queue<Person>();
                personQue.Enqueue(new Person { Name = "Tom", Age = 20 });
                personQue.Enqueue(new Person { Name = "Jerry", Age = 11 });
                personQue.Enqueue(new Person { Name = "Sam", Age = 40 });
                get.GetList(personQue);
                var pers = personQue.Dequeue();
                Console.WriteLine("\n" + pers.Name + " " + pers.Age);
                get.GetList(personQue);
                pers = personQue.Peek();
                Console.WriteLine("\n" + pers.Name + " " + pers.Age);
                get.GetList(personQue);

                Console.WriteLine(value: $"Количесвто элементов в списке : {personQue.Count}");

                Console.WriteLine("\n-----------------------------------------------------\n");

                // Stack - коллекция ,которая работает по принципу "Последний вошёл - первый вышел"
                Console.WriteLine("Stack<T> : ");
                Stack<int> NumStack = new Stack<int>();
                NumStack.Push(5);
                NumStack.Push(11);
                NumStack.Push(999);
                get.GetList(NumStack);
                int num = NumStack.Pop();
                Console.WriteLine("\n" + num);
                get.GetList(NumStack);
                num = NumStack.Peek();
                Console.WriteLine("\n" + num);
                get.GetList(NumStack);

                Console.WriteLine(value: $"\nКоличество элементов в списке : {NumStack.Count}");

                Stack<Person> personStack = new Stack<Person>();
                personStack.Push(new Person { Name = "Tom", Age = 33 });
                personStack.Push(new Person { Name = "Jerry", Age = 22 });
                personStack.Push(new Person { Name = "Petya", Age = 335 });
                get.GetList(personStack);
                Person perss = personStack.Pop();
                Console.WriteLine("\n" + perss.Name + " " + perss.Age);
                get.GetList(personStack);

                Console.WriteLine("\n-----------------------------------------------------\n");
                //Dictionary - коллекция типа "Ключ - значение"
                Console.WriteLine("Dictionary<T,V> : ");
                Dictionary<string, int> personDict = new Dictionary<string, int>(3);

                personDict.Add("Tom", 56);
                personDict["Jerry"] = 14;
                personDict["qweqwr"] = 0;
                get.GetList(personDict);
                personDict.Remove("qweqwr");
                get.GetList(personDict);

                Console.WriteLine(value: $"\n Количество элементов в коллекции : {personDict.Count}");

                Dictionary<string, string> countries = new Dictionary<string, string>(3)
                {
                    {"Россия", "Москва" },
                    {"Германия", "Берлин" },
                    {"Франция", "Париж" },
                };
                get.GetList(countries);

                Dictionary<string, string> countries2 = new Dictionary<string, string>
                {
                    ["Россия"] = "Москва",
                    ["Германия"] = "Берлин",
                    ["Франция"] = "Париж",
                };
                get.GetList(countries2);



                Console.WriteLine("\n-----------------------------------------------------\n");
				//ObservableCollection - коллекция, схожая с List, но может при изменении списка выполнять метод
                ObservableCollection<Person> people = new ObservableCollection<Person>
                {
                    new Person { Name=  "Tom", Age = 19},
                    new Person { Name=  "Jerry", Age = 32},
                    new Person { Name=  "Sam", Age = 129}
                };
                people.CollectionChanged += Change.people_CollectionChange;
                get.GetList(people);
                people.Add(new Person { Name = "Vasya", Age = 53 });
                get.GetList(people);
                people.RemoveAt(3);
                get.GetList(people);
                people[0] = new Person { Name = "Tom2", Age = 333 };
                get.GetList(people);


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
