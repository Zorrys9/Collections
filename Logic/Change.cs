using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Change
    {
        public static void people_CollectionChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Person personNew = e.NewItems[0] as Person;
                    Console.WriteLine(value: $"\nДобавлен новый объект: {personNew.Name} {personNew.Age} лет");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Person personOld = e.OldItems[0] as Person;
                    Console.WriteLine(value: $"\nУдален объект : {personOld.Name} {personOld.Age} лет");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Person personReplace = e.OldItems[0] as Person;
                    Person personReplacing = e.NewItems[0] as Person;
                    Console.WriteLine(value: $"\nОбъект {personReplace.Name} заменен на {personReplacing.Name}");
                    break;
            }
        }
    }
}
