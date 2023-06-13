using System.IO;
namespace Exception__and__Filefunction
{
    class Files
    {
        public static void Filemethods()
        {
            //File.Exists
            string filePath1 = @"C:\C# Seran Works\c# notepad\alpha.txt";
            if (File.Exists(filePath1))
            {
                Console.WriteLine("File exists" + "\n");
            }
            else
            {
                Console.WriteLine("File does not exist" + "\n");
            }

            //File.Open
            string filePath2 = @"C:\C# Seran Works\c# notepad\alpha.txt";
            using (FileStream fileStream = File.Open(filePath2, FileMode.Open))
            {
                Console.WriteLine("opening the file" + "\n");
            }

            //File.create
            string filePath3 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\File creation\file creation.txt";
            using (FileStream fileStream = File.Create(filePath3))
            {
                Console.WriteLine("creating new file" + "\n");
            }


            //File.Write
            string filePath4 = filePath3;
            string content1 = "Iam learning c#";
            File.WriteAllText(filePath4, content1);
            Console.WriteLine("writting text in file" + "\n");

            //File.read
            string filePath5 = filePath3;
            File.ReadAllText(filePath5);
            Console.WriteLine("reading a file" + "\n");

            //File.append
            string filePath6 = filePath3;
            string content2 = ("\n" + "and also html and css");
            File.AppendAllText(filePath6, content2);
            Console.WriteLine("adding extra content" + "\n");

            //File.delete
            string filePath7 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\File delete\New Text Document.txt";
            File.Delete(filePath7);
            Console.WriteLine("deleting a file" + "\n");

            /*//File.move
            string filePath8 = filePath3;
            string destinationFilePath = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\File move\file move.txt";
            File.Move(filePath8, destinationFilePath);
            Console.WriteLine("moving  a file");*/

            /*//File.copy
            string filePath9 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\File move\file move.txt";
            string copyPath = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\File copy\file copy.txt";
            File.Copy(filePath9, copyPath);
            Console.WriteLine("copying a file");*/

            //File.time
            string filePath10 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\File move\file move.txt";
            DateTime lastWriteTime = File.GetLastWriteTime(filePath10);
            Console.WriteLine("Last write time: " + lastWriteTime + "\n");

        }
    }

}
