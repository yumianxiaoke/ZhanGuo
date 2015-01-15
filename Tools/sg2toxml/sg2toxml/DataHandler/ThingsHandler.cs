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
    public class ThingsHandler
    {
        private int sequenceNum = 11;
        private int[, ] sequenceRange = new int[11, 2];

        private ExcelHelper.ExcelHelper excel;

        private bool isFromINI = false;

        private string content;

        private string sheetSystem = "System";
        private string sheetDefine = "Define";

        private string sectionName1 = "SYSTEM";
        private string sectionName2 = "DEFINE";
        private string sectionName3 = "OBJECT";

        private string[] sheetName = new string[] {
            "Troop",
            "Flags",
            "Soldier",
            "DeadHorse",
            "ThrownWeapon",
            "General",
            "General",
            "Weapon",
            "Horse",
            "Scene",
            "Magic",
        };

        [DllImport("Kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("Kernel32.dll")]
        static extern bool FreeConsole();

        public void ToExcel(string content, int[, ] sequenceRange, string saveFileName)
        {
            AllocConsole();

            this.sequenceRange = sequenceRange;

            this.content = content;

            //Excel
            string filepath = Path.GetDirectoryName(saveFileName) + "\\" + Path.GetFileNameWithoutExtension(saveFileName) + ".xlsx";
            excel = new ExcelHelper.ExcelHelper(filepath, sheetSystem);
            
            SystemHandler();
            DefineHandler();
            ObjectsHandler();

            excel.SaveAsFile();

            isFromINI = true;
            ToXML(filepath);
        }

        /// <summary>
        /// 系统
        /// </summary>
        private void SystemHandler()
        {
            List<Dictionary<string, string>> data = INIFileReader.ReadSection(sectionName1, content);
            string title = "TotalObjectDefine";
            string value = data[0][title];

            excel.SetCells(1, 1, title);
            excel.SetCells(1, 2, value);

            Console.WriteLine("SystemHandler");
        }

        private void DefineHandler()
        {
            excel.AddSheet(sheetDefine);

            List<Dictionary<string, string>> data = INIFileReader.ReadSection(sectionName2, content);

            int i = 1;
            Dictionary<string, string> values = data[0];
            foreach(string key in values.Keys)
            {
                excel.SetCells(i, 1, key);
                excel.SetCells(i, 2, values[key]);
                i++;
            }

            Console.WriteLine("DefineHandler");
        }

        /// <summary>
        /// 士兵
        /// </summary>
        private void ObjectsHandler()
        {
            List<Dictionary<string, string>> data = INIFileReader.ReadSection(sectionName3, content);

            string currentSheetName = "";
            int currentRow = 2;

            for (int i = 0; i < data.Count; i++)
            {
                Dictionary<string, string> dic = data[i];
                string SequenceName;
                if (dic.TryGetValue("Sequence", out SequenceName) == false)
                    continue;
                if (string.IsNullOrEmpty(SequenceName))
                    continue;
                int Sequence = Convert.ToInt32(SequenceName);

                for (int j = 0; j < sequenceNum; j++)
                {
                    if (Sequence >= sequenceRange[j, 0] && Sequence <= sequenceRange[j, 1])
                    {
                        if (currentSheetName != sheetName[j])
                        {
                            currentSheetName = sheetName[j];
                            excel.AddSheet(currentSheetName);
                            currentRow = 2;

                            //头
                            int keyIdx = 1;
                            foreach (string key in dic.Keys)
                            {
                                excel.SetCells(1, keyIdx, key);
                                keyIdx++;
                            }

                            Console.WriteLine("currentSheetName : " + currentSheetName);
                        }
                    }
                }

                int valueIdx = 1;
                foreach (string value in dic.Values)
                {
                    excel.SetCells(currentRow, valueIdx, value);
                    valueIdx++;
                }
                currentRow++;
            }
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

                if (excel.GetSheetName() == sheetSystem || excel.GetSheetName() == sheetDefine)
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
    }


}
