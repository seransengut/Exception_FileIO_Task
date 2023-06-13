using System.IO;

namespace Exception__and__Filefunction
{
    public class Driveinfo
    {
        public static void driveinfo()
        {

            DriveInfo info = new DriveInfo("c");

            Console.WriteLine("Drive Name: " + info.Name + "\n");

            Console.WriteLine("Drive Type: " + info.DriveType + "\n");

            Console.WriteLine("Drive Format: " + info.DriveFormat + "\n");

            Console.WriteLine("Drive Free Space: " + info.TotalFreeSpace + "\n");

            Console.WriteLine("Drive Total Size: " + info.TotalSize + "\n");

            Console.WriteLine("Drive Available Free Space: " + info.AvailableFreeSpace + "\n");

            Console.WriteLine("Is Drive Ready: " + info.IsReady + "\n");

            Console.WriteLine("Volume Label: " + info.VolumeLabel + "\n");

            Console.WriteLine("Root Directory: " + info.RootDirectory);


        }
    }
}
