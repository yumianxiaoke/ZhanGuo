using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;

using System.Runtime.InteropServices;

namespace sg2toxml
{
    class MessageHandler
    {
        [DllImport("Kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("Kernel32.dll")]
        static extern bool FreeConsole();

        private ExcelHelper.ExcelHelper excel;

        private bool isFromINI = false;

        private string content;

        private string sheetName = "Message";
        private string sectionName = "MESSAGE";

        public void ToExcel(string content, string sourceFile, string outDir)
        {
            AllocConsole();

            this.content = content;

            string filepath = outDir + "\\" + Path.GetFileNameWithoutExtension(sourceFile) + ".xlsx";
            excel = new ExcelHelper.ExcelHelper(filepath, sheetName);

            Handler(sectionName);

            excel.SaveAsFile();

            isFromINI = true;
            ToXML(filepath);
        }

        public void ToXML(string excelPath)
        {
            if (!isFromINI)
            {
                AllocConsole();
            }

            excel = new ExcelHelper.ExcelHelper(excelPath);

            XmlDocument xml = new XmlDocument();
            xml.AppendChild(xml.CreateXmlDeclaration("1.0", "utf-8", ""));
            XmlElement root = xml.CreateElement("root");
            xml.AppendChild(root);

            for (int row = 1; row <= excel.RowCount; row++)
            {
                string key = excel.GetCells(row, 1);
                string value = excel.GetCells(row, 2);
                if (string.IsNullOrEmpty(key))
                    continue;
                XmlElement node = xml.CreateElement(key);
                node.InnerText = value;
                root.AppendChild(node);
            }

            string saveFileName = Path.GetDirectoryName(excelPath) + "/" + excel.GetSheetName() + ".xml";
            xml.Save(saveFileName);

            Console.WriteLine("Row:" + excel.RowCount.ToString() + ", Column:" + excel.ColumnCount.ToString());
            Console.WriteLine("输出:" + saveFileName);

            if (isFromINI)
            {
                ExcelHelper.ExcelHelper.OpenExcel(excelPath);
            }

            excel.Quit();
            FreeConsole();
        }

        private void Handler(string sectionName)
        {
            Console.WriteLine("sectionName : " + sectionName);

            List<Dictionary<string, string>> data = INIFileReader.ReadSection(sectionName, content);

            int row = 1;
            Dictionary<string, string> dic = data[0];
            foreach (string key in dic.Keys)
            {
                string value = dic[key];
                if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(value))
                {
                    continue;
                }

                excel.SetCells(row, 1, key);
                excel.SetCells(row, 2, value);
                row++;
            }
        }
    }
}
