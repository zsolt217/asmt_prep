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

        //Protected, hogy a leszármazott osztályakból felül lehessen írni
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing) //Managed resources, ezeket a GC amúgy is felszabadítaná, de így szép
                    //Csak a dispose szakaszban futhat
                {
                    _reader?.Dispose();
                    Console.WriteLine("Disposing of _reader");
                }

                //Nem managelt resources-okat itt kell felszabadítani
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
        //Ha ez megvan írva, mégha üresen is, akkor is ránéz a GC felszabadítási időben (kivéve a SuppressFinalization-t hívunk)
        //Finalization queue-ra kerül, amikor a HEAP-ről takarítja a dolgokat.
        ~FileLoader()
        {
            
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


