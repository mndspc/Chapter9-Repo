using System;
using System.IO;
using System.Net.Sockets;

namespace WorkingWithFilesAndFolders
{
    class Program
    {
        //FileStream: reads or writes bytes from/to a physical file, whether it is a .txt, .exe, .jpg, or any other file. 
        //MemoryStream:MemoryStream reads or writes bytes that are stored in memory.
        //BufferedStream:BufferedStream reads or writes bytes from other Streams to improve certain I/O operations' performance.
        //NetworkStream:NetworkStream reads or writes bytes from a network socket.

        //  How to read text from .txt file using FileStream and StreamReader class
        static void Main(string[] args)
        {
            try
            {
                // FileInfo class hold reference of file from physical path
                FileInfo fileInfo = new FileInfo("try.txt");
                //FileInfo fileInfo = new FileInfo(@"D:\Folder\try.txt");

                //Open a file for reading/writing
                FileStream fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read);

                //  To read content from FileStream, create an object of StreamReader class
                StreamReader streamReader = new StreamReader(fileStream);

                //  To read content call ReadToEnd()
                string content = streamReader.ReadToEnd();

                Console.WriteLine(content);

                streamReader.Close();
                fileStream.Close();
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
