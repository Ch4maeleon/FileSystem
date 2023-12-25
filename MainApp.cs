using System;
using System.IO;

namespace FileSystem
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\ch4maeleon\Desktop\FAT32_simple.mdf";

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    byte[] buffer = new byte[fs.Length];
                    int bytesRead = fs.Read(buffer, 0, buffer.Length);

                    for (int i = 0; i < 400; i++)
                    {
                        Console.Write($"{buffer[i]:X2} ");
                        if ((i + 1) % 16 == 0)
                            Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
