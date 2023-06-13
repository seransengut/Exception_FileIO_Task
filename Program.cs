using System;
using Exception__and__Filefunction;
using Directory = Exception__and__Filefunction.Directory;

namespace excep_file
{
    class Exceptions
    {
        public static void trycatch()
        {
            //first value from user 
            Console.WriteLine("Enter first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            //second value from user 
            Console.WriteLine("Enter second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            try
            {

                int divisionResult = firstNumber / secondNumber;
                Console.WriteLine("Division of two numbers is: " + divisionResult);
            }


            catch (Exception message)
            {
                Console.WriteLine("An exception occurred: " + message);
                //throw message;
            }

            finally
            {

                Console.WriteLine("Sum of two numbers is: " + (firstNumber + secondNumber));
            }


        }
    }

    class main
    {
        public static void Main(string[] args)
        {
            Exceptions.trycatch();
            Files.Filemethods();
            Fileinfo.Fileinfos();
            Paths.path();
            Directory.directory();
            Driveinfo.driveinfo();
        }
    }


}