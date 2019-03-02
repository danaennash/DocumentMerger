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
        
          while (File.Exists(file1) == false)
            {
             Console.WriteLine("Not found. Please enter valid file:");
             file1 = Console.ReadLine();
            }
        
          if (File.Exists(file1 + ".txt") == true)
            {
              Console.WriteLine("File found.\n");
            }
        
        Console.WriteLine("Enter second file:");
          string file2 = Console.ReadLine();
        
          while (File.Exists(file2) == false)
            {
              Console.WriteLine("Not found. Please enter valid file:");
              file1 = Console.ReadLine();
            }
        
          if(File.Exists(file2 + ".txt") == true)
            {
              Console.WriteLine("File found.\n");
            }
        
        string mergedFile = file1 + file2 + ".txt";
        Console.WriteLine("Merged File Name: {0}\n", mergedFile);
        
         string postFile = file1 + file2;
                int count = 0;
                foreach (char l in postFile)
                {
                    if (char.IsLetter(l))
                    {
                        count++;
                    }
                }
        
        StreamWriter filedoc = null;
                try
                {
                    filedoc = new StreamWriter(mergedFile);
                    filedoc.WriteLine(file1);
                    filedoc.WriteLine(file2);
                    Console.WriteLine("{0} was successfully saved in the current directory. The document contains {1} characters.", mergedFile, count);
                    filedoc.Close();
                }
                catch (Exception e1)
                {
                    Console.WriteLine("Exception: " + e1.Message);
                }
                finally
                {
                    if (filedoc != null)
                    {
                        filedoc.Close();
                    }
                }
                Console.WriteLine("Would you like to merge another file? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        
      }
    }
  }

