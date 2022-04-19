using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection//is a class and collesctions is namespace
{
    class Order
    {//is simple class is a wrrapar class
     // Listcollection class is a Generic
        public static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();//Arraylist are not generics
            arr.Add("Vidisha");
            arr.Add(100);
            arr.Add('c');
            arr.Add(100.00);
            arr.Add(true);
            arr.Add(false);
            foreach (var item in arr)
            {
                Console.WriteLine(item);

            }
            List<object> obj = new List<object>();
            obj.Add("Vidisha");
            obj.Add(100);
            obj.Add('c');
            obj.Add(100.00);
            obj.Add(true);
            obj.Add(false);
            foreach (var item in obj)
            {
                Console.WriteLine(item);

            }

            List<Customer> customers = new List<Customer>();//List is generic
            customers.Add(new Customer() { Age = 20, Fname = "Sonam" });
            customers.Add(new Customer() { Age = 30, Fname = "Sach" });
            customers.Add(new Customer() { Age = 40, Fname = "Nima" });
            customers.Add(new Customer() { Age = 50, Fname = "Bina" });
            customers.Add(new Customer() { Age = 40, Fname = "Bablu" });
            customers.Add(new Customer() { Age = 50, Fname = "Pinku" });
            //list can stored duplicate value 

            List<string> list = new List<string>();
            list.Add("Sonu");
            list.Add("Monu");
            list.Add("Donu");

            HashSet<string> hs = new HashSet<string>();
            //hashset is also a generic 
            //hashset can not stored duplicate value
            //hashset always start unique value
            hs.Add("Mango");
            hs.Add("Bananas");
            hs.Add("Guava");
            hs.Add("Papaya");
            hs.Add("Papaya");
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
            List<ICustomer> ic = new List<ICustomer>();//interFACE
            List<Days> days = new List<Days>();//enum
            List<int> num = new List<int>();//it is print the same order
            num.Add(10);
            num.Add(20);
            num.Add(30);
            num.Add(40);
            Console.WriteLine("================");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            SortedSet<int> ss = new SortedSet<int>();//sortedset are not allow duplicate value, it will sort the data into a asending order
            
            ss.Add(110);
            ss.Add(210);
            ss.Add(210);
            ss.Add(3510);
            ss.Add(3310);
            Console.WriteLine("================");
            foreach (var item in ss)
            {
                Console.WriteLine(item);
            }
            //shortset is print the value in asending order
            //it is not allow duplicate 
            //shortset are not allow duplicate it is given the data assending order

            Console.ReadLine();

        }

    }
    public class Customer
    {
        public int Age { get; set; }
        public string Fname { get; set; }

    }
    public interface ICustomer
    {
    }
    public enum Days
    {
    }
}
//List angle type means data type  everytype list can take