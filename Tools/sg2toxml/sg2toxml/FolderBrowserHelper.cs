using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace sg2toxml
{
    public class FolderBrowserHelper
    {
        public string SelectedPath;

        FolderBrowserDialog folderBrowserDialog;

        public FolderBrowserHelper()
        {
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.Description = "请选择输出目录";

            if (File.Exists("SelectedPath.txt"))
            {
                string SelectedPath = File.ReadAllText("SelectedPath.txt");
                SelectedPath = SelectedPath.Trim();
                folderBrowserDialog.SelectedPath = SelectedPath;
            }
        }

        public DialogResult ShowDialog()
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            SelectedPath = folderBrowserDialog.SelectedPath;

            if (File.Exists("SelectedPath.txt"))
                File.Delete("SelectedPath.txt");
            File.WriteAllText("SelectedPath.txt", SelectedPath);

            return result;
        }
    }
}
