using System;
using System.IO;

namespace DocumentMerger
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Document Merger");
            Console.WriteLine("\n");

            do
            {
                
                Console.WriteLine("Enter first file:");
                string file1 = Console.ReadLine();
                string f1;

                while (File.Exists(file1) == false)
                {
                    Console.WriteLine("Not found. Please put in valid file:");
                    file1 = Console.ReadLine();
                }
              
              
                if (File.Exists(file1) == true)
                {
                    try
                    {
                        StreamReader first = new StreamReader(file1);
                        f1 = first.ReadLine();
                        while (f1 != null)
                        {
                            Console.WriteLine(f1);
                            f1 = first.ReadLine();
                        }
                        first.Close();
                        Console.ReadLine();
                    }
                    finally
                    {
                        Console.WriteLine("File opened.\n");
                    }
                }


                Console.WriteLine("Enter second file:");
                string file2 = Console.ReadLine();
                string f2;

                while (File.Exists(file2) == false)
                {
                    Console.WriteLine("Not found. Please put in valid file:");
                    file2 = Console.ReadLine();
                }

                if (File.Exists(file2) == true)
                {
                    try
                    {
                        //Writes out Second File
                        StreamReader second = new StreamReader(file2);
                        f2 = second.ReadLine();
                        while (f2 != null)
                        {
                            Console.WriteLine(f2);
                            f2 = second.ReadLine();
                        }
                        second.Close();
                        Console.ReadLine();
                    }
                    finally
                    {
                        Console.WriteLine("File opened.\n");
                    }
                }


                string mergedFile = file1 + file2 + ".txt";
                Console.WriteLine("Merged File Name: {0}", mergedFile);

                string context1 = File.ReadAllText(file1);
                string context2 = File.ReadAllText(file2);

                Console.WriteLine("\n");

                //Character Count
                string ContentMerge = file1 + file2;
                int charCount = 0;
                foreach (char c in ContentMerge)
                {
                    if (char.IsLetter(c))
                    {
                        charCount++;
                    }
                }

                //Writing of Merged Documents
                StreamWriter doc = null;
                try
                {
                    doc = new StreamWriter(mergedFile);
                    doc.WriteLine(context1);
                    doc.WriteLine(context2);
                    Console.WriteLine("{0} was successfully saved in the current directory. The document contains {1} characters.", mergedFile, charCount);
                    doc.Close();
                }
                catch (Exception e1)
                {
                    Console.WriteLine("Exception: " + e1.Message);
                }
                finally
                {
                    if (doc != null)
                    {
                        doc.Close();
                    }
                }
                Console.WriteLine("Do you want to merge more files? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }
    }
}

