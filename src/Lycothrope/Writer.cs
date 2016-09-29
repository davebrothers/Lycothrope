using System;

namespace Lycothrope
{
    public class Writer : IWriter
    {
        public Writer()
        {
        }

        public void WriteToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}

