using System;
using System.Collections.Generic;
using System.Text;

namespace library
{
    public class Book
    {
        public string title;
        public string author;
        public string ISBN;


        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {title}");
            Console.WriteLine($"Book Author: {author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();

        }
    }
}
