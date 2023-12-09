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
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}