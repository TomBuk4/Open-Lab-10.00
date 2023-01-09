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
        Book Math = new Book();
        Book Chemistry = new Book();
        Book Biology = new Book();
        Book Physics = new Book();

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
