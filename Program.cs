using System;
using ceTe.DynamicPDF;
using CustomXmpSchemas.Examples;

namespace CustomXmpSchemas
{

    class Program
    {
        static void Main(string[] args)
        {
            string fileName = string.Empty;
            bool exit = false;
            Console.WriteLine("This example shows how to create a custom XMP schema when creating PDFs with DynamicPDF Generator for .NET");
            Console.WriteLine();
            while (!exit)
            {
                Console.WriteLine(" A : Custom XMP schema (CustomSchemaExample)");

                Console.WriteLine();
                Console.Write("Please press the corresponding key to run an example. Press any other key to quit: ");

                ConsoleKeyInfo runKey = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();

                switch (runKey.KeyChar)
                {
                    case 'a': goto case 'A';
                    case 'A':
                        fileName = "CustomSchemaExample.pdf";
                        CustomSchemaExample.Run(fileName);
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
