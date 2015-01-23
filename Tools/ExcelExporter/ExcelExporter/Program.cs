using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelExporter
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();

            Console.Write("Press any key to continue ");
            Console.ReadLine();
        }

        static void DoWork()
        {
            string dir = Environment.CurrentDirectory;
            List<string> listFiles = FindFiles.FindFilesName(dir);

            Console.WriteLine("待处理文件个数:" + listFiles.Count);

            foreach (string file in listFiles)
            {
                Export export = new Export(file);

                Console.WriteLine(file.Substring(dir.Length + 1) + "  完成!");
            }
        }
    }
}
