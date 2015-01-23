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
    class SanguoINIHandler
    {
        [DllImport("Kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("Kernel32.dll")]
        static extern bool FreeConsole();

        private ExcelHelper.ExcelHelper excel;

        private bool isFromINI = false;

        private string content;

        private string sheetSystem = "System";
        private string sheetTerrain = "Terrain";
        private string sheetItem = "Item";

        private string sectionName1 = "SYSTEM";
        private string sectionName2 = "TERRAIN";
        private string sectionName3 = "ITEM";


        public void ToExcel(string content, string sourceFile, string outDir)
        {
            AllocConsole();

            this.content = content;

            string filepath = outDir + "\\" + Path.GetFileNameWithoutExtension(sourceFile) + ".xlsx";
            excel = new ExcelHelper.ExcelHelper(filepath, sheetSystem);

            SystemHandler();

            excel.AddSheet(sheetTerrain);
            Handler(sectionName2);

            excel.AddSheet(sheetItem);
            Handler(sectionName3);

            excel.SaveAsFile();

            isFromINI = true;
            ToData(filepath);
        }

        public void ToData(string excelPath)
        {
            if (!isFromINI)
            {
                AllocConsole();
            }

            excel = new ExcelHelper.ExcelHelper(excelPath);

            string saveFileName = Path.GetDirectoryName(excelPath) + "/Data" + Path.GetFileNameWithoutExtension(excelPath) + ".lua";
            FileStream fs = File.Create(saveFileName);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("module(..., package.seeall);");
            sw.WriteLine();

            for (int i = 1; i <= excel.WorkSheetCount; i++)
            {
                excel.SelectCurrentSheet(i);

                sw.WriteLine();
                sw.WriteLine(excel.GetSheetName() + " = {");

                if (excel.GetSheetName() == sheetSystem)
                {
                    for (int row = 1; row <= excel.RowCount; row++)
                    {
                        string key = excel.GetCells(row, 1);
                        string value = excel.GetCells(row, 2);
                        if (string.IsNullOrEmpty(key))
                            continue;

                        sw.WriteLine("\t" + key + " = [[" + value + "]],");
                    }
                }
                else
                {
                    List<string> head = new List<string>();
                    for (int col = 1; col <= excel.ColumnCount; col++)
                    {
                        string text = excel.GetCells(1, col);
                        if (string.IsNullOrEmpty(text))
                            break;
                        head.Add(text);
                    }

                    for (int row = 2; row <= excel.RowCount; row++)
                    {
                        string line = "\t{ ";
                        for (int col = 1; col <= head.Count; col++)
                        {
                            if (!string.IsNullOrEmpty(head[col - 1]))
                            {
                                string text = (string)excel.GetCells(row, col);
                                if (string.IsNullOrEmpty(text))
                                {
                                    line += head[col - 1] + " = '', ";
                                }
                                else if (text.IndexOf(',') < 0)
                                {
                                    text = text.Trim();
                                    line += head[col - 1] + " = [[" + text + "]], ";
                                }
                            }
                        }

                        line += " },";
                        sw.WriteLine(line);
                    }
                }

                sw.WriteLine("}");

                Console.WriteLine("Row:" + excel.RowCount.ToString() + ", Column:" + excel.ColumnCount.ToString());
                Console.WriteLine("输出:" + excel.GetSheetName());
            }

            sw.Flush();
            sw.Close();
            fs.Close();

            excel.Quit();

            if (isFromINI)
            {
                ExcelHelper.ExcelHelper.OpenExcel(excelPath);
            }

            FreeConsole();
        }

        public void ToXML(string excelPath)
        {
            if (!isFromINI)
            {
                AllocConsole();
            }

            excel = new ExcelHelper.ExcelHelper(excelPath);
            for (int i = 1; i <= excel.WorkSheetCount; i++)
            {
                excel.SelectCurrentSheet(i);

                XmlDocument xml = new XmlDocument();
                xml.AppendChild(xml.CreateXmlDeclaration("1.0", "utf-8", ""));
                XmlElement root = xml.CreateElement("root");
                xml.AppendChild(root);

                if (excel.GetSheetName() == sheetSystem)
                {
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
                }
                else
                {
                    List<string> head = new List<string>();
                    for (int col = 1; col <= excel.ColumnCount; col++)
                    {
                        string text = excel.GetCells(1, col);
                        if (string.IsNullOrEmpty(text))
                            break;
                        head.Add(text);
                    }

                    for (int row = 2; row <= excel.RowCount; row++)
                    {
                        XmlElement node = xml.CreateElement("RECORD");
                        for (int col = 1; col <= head.Count; col++)
                        {
                            if (!string.IsNullOrEmpty(head[col - 1]))
                            {
                                string text = (string)excel.GetCells(row, col);
                                if (string.IsNullOrEmpty(text))
                                {
                                    node.SetAttribute(head[col - 1], "");
                                }
                                else if (text.IndexOf(',') < 0)
                                {
                                    text = text.Trim();
                                    node.SetAttribute(head[col - 1], text);
                                }
                                else
                                {
                                    string[] split = text.Split(',');
                                    for (int idx = 0; idx < split.Length; idx++)
                                    {
                                        XmlElement childnode = xml.CreateElement(head[col - 1]);
                                        split[idx] = split[idx].Trim();
                                        childnode.InnerText = split[idx];
                                        node.AppendChild(childnode);
                                    }
                                }
                            }
                        }
                        root.AppendChild(node);
                    }
                }

                string saveFileName = Path.GetDirectoryName(excelPath) + "/" + excel.GetSheetName() + ".xml";
                xml.Save(saveFileName);

                Console.WriteLine("Row:" + excel.RowCount.ToString() + ", Column:" + excel.ColumnCount.ToString());
                Console.WriteLine("输出:" + saveFileName);
            }

            if (isFromINI)
            {
                ExcelHelper.ExcelHelper.OpenExcel(excelPath);
            }

            excel.Quit();
            FreeConsole();
        }

        void SystemHandler()
        {
            Console.WriteLine("sectionName : " + sectionName1);

            List<Dictionary<string, string>> data = INIFileReader.ReadSection(sectionName1, content);

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

        private void Handler(string sectionName)
        {
            Console.WriteLine("sectionName : " + sectionName);

            List<Dictionary<string, string>> data = INIFileReader.ReadSection(sectionName, content);

            //头
            int keyIdx = 1;
            foreach (string key in data[0].Keys)
            {
                excel.SetCells(1, keyIdx, key);
                keyIdx++;
            }

            for (int i = 0; i < data.Count; i++)
            {
                Dictionary<string, string> dic = data[i];
                string SequenceName;
                if (dic.TryGetValue("Sequence", out SequenceName) == false)
                    continue;
                if (string.IsNullOrEmpty(SequenceName))
                    continue;

                int valueIdx = 1;
                foreach (string value in dic.Values)
                {
                    excel.SetCells(i + 2, valueIdx, value);
                    valueIdx++;
                }
            }
        }
    }
}
