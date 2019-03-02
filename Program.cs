/*using System;
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
       
        
          if (File.Exists(file1 + ".txt"))
            {
              Console.WriteLine("File found.\n");
              Console.WriteLine("Enter second file:");
                  string file2 = Console.ReadLine();
  
                    if(File.Exists(file2 + ".txt"))
                     {
                        Console.WriteLine("File found.\n");
                      
                    string postFile = file1 + file2;
                          int count = 0;
                          foreach (char l in postFile)
                          {
                            if (char.IsLetter(l))
                          {
                            count++;
                          }
                      }
                      
                      try
                        {
                            string newFile = (@"C:\" + file1 + file2 + ".txt");
                            string text = System.IO.File.Readtext(file1 + ".txt");
                            text += "\n";
                            text += System.IO.File.Readtext(file2 + ".txt");
                            using (FileStream fs = new FileStream(newFile, FileMode.OpenOrCreate))
                            {
                                System.IO.File.Writetext(newFilePath, allText);
                            }
                            Console.WriteLine("Merged file complete");
                        
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
                        
                            Console.WriteLine("Want to merge more files? (y/n): ");
                          }
                        catch (Exception e)
                        {
                            Console.WriteLine("Excpetion: " + e.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("File not found. Enter valid file:");
                        file2 = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("File not found. Enter valid file:");
                    file1 = Console.ReadLine();
                }
            } while (Console.ReadLine().ToLower().Equals("y"));

                        }
                      }
            
                
            }
       
        
        
         /*string postFile = file1 + file2;
                int count = 0;
                foreach (char l in postFile)
                {
                    if (char.IsLetter(l))
                    {
                        count++;
                    }
                }*/
        
        /*StreamWriter filedoc = null;
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
            } while (Console.ReadLine().ToLower().Equals("y"));*/
        
//      }
//    }
//  }*/

using System;
using System.IO;

namespace DocumentMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application Title
            Console.WriteLine("Document Merger");

            //Operation
            do
            {
                //First File Operation
                Console.WriteLine("Enter name of 1st file:");
                string input1 = Console.ReadLine();
                string f1;

                //When First File is FALSE
                while (File.Exists(input1) == false)
                {
                    Console.WriteLine("File does not exsist, please enter a valid file:");
                    input1 = Console.ReadLine();
                }

                //When First File is TRUE
                if (File.Exists(input1) == true)
                {
                    try
                    {
                        //Writes out First File
                        StreamReader sr1 = new StreamReader(input1);
                        f1 = sr1.ReadLine();
                        while (f1 != null)
                        {
                            Console.WriteLine(f1);
                            f1 = sr1.ReadLine();
                        }
                        sr1.Close();
                        Console.ReadLine();
                    }
                    finally
                    {
                        Console.WriteLine("File has been opened.");
                    }
                }

                Console.WriteLine("\n");

                //Second File Operation
                Console.WriteLine("Enter name of 2nd file:");
                string input2 = Console.ReadLine();
                string f2;

                //When Second File is FALSE
                while (File.Exists(input2) == false)
                {
                    Console.WriteLine("File does not exsist, please enter a valid file:");
                    input2 = Console.ReadLine();
                }

                //When Second File is TRUE
                if (File.Exists(input2) == true)
                {
                    try
                    {
                        //Writes out Second File
                        StreamReader sr2 = new StreamReader(input2);
                        f2 = sr2.ReadLine();
                        while (f2 != null)
                        {
                            Console.WriteLine(f2);
                            f2 = sr2.ReadLine();
                        }
                        sr2.Close();
                        Console.ReadLine();
                    }
                    finally
                    {
                        Console.WriteLine("File has been opened.");
                    }
                }

                Console.WriteLine("\n");

                //Merging Operation
                string docMerge = input1 + input2 + ".txt";
                Console.WriteLine("Documents Being Merged: {0} & {1}", input1, input2);
                Console.WriteLine("New Merged Document Name: {0}", docMerge);

                string path1 = File.ReadAllText(input1);
                string path2 = File.ReadAllText(input2);

                Console.WriteLine("\n");

                //Character Count
                string Content = path1 + path2;
                int charCount = 0;
                foreach (char c in Content)
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
                    doc = new StreamWriter(docMerge);
                    doc.WriteLine(path1);
                    doc.WriteLine(path2);
                    Console.WriteLine("{0} was successfully saved in the current directory. The document contains {1} characters.", docMerge, charCount);
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
                Console.WriteLine("Would you like to merge another set of documents? (Yes or No): ");
            } while (Console.ReadLine().ToLower().Equals("yes"));
        }
    }
}

