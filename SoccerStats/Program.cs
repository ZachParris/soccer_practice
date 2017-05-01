using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var filename = Path.Combine(directory.FullName, "SoccerGameResults.csv");
        }

        public static string ReadFile(string FileName)
        {
            using(var reader = new StreamReader(FileName))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
