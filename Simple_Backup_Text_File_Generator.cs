```CSharp
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the file path:");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            string backupPath = filePath + ".bak";

            File.Copy(filePath, backupPath, true);

            Console.WriteLine("Backup created at " + backupPath);
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }

        Console.ReadKey();
    }
}
```