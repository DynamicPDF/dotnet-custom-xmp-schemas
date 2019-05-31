using System;

using MergePDFBookmarks.Examples;

namespace MergePDFBookmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = string.Empty;
            bool exit = false;
            Console.WriteLine("This example shows options for handling bookmarks when merging PDFs together using DynamicPDF Merger for .NET");
            Console.WriteLine();
            while (!exit)
            {
                Console.WriteLine(" A : Default behavior (DefaultBehaviorExample)");
                Console.WriteLine(" B : Adding a bookmark for each PDF that is merged (BookmarkForEachPDFExample)");
                Console.WriteLine(" C : Organizing the Bookmarks (OrganizingBookmarksExample)");

                Console.WriteLine();
                Console.Write("Please press the corresponding key to run an example. Press any other key to quit: ");

                ConsoleKeyInfo runKey = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();

                switch (runKey.KeyChar)
                {
                    case 'a': goto case 'A';
                    case 'A':
                        fileName = "DefaultBehaviorExample.pdf";
                        DefaultBehaviorExample.Run(fileName);
                        break;
                    case 'b': goto case 'B';
                    case 'B':
                        fileName = "BookmarkForEachPDFExample.pdf";
                        BookmarkForEachPDFExample.Run(fileName);
                        break;
                    case 'c': goto case 'C';
                    case 'C':
                        fileName = "OrganizingBookmarksExample.pdf";
                        OrganizingBookmarksExample.Run(fileName);
                        break;
                    default:
                        exit = true;
                        break;
                }
                if (!exit)
                {
                    Console.WriteLine("Press 'A' to open the PDF. Press any other key to continue.");
                    ConsoleKeyInfo openKey = Console.ReadKey(true);
                    Console.WriteLine();
                    if (openKey.KeyChar == 'a' || openKey.KeyChar == 'A')
                    {
                        System.Diagnostics.Process.Start(fileName);
                        Console.WriteLine("Please be sure to close the PDF before running the example again, or an error will occur.");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
