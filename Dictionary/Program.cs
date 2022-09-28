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
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1, "dipali");
            dictionary.Add(2,"rupali");
            dictionary.Add(3, "shipali");
            foreach(KeyValuePair<int,string> item in dictionary)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
