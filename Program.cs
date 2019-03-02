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
        
      }
    }
  }

