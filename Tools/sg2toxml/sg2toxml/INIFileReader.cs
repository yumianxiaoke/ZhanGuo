using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace sg2toxml
{
    public static class INIFileReader
    {
        /// <summary>
        /// 去掉注释和空白字符
        /// </summary>
        private static string Trim(string line)
        {
            string trim = line.Trim();

            int index = trim.IndexOf(';');
            if (index >= 0)
                trim = trim.Substring(0, index);

            return trim.Trim();
        }

        /// <summary>
        /// 判断该行是否是段落
        /// </summary>
        private static bool IsSection(string line)
        {
            if (line.StartsWith("[") && line.EndsWith("]"))
                return true;
            return false;
        }

        /// <summary>
        /// 获取段的名字,使用前必须判断是否是断
        /// </summary>
        private static string GetSectionName(string line)
        {
            if (IsSection(line))
                return line.Substring(1, line.Length - 2);

            return null;
        }

        /// <summary>
        /// 获取键和值, 使用前必须判断该行是否为空
        /// </summary>
        private static void GetKeyAndValue(string line, out string key, out string value)
        {
            key = null;
            value = null;

            if (string.IsNullOrEmpty(line) || line.IndexOf('=') < 0)
            {
                return;
            }

            string[] split = line.Split('=');
            if (split.Length != 2)
                return;

            key = split[0].Trim();
            value = split[1].Trim();
        }

        /// <summary>
        /// 获取所有的段的信息
        /// </summary>
        public static List<Dictionary<string, string>> ReadSection(string sectionName, string content)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            string[] lines = content.Split('\n');
            bool isUnderSection = false;
            Dictionary<string, string> dic = new Dictionary<string,string>();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = Trim(lines[i]);
                if (string.IsNullOrEmpty(line))
                    continue;

                if (IsSection(line))
                {
                    if (isUnderSection)
                    {
                        isUnderSection = false;
                        if (dic != null && dic.Count > 0)
                        {
                            list.Add(dic);
                        }
                    }
                    
                    string name = GetSectionName(line);
                    if (name == sectionName)
                    {
                        isUnderSection = true;
                        dic = new Dictionary<string, string>();
                    }
                }
                else if (isUnderSection)
                {
                    string key;
                    string value;
                    GetKeyAndValue(line, out key, out value);
                    if (key == null)
                        continue;
                    dic.Add(key, value);
                }
            }
            //处理最后一项
            if (isUnderSection && dic != null && dic.Count > 0)
            {
                list.Add(dic);
            }

            return list;
        }
    }
}
