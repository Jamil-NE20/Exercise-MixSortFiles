using System;
using System.Collections;
using System.IO;
using System.Text;

namespace MixSortFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            String File1, File2;
            String line;
            Console.Write("Enter the name of the File1: ");
            File1 = Console.ReadLine();
            
            Console.Write("Enter the name of the File2: ");
            File2 = Console.ReadLine();

           
            try
            {

               StreamReader myFile = File.OpenText(File1);
               
                ArrayList myList = new ArrayList();

                do
                {
                    line = myFile.ReadLine();
                    
                    if (line != null)
                        myList.Add(line);
                }

                while (line != null);
                myFile.Close();

               myFile = File.OpenText(File2);
                
                line = "";

                do
                {
                    line = myFile.ReadLine();
                    
                    if (line != null)
                        myList.Add(line);
                }

                while (line != null);
                myFile.Close();

                myList.Sort();
                for (int i = 0; i < myList.Count; i++)
                    Console.WriteLine(myList[i]);

            }
            catch (IOException e)
            {
                Console.WriteLine("We have error! File is not read! Try to check it's again.");
                //Console.WriteLine(e.Message);

            }
            if ((!File.Exists(File1)) || (!File.Exists(File2)))
            {
                Console.WriteLine(" File1 or File2 is not exists");
                return;
            }

        }
    }
}
