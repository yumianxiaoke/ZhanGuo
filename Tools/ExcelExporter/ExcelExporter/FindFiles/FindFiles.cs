using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

public static class FindFiles
{
    public static List<string> FindFilesName(string directory)
    {
        List<string> listFiles = new List<string>();

        DirectoryInfo theFolder = new DirectoryInfo(directory);

        GetFiles(theFolder, listFiles);

        return listFiles;
    }

    static void GetFiles(DirectoryInfo directory, List<string> listFiles)
    {
        FileInfo[] files = directory.GetFiles();
        foreach (FileInfo NextFile in files)
        {
            if (string.Compare(NextFile.Extension, ".xlsx", true) == 0)
            {
                listFiles.Add(NextFile.FullName);
            }
        }

        DirectoryInfo[] dirInfo = directory.GetDirectories();
        foreach (DirectoryInfo NextFolder in dirInfo)
        {
            GetFiles(NextFolder, listFiles);
        }
    }
}
