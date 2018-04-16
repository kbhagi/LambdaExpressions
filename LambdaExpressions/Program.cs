using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    { 
        static void Main(string[] args)
        {
        }   
    }
    //Statement Lambdas

    public delegate string BookInCurrentLibrary(string title);
    BookInCurrentLibrary bookInCurrentLibrary = (title) =>
    {
        foreach (var book in BookInCurrentLibrary.Library)
        {
            if (book.Title == title)
            {
                return book;
            }
        } 
        return null;
    };
    string result = statementDelegate(new StreamReader("File.txt"));
    //Initialize Get Properties
    public static string StringProperty => "Data";
    //Expression Labmdas
    (x,y) => x == y;
(int x, int y) => x == y;
}
