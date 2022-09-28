using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sl = new SortedList<string, int>();

            sl.Add("Rupesh",90);
            sl.Add("Ajinkya",91);
            sl.Add("Vijay", 93);
            sl.Add("Sanjay", 95);
            sl.Add("Tushar", 96);
            sl.Add("Nilesh", 92);

            sl.Remove("Vijay");

           
            Console.WriteLine(sl.Count);

            foreach (var s in sl)
            {
                Console.WriteLine(s);
            }
        }
    


    //Dictionary<int,string> dictionary = new Dictionary<int,string>();
    //dictionary.Add(1, "dipali");
    //dictionary.Add(2,"rupali");
    //dictionary.Add(3, "shipali");
    //foreach(KeyValuePair<int,string> item in dictionary)
    //{
    //    Console.WriteLine(item.Key+" "+item.Value);
    //}

    }
}
