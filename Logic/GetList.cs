using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Get
    {
        public void GetList(ArrayList list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"{elem} ");
            }

        }
        public void GetList(List<int> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"{elem} ");
            }

        }
        public void GetList(List<Person> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"Имя : {elem.Name}, возвраст :{elem.Age} \n");
            }
        }
        public void GetList(LinkedList<Person> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"Имя : {elem.Name}, возвраст :{elem.Age} \n");
            }
        }
        public void GetList(Queue<Person> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"Имя : {elem.Name}, возвраст :{elem.Age} \n");
            }
        }
        public void GetList(Stack<Person> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"Имя : {elem.Name}, возвраст :{elem.Age} \n");
            }
        }
        public void GetList(LinkedList<int> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"{elem} ");
            }
        }
        public void GetList(Queue<int> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"{elem} ");
            }
        }
        public void GetList(Stack<int> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"{elem} ");
            }
        }
        public void GetList(Dictionary<string, int> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"Имя : {elem.Key}, возвраст : {elem.Value} \n ");
            }
        }
        public void GetList(Dictionary<string, string> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"Страна : {elem.Key} - столица : {elem.Value} \n ");
            }
        }
        public void GetList(ObservableCollection<Person> list)
        {
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(value: $"Имя : {elem.Name}, возвраст : {elem.Age} \n ");
            }
        }
    }
}
