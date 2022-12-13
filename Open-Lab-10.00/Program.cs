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
        LOTR.print();


    }
}
