using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Collections.Specialized;
using System.Data.OleDb;

namespace sg2toxml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 繁体转换简体按钮响应函数
        /// </summary>
        private void ButtonToSample_Click(object sender, EventArgs e)
        {
            // 打开一个文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "INI文件|*.ini|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            //当点击确定打开按钮时的响应
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog.FileName;
                byte[] bytes = File.ReadAllBytes(fName);
                byte[] utf8 = Big5ToUtf8(bytes);
                
                string simplified = ToSimplifiedHelper.ToSimplified(System.Text.Encoding.UTF8.GetString(utf8));
                //string simplified = System.Text.Encoding.UTF8.GetString(utf8);

                //保存文件
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "INI文件|*.ini|所有文件|*.*";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FilterIndex = 1;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFileName = saveFileDialog.FileName;
                    File.WriteAllBytes(saveFileName, System.Text.Encoding.UTF8.GetBytes(simplified));
                }
            }
        }

        private void INIToXML_Click(object sender, EventArgs e)
        {
            // 打开一个文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "INI文件|*.ini|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            //当点击确定打开按钮时的响应
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog.FileName;
                byte[] bytes = File.ReadAllBytes(fName);
                byte[] utf8 = Big5ToUtf8(bytes);
                string content = ToSimplifiedHelper.ToSimplified(System.Text.Encoding.UTF8.GetString(utf8));

                string fileName = Path.GetFileNameWithoutExtension(fName);
                switch (fileName.ToUpper())
                {
                    case "THINGS":
                        {
                            ThingsConfig form = new ThingsConfig();

                            form.content = content;
                            form.srcFilePath = fName;
                            form.ShowDialog(this);
                        }
                        break;
                    case "MAGIC":
                        {
                            FolderBrowserHelper folderBrowserDialog = new FolderBrowserHelper();
                            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                            {
                                string outDir = folderBrowserDialog.SelectedPath;
                                MagicHandler magic = new MagicHandler();
                                magic.ToExcel(content, fName, outDir);
                            }
                        }
                        break;
                    case "MESSAGE":
                        {
                            FolderBrowserHelper folderBrowserDialog = new FolderBrowserHelper();
                            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                            {
                                string outDir = folderBrowserDialog.SelectedPath;
                                MessageHandler message = new MessageHandler();
                                message.ToExcel(content, fName, outDir);
                            }
                        }
                        break;
                    case "SANGO":
                        {
                            FolderBrowserHelper folderBrowserDialog = new FolderBrowserHelper();
                            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                            {
                                string outDir = folderBrowserDialog.SelectedPath;
                                SanguoINIHandler sango = new SanguoINIHandler();
                                sango.ToExcel(content, fName, outDir);
                            }
                        }
                        break;
                    default:
                        {
                            if (fileName.ToUpper().StartsWith("TIMES"))
                            {
                                FolderBrowserHelper folderBrowserDialog = new FolderBrowserHelper();
                                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                                {
                                    string outDir = folderBrowserDialog.SelectedPath;
                                    TimesHandler times = new TimesHandler();
                                    times.ToExcel(content, fName, outDir);
                                }
                            }
                            else
                                MessageBox.Show("文件类型未定义");
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// BIG5编码转UTF8编码
        /// </summary>
        public byte[] Big5ToUtf8(byte[] src)
        {
            string s = Encoding.GetEncoding("BIG5").GetString(src);
            byte[] dst = Encoding.UTF8.GetBytes(s);
            return dst;
        }

        private void ExcelToXML_Click(object sender, EventArgs e)
        {
            // 打开一个文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "Excel文件|*.xlsx|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            //当点击确定打开按钮时的响应
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string fileName = Path.GetFileNameWithoutExtension(path);

                switch (fileName.ToUpper())
                {
                    case "THINGS":
                        {
                            ThingsHandler things = new ThingsHandler();
                            things.ToData(path);
                        }
                        break;
                    case "MAGIC":
                        {
                            MagicHandler magic = new MagicHandler();
                            magic.ToData(path);
                        }
                        break;
                    case "MESSAGE":
                        {
                            MessageHandler message = new MessageHandler();
                            message.ToData(path);
                        }
                        break;
                    case "SANGO":
                        {
                            SanguoINIHandler sango = new SanguoINIHandler();
                            sango.ToData(path);
                        }
                        break;
                    default:
                        {
                            if (fileName.ToUpper().StartsWith("TIMES"))
                            {
                                TimesHandler times = new TimesHandler();
                                times.ToData(path);
                            }
                            else
                                MessageBox.Show("文件类型未定义");
                        }
                        break;
                }
            }
        }

        private void KillProcess_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExcelHelper.KillAllExcelProcess();
            MessageBox.Show("OK");
        }
    }
}
