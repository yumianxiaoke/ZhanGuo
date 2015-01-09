using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace sg2toxml
{
    public class ThingsToXML
    {
        private int soliderSeqStart = 100;
        private int soliderSeqEnd = 172;

        private XmlDocument xml;

        public void ToXML(byte[] bytes, string saveFileName)
        {
            string content = ToSimplifiedHelper.ToSimplified(System.Text.Encoding.UTF8.GetString(bytes));

            //XML
            xml = new XmlDocument();
            // 添加文档定义        
            xml.AppendChild(xml.CreateXmlDeclaration("1.0", "utf-8", ""));
            XmlElement root = xml.CreateElement("root");
            xml.AppendChild(root);

            //添加士兵数据结点
            XmlElement soldier = xml.CreateElement("Soldier");
            root.AppendChild(soldier);

            List<Dictionary<string, string>> data = INIFileReader.ReadSection("OBJECT", content);
            for (int i = 0; i < data.Count; i++)
            {
                Dictionary<string, string> dic = data[i];
                string SequenceName;
                if (dic.TryGetValue("Sequence", out SequenceName) == false)
                    continue;
                if (string.IsNullOrEmpty(SequenceName))
                    continue;

                int Sequence = Convert.ToInt32(SequenceName);
                if (Sequence >= soliderSeqStart && Sequence <= soliderSeqEnd)
                {
                    HandlerSolider(dic, soldier);
                }
            }

            xml.Save(saveFileName);
            xml = null;
        }

        private void HandlerSolider(Dictionary<string, string> dic, XmlElement soldier)
        {
            XmlElement node = xml.CreateElement("RECORD");
            IEnumerator<string> enumerator = dic.Keys.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string key = enumerator.Current;
                node.SetAttribute(key, dic[key]);
            }
            soldier.AppendChild(node);
        }
    }


}
