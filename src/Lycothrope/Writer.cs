using System;

namespace Lycothrope
{
    public class Writer : IWriter
    {
        public Writer()
        {
        }

        public void Write()
        {
            Console.WriteLine("Invoked.");
        }
    }
}

