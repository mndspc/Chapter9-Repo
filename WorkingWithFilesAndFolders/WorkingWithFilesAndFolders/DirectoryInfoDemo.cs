using System;
using System.IO;

namespace WorkingWithFilesAndFolders
{
    //  This program demo. hoe to work with Directories using DirectoryInfo Class
    class DirectoryInfoDemo
    {
        static void Main()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("MyFolder");
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                Console.WriteLine("Folder is Created");
            }
            else
            {
                Console.WriteLine("Full Name:{0}",directoryInfo.FullName);
                Console.WriteLine("Name:{0}",directoryInfo.Name);
                Console.WriteLine("Creation Date:{0}",directoryInfo.CreationTime);
                Console.WriteLine("Last Access:{0}",directoryInfo.LastAccessTime);

                Console.WriteLine("all sub-folder from MyFolder");
                // Get sub-folders
               foreach(var dir in directoryInfo.GetDirectories())
                {
                    Console.WriteLine(dir.Name);
                    dir.Delete();
                }
                //  Get Files
                Console.WriteLine("all files from MyFolder");
                foreach (var file in directoryInfo.GetFiles())
                {
                    Console.WriteLine(file.Name);
                    file.Delete();
                }
            }
            Console.ReadLine();
        }
    }
}
