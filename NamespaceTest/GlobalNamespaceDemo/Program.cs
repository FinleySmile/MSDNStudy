using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo di = new DriveInfo(@"c:\");
            Console.WriteLine("AvailableFreeSpace: {0}", di.AvailableFreeSpace);
            Console.WriteLine("RootDirectory Name:{0}", di.RootDirectory.FullName);

            var allFiles = di.RootDirectory.GetFiles("*.*");
            var allDirectories = di.RootDirectory.GetDirectories();


            foreach (var file in allFiles)
            {
                Console.WriteLine("directoryName:{0}, FileName:{1}",file.DirectoryName,file.Name);
            }


            foreach (var dir in allDirectories)
            {
                Console.WriteLine("DirectorieyName:{0}",dir.Name);
            }
        }
    }
}
