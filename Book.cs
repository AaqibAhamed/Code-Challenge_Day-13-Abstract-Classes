﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenge_Day_13_Abstract_Classes
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
}
