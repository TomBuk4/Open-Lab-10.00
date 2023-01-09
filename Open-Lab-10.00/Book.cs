using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Book
    {
        private string title;
        private int pages;
        private string author;
        private string category;
        private int releaseDate;

      

        public string Title
        {
            get { return title; }
        
            set { this.title = value; }
        }
        public int Pages
        {
            get { return pages; }
       
            set
            {
                if (pages < 0)
                {
                    pages = 1;
                }
            }

        }
        public string Author
        {
           get { return author; }
        
           set { this.author = value; }
            
        }

        public string Category
        {
           set { this.category = value; }
            
        }
        public int ReleaseDate
        {
           get { return releaseDate; }
        
            set
            {
                if ((releaseDate <= 2021) || (releaseDate >= 1450))
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }
        }
        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(string title, int pages)
        {
            category = "-1";
            author = "-1";
            releaseDate = -1;
            this.title = title;
            this.pages = pages;
        }
        public Book(string title, int pages, string author, string category, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.author = author;
            this.category = category;
            this.releaseDate = releaseDate;
        }

        public void print()
        {
            Console.WriteLine("Názov: " + title);
            Console.WriteLine("Autor: " + author);
            Console.WriteLine("Kategória: " + category);
            Console.WriteLine("Vydané: " + releaseDate);
            Console.WriteLine("Počet strán: " + pages);
        }
        public static readonly List<string> categoryList = new List<string>()
        {"detské", "romantické", "náučné", "sci-fi", "dobrodružné"};

    }
}
