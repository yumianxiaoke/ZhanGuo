using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public static class ToCSharpHelper
{
    public static void ToCSharp(string className, string dir, List<string> listProperty)
    {
        string filePath = dir + "\\" + className + ".cs";

        FileStream fs = new FileStream(filePath, FileMode.Create);
        StreamWriter sw = new StreamWriter(fs);

        sw.WriteLine();
        sw.WriteLine("public class " + className);
        sw.WriteLine("{");

        for (int i = 0; i < listProperty.Count; i++)
        {
            sw.WriteLine("\tpublic " + "string" + " " + listProperty[i] + ";");
            sw.WriteLine();
        }

        sw.WriteLine("}");

        sw.Close();
        fs.Close();
    }
}
