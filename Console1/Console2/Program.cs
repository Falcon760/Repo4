using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.Price = 9.99M;
            var second_book = new Book();
            second_book.Price = 6.99M;
            if (book.CompareTo(second_book) == 0)
                Console.WriteLine("Books are the same Price");
            else if (book.CompareTo(second_book) == 1)
                Console.WriteLine("First Book is higher price than Second book");
            else if (book.CompareTo(second_book) == -1)
                Console.WriteLine("Second book is higher price than first book");
            Console.ReadLine();

        }
        public class Book : IComparable
        {
            private decimal price;
            public decimal Price
                //double holds longer scientific calculations
                //decimal
                


            {
                get {return price;}
                set {if (value >= 0) price = value;}
            }
            public int CompareTo(object obj)
            {
                if (obj is Book)
                {
                    if (this.Price == (obj as Book).Price)
                    {
                        return 0;
                    }
                    else if (this.Price > (obj as Book).Price)
                    {
                        return 1;
                    }

                    else if (this.Price < (obj as Book).Price)
                    {
                        return -1;
                    }

                }

                return -1;
            }
        }
    }
}
