using System;
using System.IO;

namespace WorkingWithFilesAndFolders
{
    // This program demo. how to explore drives
    class DriveInfoDemo
    {
        static void Main()
        {
            try
            {
                DriveInfo driveInfo = new DriveInfo("D:");
                if (driveInfo.IsReady)
                {
                    Console.WriteLine("Name:{0}",driveInfo.Name);
                    Console.WriteLine("Volume Label:{0}",driveInfo.VolumeLabel);
                    Console.WriteLine("Total Space:{0}-Bytes",driveInfo.TotalSize);
                    Console.WriteLine("Free Space:{0}-Bytes",driveInfo.TotalFreeSpace);
                    Console.WriteLine("Drive Type:{0}",driveInfo.DriveType);
                    Console.WriteLine("Drive Format:{0}",driveInfo.DriveFormat);
                }
                else
                {
                    Console.WriteLine("Drive is Not Ready");
                }

                Console.WriteLine("All available drives are:");
               foreach(var drive in DriveInfo.GetDrives())
                {

                    if (drive.IsReady)
                    {
                        Console.WriteLine("Name:{0}", drive.Name);
                        Console.WriteLine("Volume Label:{0}", drive.VolumeLabel);
                        Console.WriteLine("Total Space:{0}-Bytes", drive.TotalSize);
                        Console.WriteLine("Free Space:{0}-Bytes", drive.TotalFreeSpace);
                        Console.WriteLine("Drive Type:{0}", drive.DriveType);
                        Console.WriteLine("Drive Format:{0}", drive.DriveFormat);
                    }
                }

            }catch(IOException ex)
            {

            }
            Console.ReadLine();
        }
    }
}
