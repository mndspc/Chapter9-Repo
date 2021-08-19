using System;
using System.IO;

namespace WorkingWithFilesAndFolders
{
    //  This program demo. how to explore file prop. and how to perform operations over a file using FileInfo
    class FileInfoDemo
    {
        static void Main()
        {
            try
            {
                FileInfo fileInfo = new FileInfo("TestFile.txt");
                if (fileInfo.Exists)
                {
                    Console.WriteLine("Full Name:{0}", fileInfo.FullName);
                    Console.WriteLine("Name:{0}", fileInfo.Name);
                    Console.WriteLine("Extension:{0}", fileInfo.Extension);
                    Console.WriteLine("Size:{0}-Bytes", fileInfo.Length);
                    Console.WriteLine("Created On:{0}", fileInfo.CreationTime);
                    Console.WriteLine("Last Access On:{0}", fileInfo.LastAccessTime);
                    fileInfo.CopyTo(@"D:\MyTestFile.txt", true);
                    Console.WriteLine("File is Copied");

                    FileInfo fileInfo1 = new FileInfo(@"D:\MyTestFile.txt");
                    //fileInfo1.Delete();
                    //Console.WriteLine("File is Deleted");

                    string desktopPath = @"C:\$Recycle.Bin";
                    //fileInfo1.Attributes = FileAttributes.Archive;
                    //fileInfo1.MoveTo(desktopPath);
                    //Console.WriteLine("File is moved to Recycle Bin");

                    string workingDirectory = Environment.CurrentDirectory;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
                Console.ReadLine();
            }
            catch (IOException ex)
            {

            }
        }
    }
}
