using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Abstract_Class
{
    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

    // Declare your class here. Do not use the 'public' access modifier.
    // Declare the price instance variable
     class MyBook : Book
    {
        protected int price;
        public MyBook(String title, String author, int price) :base(title,author)
        {
            this.price = price;
        }
        
        public override void display()
        {
            Console.WriteLine("Title: "+title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
        // End class
    }


    class Program
    {

        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
