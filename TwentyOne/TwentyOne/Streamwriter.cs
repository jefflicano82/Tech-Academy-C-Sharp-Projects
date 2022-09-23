using System.IO;

namespace TwentyOne
{
    internal class Streamwriter : StreamWriter
    {
        public Streamwriter(string path, bool append) : base(path, append)
        {
        }
    }
}