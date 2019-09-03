using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IComparable_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var CName = new Item();
            var a = new Item();
            var b = new Item();
            a.Name = "Bob";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Carly";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Edward";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            Console.ReadLine();
        }
    }
    public class Item : IComparable
    {
        public string Name;

        public int CompareTo(object o)
        {
            Item that = o as Item;
            return this.Name.CompareTo(that.Name);
        }
    }

    public class Comparison : Item
    {
        public string Name;
        //        public int CompareByName(object n);
        //        {
        //         Item that = n as Item;
        //            return this.Name.CompareTo(that.Name);
        //        }
        //}
        //   public class ICompareByLength
        //{
        //   int CompareByLength();
    }
}
class Comparison
{
    public string Name { get; set; }
}


