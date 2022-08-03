using System;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

/// <summary>
///  Task4 - Implement loading a text file, make sure your class implements IDisposable Interface correctly
/// </summary>
namespace ASMT_prep
{
    public class FileLoader : IDisposable
    {
        //unmanaged class
        private StreamReader _reader;
        private bool disposedValue;
        private string path;

        public FileLoader(string path)
        {
            this.path = path;
        }

        public void StartReading()
        {
            _reader = new StreamReader(path);
        }

        public string Read()
        {
            if (_reader == null)
                return String.Empty;

            return _reader.ReadToEnd();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _reader?.Dispose();
                    Console.WriteLine("Disposing of _reader");
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            //As we don't have Finalize method, we dont need it.
            //It would tell the GC to skip calling that method.
            GC.SuppressFinalize(this);
        }
    }


    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine();
    //        }
    //    }
}


