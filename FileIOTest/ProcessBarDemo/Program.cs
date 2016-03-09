using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace ProcessBarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string srcPath = @"D:\aaa";
            //string destPath = @"E:\aaa";
            //FileSystem.CopyDirectory(srcPath,destPath);

         //   Write();
            string aa = "helloworld";
            var copy = aa.ToLowerInvariant();
            
        }

        public static void Write()
        {
            string path = @"d:/a.txt";
            string content = "Hello World";
            using(var writer = new StreamWriter(path))
            {
                writer.WriteLine(content);
            }
        }
    }
}
