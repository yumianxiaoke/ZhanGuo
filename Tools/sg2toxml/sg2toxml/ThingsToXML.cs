using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;

namespace sg2toxml
{
    public class ThingsToXML
    {
        private int sequenceNum = 11;
        private int[, ] sequenceRange = new int[, ]{
            {51, 54},//军队
            {1, 42},//旗子
            {100, 172},//士兵
            {180, 195},//士兵死亡后的马
            {500, 503},//远程武器
            {600, 659},//武将身体(已)
            {800, 859},//武将身体(敌)
            {700, 779},//武器
            {900, 917},//马
            {400, 404},//场景
            {10003, 51001}//武将技
        };

        //private XmlDocument xml;
        private ExcelHelper.ExcelHelper excel;

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

        public void ToExcel(byte[] bytes, string saveFileName)
        {
            content = ToSimplifiedHelper.ToSimplified(System.Text.Encoding.UTF8.GetString(bytes));

            //Excel
            string filepath = Path.GetDirectoryName(saveFileName) + "\\" + Path.GetFileNameWithoutExtension(saveFileName) + ".xlsx";
            excel = new ExcelHelper.ExcelHelper(filepath, sheetSystem);
            
            SystemHandler();
            DefineHandler();
            ObjectsHandler();

            excel.SaveAsFile();
            ExcelHelper.ExcelHelper.OpenExcel(filepath);

            //XML
//             xml = new XmlDocument();
//             xml.AppendChild(xml.CreateXmlDeclaration("1.0", "utf-8", ""));
//             XmlElement root = xml.CreateElement("root");
//             xml.AppendChild(root);
//             HandlerSolider(root);
// 
//             xml.Save(saveFileName);
//             xml = null;
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

        //添加士兵数据结点
//         private void HandlerSolider(XmlElement root)
//         {
//             XmlElement soldier = xml.CreateElement(sheet3);
//             root.AppendChild(soldier);
// 
//             List<Dictionary<string, string>> data = INIFileReader.ReadSection("OBJECT", content);
//             for (int i = 0; i < data.Count; i++)
//             {
//                 Dictionary<string, string> dic = data[i];
//                 string SequenceName;
//                 if (dic.TryGetValue("Sequence", out SequenceName) == false)
//                     continue;
//                 if (string.IsNullOrEmpty(SequenceName))
//                     continue;
// 
//                 int Sequence = Convert.ToInt32(SequenceName);
//                 if (Sequence >= seqStart3 && Sequence <= seqEnd3)
//                 {
//                     XmlElement node = xml.CreateElement("RECORD");
//                     IEnumerator<string> enumerator = dic.Keys.GetEnumerator();
//                     while (enumerator.MoveNext())
//                     {
//                         string key = enumerator.Current;
//                         node.SetAttribute(key, dic[key]);
//                     }
//                     soldier.AppendChild(node);
//                 }
//             }
//         }
    }


}
