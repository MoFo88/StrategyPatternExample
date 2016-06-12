using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select output version:\n\n" +
                              "Simple/s - Simple XML version\n" +
                              "Extended/e - Extended XML version");
            Version version = Version.Unknown;
            bool isVersionProvided = false;
            while (!isVersionProvided)
            {
                var selectedVersion = Console.ReadLine();

                if (Version.TryParse(selectedVersion, true, out version))
                {
                    isVersionProvided = true;
                }
                else
                {
                    Console.WriteLine("Please select valid option...");
                }
            }

            if (version != Version.Unknown)
            {

            }
        }
    }
}
