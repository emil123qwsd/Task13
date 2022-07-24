using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Build build = new Build("Лукина", 100.0, 80.0, 30.0);
            Console.WriteLine(build.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Амирхана", 100.0, 80.0, 30.0, 10);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
