using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

public class Export
{
    string m_fileName;

    List<string> m_listProperty;
    List<string> m_listDescript;
    List<string> m_listType;

    ExcelHelper m_excelHelper;

    public Export(string filePath)
    {
        m_fileName = filePath;

        Init();

        ExportToData();
        ExportToCSharp();

        m_excelHelper.Quit();
    }

    public void Init()
    {
        m_listProperty = new List<string>();
        m_listDescript = new List<string>();
        m_listType = new List<string>();

        m_excelHelper = new ExcelHelper(m_fileName);

        if (m_excelHelper.RowCount < 3)
        {
            Console.WriteLine("文件:" + m_fileName + " 格式错误!");
            return;
        }

        for (int i = 1; i <= m_excelHelper.ColumnCount; i++)
        {
            string property = m_excelHelper.GetCells(1, i);
            string descript = m_excelHelper.GetCells(2, i);
            string type = m_excelHelper.GetCells(3, i);

            if (string.IsNullOrEmpty(property) || string.IsNullOrEmpty(type))
            {
                break;
            }
            if (type != "int" && type != "string" && type != "float")
            {
                Console.WriteLine("文件:" + m_fileName + "第 " + i + " 列元素的类型错误! string int float");
                return;
            }

            m_listProperty.Add(property);
            m_listDescript.Add(descript);
            m_listType.Add(type);
        }
    }

    void ExportToData()
    {
        string fileName = Path.GetFileNameWithoutExtension(m_fileName);
        string className = "Data" + Path.GetFileNameWithoutExtension(m_fileName);
        string filePath = Path.GetDirectoryName(m_fileName) + "\\" + className + ".lua";

        StreamWriter sw = File.CreateText(filePath);
        sw.WriteLine("module(..., package.seeall);");
        sw.WriteLine();
        sw.WriteLine("Data = ");
        sw.WriteLine("{");

        for (int i = 4; i <= m_excelHelper.RowCount; i++)
        {
            string line = "\t{ ";
            string arrayStr = "";
            for (int j = 0; j < m_listProperty.Count; j++)
            {
                if (!m_listProperty[j].EndsWith("[]"))
                {
                    if (arrayStr != "")
                    {
                        arrayStr = "";
                        line += "},";
                    }
                    line += m_listProperty[j] + " = [[" + m_excelHelper.GetCells(i, j + 1) + "]], ";
                }
                else
                {
                    if (arrayStr != m_listProperty[j])
                    {
                        if (arrayStr != "")
                        {
                            line += "},";
                        }
                        arrayStr = m_listProperty[j];
                        line += m_listProperty[j].Substring(0, m_listProperty[j].Length - 2) + " = { [[" + m_excelHelper.GetCells(i, j + 1) + "]], ";
                    }
                    else
                    {
                        line += "[[" + m_excelHelper.GetCells(i, j + 1) + "]], ";
                    }
                }
            }

            line += "},";
            sw.WriteLine(line);
        }
        sw.WriteLine("}");

        sw.Flush();
        sw.Close();
    }

    void ExportToCSharp()
    {
        string className = "Data" + Path.GetFileNameWithoutExtension(m_fileName);
        string filePath = Path.GetDirectoryName(m_fileName) + "\\" + className + ".cs";

        FileStream fs = new FileStream(filePath, FileMode.Create);
        StreamWriter sw = new StreamWriter(fs, Encoding.Default);

        sw.WriteLine();
        sw.WriteLine("public class " + className);
        sw.WriteLine("{");

        string arrayStr = "";
        for (int i = 0; i < m_listProperty.Count; i++)
        {
            if (m_listProperty[i].EndsWith("[]"))
            {
                if (arrayStr == m_listProperty[i])
                {
                    continue;
                }
                else
                {
                    arrayStr = m_listProperty[i];

                    sw.WriteLine("\t/// <summary>");
                    sw.WriteLine("\t/// " + m_listDescript[i]);
                    sw.WriteLine("\t/// </summary>");
                    sw.WriteLine("\tpublic " + m_listType[i] + "[] " + m_listProperty[i].Substring(0, m_listProperty[i].Length - 2) + ";");
                    sw.WriteLine();
                }
            }
            else
            {
                sw.WriteLine("\t/// <summary>");
                sw.WriteLine("\t/// " + m_listDescript[i]);
                sw.WriteLine("\t/// </summary>");
                sw.WriteLine("\tpublic " + m_listType[i] + " " + m_listProperty[i] + ";");
                sw.WriteLine();
            }
        }

        sw.WriteLine("}");

        sw.Close();
        fs.Close();
    }
}
