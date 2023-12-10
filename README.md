# Python Documentation

# Python File Copy Script

This Python script is designed to copy files from a source directory to a destination directory. The destination directory is created if it does not exist, and the files are copied into a new subdirectory within the destination directory. The subdirectory is named with the current date and time.

## Libraries Used

- `os`: This is a built-in Python library used for interacting with the operating system. In this script, it is used to check if a directory exists, create directories, list the files in a directory, and join paths.

- `shutil`: This is another built-in Python library used for high-level file operations. In this script, it is used to copy files from the source directory to the destination directory.

- `datetime`: This built-in Python library is used for working with dates and times. In this script, it is used to get the current date and time, which is then used to name the new subdirectory in the destination directory.

## How to Use

1. Run the script.
2. When prompted, enter the path to the source directory. This is the directory from which the files will be copied.
3. When prompted, enter the path to the destination directory. This is the directory where the files will be copied to. If this directory does not exist, it will be created.
4. The script will create a new subdirectory within the destination directory, named with the current date and time.
5. The script will then copy all files from the source directory into the new subdirectory in the destination directory.

Please note that this script only copies files, not subdirectories. If there are subdirectories within the source directory, they will be ignored.

---

# C# Documentation

# CSharp File Backup Script

This script is written in CSharp and its main function is to create a backup of a file specified by the user. The backup file is created in the same directory as the original file and has the same name, but with an additional ".bak" extension.

## Script Explanation

The script starts by asking the user to enter the path of the file they want to backup. It then checks if the file exists at the specified path. If the file exists, the script creates a backup of the file. If the file does not exist, the script informs the user that the file does not exist.

## Imported Libraries

The script uses two libraries from the System namespace:

1. `System`: This is a built-in namespace in C#. It provides classes that support the runtime and the base data types used by all applications. In this script, it is used to interact with the console (for reading input and writing output).

2. `System.IO`: This namespace contains types that allow reading and writing to files and data streams, and types that provide basic file and directory support. In this script, it is used to check if a file exists at a specified path and to create a copy of a file.

## Code Breakdown

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

- The script starts by asking the user to enter the file path.
- It then checks if the file exists at the specified path.
- If the file exists, it creates a backup of the file by copying the file to a new file with the same name but with an additional ".bak" extension.
- If the file does not exist, it informs the user that the file does not exist.
- The script then waits for a key press before it ends. This is to prevent the console window from closing immediately after the script has finished executing.

---

# Java Documentation

# BackupTextFileGenerator

This is a simple Java script that takes user input from the console and writes it to a file. The user is prompted to enter the text they want to backup and the name of the file where the backup will be stored. If the operation is successful, a success message is displayed. If an error occurs during the process, an error message is displayed and the stack trace of the exception is printed.

## Imported Libraries

### java.io.BufferedWriter

This is a Java class that provides a character-output stream. It uses a buffer to provide efficient writing of single characters, arrays, and strings.

### java.io.FileWriter

FileWriter is a convenience class for writing character files. The constructors of this class assume that the default character encoding and the default byte-buffer size are acceptable.

### java.io.IOException

This is a checked exception that is thrown when an I/O operation fails for some reason. I/O operations include reading from a file, writing to a file, network communications, database operations, etc.

### java.util.Scanner

This is a simple text scanner which can parse primitive types and strings using regular expressions. It is used in this script to read the user's input from the console.

---
