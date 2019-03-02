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
            Console.WriteLine("Document Merger");
            do
            {
                string doc1 = GetValidDocument();
                string doc2 = GetValidDocument();
                string mergedFileName = doc1.Substring(0, doc1.Length - 4) + doc2;
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(mergedFileName);
                    int count = WriteFileContents(writer, doc1);
                    count += WriteFileContents(writer, doc2);
                    Console.WriteLine("{0} was saved successfully. There are {1} characters", mergedFileName);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error writing to {0}: {1}", mergedFileName, e.Message);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
                Console.Write("\nWould you like to merge two more documents? (y/n): ");
            }
            while (Console.ReadLine().ToLower() == "y");
        }

        static string GetValidDocument()
        {
            Console.Write("Enter the name of a document: ");
            string doc;
            while ((doc = Console.ReadLine()).Length == 0 || !File.Exists(doc))
            {
                Console.Write("Document not found, enter a valid document name: ");
            }
            return doc;
        }

        static int WriteFileContents(StreamWriter writer, string file)
        {
            StreamReader reader = null;
            int count = 0;
            try
            {
                reader = new StreamReader(file);
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    count += line.Length;
                    writer.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error writing {0} to new file: {1}", file, e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return count;
        }
    }
}

