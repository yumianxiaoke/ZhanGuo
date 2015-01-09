﻿using System;
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

        private void ButtonToXML_Click(object sender, EventArgs e)
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

                string fileName = Path.GetFileNameWithoutExtension(fName);
                switch (fileName.ToUpper())
                {
                    case "THINGS":
                        {
                            //保存文件
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "XML文件|*.xml";
                            saveFileDialog.RestoreDirectory = true;
                            saveFileDialog.FilterIndex = 1;
                            saveFileDialog.AddExtension = true;
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string saveFileName = saveFileDialog.FileName;
                                ThingsToXML things = new ThingsToXML();
                                things.ToXML(utf8, saveFileName);
                            }
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
    }
}
