using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Transferência iniciada em " + DateTime.Now);
                var array = new Data().GetFileNameArray();

                foreach (var item in array)
                {
                    string fileName = item;
                    string sourcePath = @"E:\Documents";
                    string targetPath = @"E:\Documents\SubFolder";

                    // Use Path class to manipulate file and directory paths.
                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                    string destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(sourceFile, destFile, true);

                    Console.WriteLine("Arquivo " + fileName + " transferido com sucesso");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Transferência(s) realizada(s) com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para fechar.");
                Console.ReadLine();
            }
        }
    }
}
