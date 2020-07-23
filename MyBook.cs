using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenge_Day_13_Abstract_Classes
{
     class MyBook : Book
    {
       
         int price;

        public MyBook(string title, string author, int price) : base(title,author)
        {
            this.price = price;
        }
        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }
}
