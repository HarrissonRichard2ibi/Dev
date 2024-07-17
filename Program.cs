using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "/DevOps.txt", "Dev Ops Demon \n");
        }
    }
}
