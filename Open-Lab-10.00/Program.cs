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
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Book LOTR = new Book();
        LOTR.SetTitle("Kni�ka pre (ne)poslu�n� deti");
        LOTR.SetPages(64);
        LOTR.SetAuthor("Miro Jaro�");
        LOTR.SetCategory("Kids");
        LOTR.SetReleaseDate(2020);
        LOTR.print();

        Book LOTR2 = new Book();
        Book LOTR3 = new Book("Te��me sa na Je�i�ka", 80);
        Book HOBIT = new Book("The Hobbit", 304, "John Ronald Reuel Tolkien", "Fantasy novel", 1937);
        LOTR2.print();
        LOTR3.print();
        HOBIT.print();


    }
}
