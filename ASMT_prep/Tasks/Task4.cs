using System;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;


/// <summary>
///  Task4 - Implement loading a text file, make sure your class implements IDisposable Interface correctly
/// </summary>
namespace dev
{
    public class FileLoader
    {
        private string path;

        public FileLoader(string path)
        {
            this.path = path;
        }

        public string Read()
        {
            ///... implement
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}


