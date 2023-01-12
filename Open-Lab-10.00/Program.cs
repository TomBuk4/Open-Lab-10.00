using Open_Lab_10._00;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Book Math = new Book
        {
            Title = "Matika",
            Pages = 64,
            Author = "Miro Jaroš",
            Category = "Škola",
            ReleaseDate = 2020
        };
        Book Chemistry = new Book();
        Chemistry.Title = "Chemia";
        Chemistry.Pages = 744;
        Chemistry.Author = "Miro Jaroš";
        Chemistry.Category = "Škola";
        Chemistry.ReleaseDate = 2020;
        Book Biology = new Book();
        Biology.Title = "Biológia";
        Biology.Pages = 500;
        Biology.Author = "Miro Jaroš";
        Biology.Category = "Škola";
        Biology.ReleaseDate = 2020;
        Book Physics = new Book();
        Physics.Title = "Fyzika";
        Physics.Pages = 890;
        Physics.Author = "Miro Jaroš";
        Physics.Category = "Škola";
        Physics.ReleaseDate = 2020;

        Library schoolLibrary = new Library();
        schoolLibrary.NumberOfBooks = 4;
        schoolLibrary.NumberOfStudents = 2;

        schoolLibrary.StudentsList.Add("John");
        schoolLibrary.StudentsList.Add("Poul");

        schoolLibrary.BooksList.Add(Math);
        schoolLibrary.BooksList.Add(Chemistry);
        schoolLibrary.BooksList.Add(Biology);
        schoolLibrary.BooksList.Add(Physics);

        Console.WriteLine(schoolLibrary.ToString());


    }
}
