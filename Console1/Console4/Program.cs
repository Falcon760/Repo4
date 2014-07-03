using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> newlist = new List<string>();
            newlist.Add("First");
            newlist.Add("Second");

            Book book1 = new Book();
            Console.WriteLine("What's the name: ");
            string entry = Console.ReadLine().ToLower();
            Console.WriteLine("Do you want to add this name to the library? Y or N ");
            string entry2 = Console.ReadLine().ToUpper();
            if (entry2 == "Y")
            {
                newlist.Add(entry);
                Console.WriteLine("This is the current library: ");
                foreach (string bbb in newlist)
                {
                    Console.WriteLine(bbb);   
                }

            }
            else
                Console.WriteLine("Goodbye");
            Console.ReadLine();
        }
        public class Book
        {
            public int BookId { get; set; }
            public string name { get; set; }
          
            

        }


    }
}
