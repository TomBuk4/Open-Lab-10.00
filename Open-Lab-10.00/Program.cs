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
        LOTR.SetTitle("Knižka pre (ne)poslušné deti");
        LOTR.SetPages(64);
        LOTR.SetAuthor("Miro Jaroš");
        LOTR.SetCategory("Kids");
        LOTR.SetReleaseDate(2020);

        Console.WriteLine(LOTR.SetTitle);
        Console.WriteLine(LOTR.SetPages);
        Console.WriteLine(LOTR.SetAuthor);
        Console.WriteLine(LOTR.SetCategory);
        Console.WriteLine(LOTR.SetReleaseDate);
        Book LOTR2 = new Book();
        Book LOTR3 = new Book("Tešíme sa na Ježiška", 80);
        Book HOBIT = new Book("The Hobbit", 304, "Fantasy novel", "John Ronald Reuel Tolkien", 1937);
        LOTR2.print();
        LOTR3.print();
        HOBIT.print();


    }
}
