using System;

namespace SOLID.IO
{
    public class Writer : IWriter
    {
        void IWriter.Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
