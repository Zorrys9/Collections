using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
