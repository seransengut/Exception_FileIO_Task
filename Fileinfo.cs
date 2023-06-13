namespace Exception__and__Filefunction
{
    public class Fileinfo
    {
        public static void Fileinfos()
        {
            //File.exists
            string filePath1 = @"C:\C# Seran Works\c# notepad\alpha.txt";
            FileInfo fileInfo = new FileInfo(filePath1);
            if (fileInfo.Exists)
            {
                Console.WriteLine("File exists" + "\n");
            }
            else
            {
                Console.WriteLine("File does not exist" + "\n");
            }

            //File.name
            string filePath2 = @"C:\C# Seran Works\c# notepad\alpha.txt";
            FileInfo fileInfo1 = new FileInfo(filePath2);
            string fileName = fileInfo1.Name;
            Console.WriteLine("File name: " + fileName + "\n");

            //File.length
            string filePath3 = filePath2;
            FileInfo fileInfo2 = new FileInfo(filePath3);
            long fileSize = fileInfo2.Length;
            Console.WriteLine("File size: " + fileSize + " bytes" + "\n");

            //File.extension
            string filePath4 = filePath2;
            FileInfo fileInfo3 = new FileInfo(filePath4);
            string fileExtension = fileInfo3.Extension;
            Console.WriteLine("File extension: " + fileExtension + "\n");

            //File.directory
            string filePath5 = filePath2;
            FileInfo fileInfo4 = new FileInfo(filePath5);
            DirectoryInfo directory = fileInfo4.Directory;
            Console.WriteLine("Parent directory: " + directory.FullName + "\n");

            //File.time
            string filePath6 = filePath2;
            FileInfo fileInfo5 = new FileInfo(filePath6);
            DateTime creationTime = fileInfo5.CreationTime;
            Console.WriteLine("Creation time: " + creationTime + "\n");

            //File.time
            string filePath7 = filePath2;
            FileInfo fileInfo6 = new FileInfo(filePath7);
            DateTime lastWriteTime = fileInfo6.LastWriteTime;
            Console.WriteLine("Last write time: " + lastWriteTime + "\n");

            //File.copy
            string sourceFilePath1 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\File copy\file copy.txt";
            string destinationFilePath1 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\Fileinfo copy\Fileinfo copy.txt";
            FileInfo fileInfo7 = new FileInfo(sourceFilePath1);
            fileInfo7.CopyTo(destinationFilePath1, true);
            Console.WriteLine("copying a file"+"\n");

           /* //File.move
            string sourceFilePath2 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\File creation\file creation.txt";
            string destinationFilePath2 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\Fileinfo move\Fileinfo move.txt";
            FileInfo fileInfo8 = new FileInfo(sourceFilePath2);
            fileInfo8.MoveTo(destinationFilePath2);
            Console.WriteLine("moving a file"+"\n");*/

            //File.delete
            string filePath8 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\Fileinfo delete\Fileinfo delete.txt";
            FileInfo fileInfo9 = new FileInfo(filePath8);
            fileInfo9.Delete();
            Console.WriteLine("deleting a file");

        }

    }
}
