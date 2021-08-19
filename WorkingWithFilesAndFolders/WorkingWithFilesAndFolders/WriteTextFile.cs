using System;
using System.IO;

namespace WorkingWithFilesAndFolders
{
    //  How to create and write text inside .txt file using FileStream and StreamWriter
    class WriteTextFile
    {
        static void Main()
        {
            try
            {
                FileInfo fileInfo = new FileInfo("TestFile.txt");

                FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write);
                //Create StreamWriter object to write content from fileStream
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine("This is Test Message");
                streamWriter.Close();
                fileStream.Close();
                Console.WriteLine("File Created Successfully");
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
