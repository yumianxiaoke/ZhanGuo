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

namespace sg2toxml
{
    public partial class ThingsConfig : Form
    {
        private int sequenceNum = 11;
        public int[, ] sequenceRange = new int[11, 2];

        public string content;
        public string srcFilePath;

        public ThingsConfig()
        {
            InitializeComponent();

            if (File.Exists("ThingsConfig.txt"))
            {
                FileStream fs = new FileStream("ThingsConfig.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                for (int i = 0; i < sequenceNum; i++)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(',');
                    sequenceRange[i, 0] = System.Convert.ToInt32(split[0]);
                    sequenceRange[i, 1] = System.Convert.ToInt32(split[1]);
                }
                savePath.Text = sr.ReadLine();
                checkBoxSource.Checked = System.Convert.ToBoolean(sr.ReadLine());

                sr.Close();
                fs.Close();
            }

            start1.Text = sequenceRange[0, 0].ToString();
            start2.Text = sequenceRange[1, 0].ToString();
            start3.Text = sequenceRange[2, 0].ToString();
            start4.Text = sequenceRange[3, 0].ToString();
            start5.Text = sequenceRange[4, 0].ToString();
            start6.Text = sequenceRange[5, 0].ToString();
            start7.Text = sequenceRange[6, 0].ToString();
            start8.Text = sequenceRange[7, 0].ToString();
            start9.Text = sequenceRange[8, 0].ToString();
            start10.Text = sequenceRange[9, 0].ToString();
            start11.Text = sequenceRange[10, 0].ToString();

            end1.Text = sequenceRange[0, 1].ToString();
            end2.Text = sequenceRange[1, 1].ToString();
            end3.Text = sequenceRange[2, 1].ToString();
            end4.Text = sequenceRange[3, 1].ToString();
            end5.Text = sequenceRange[4, 1].ToString();
            end6.Text = sequenceRange[5, 1].ToString();
            end7.Text = sequenceRange[6, 1].ToString();
            end8.Text = sequenceRange[7, 1].ToString();
            end9.Text = sequenceRange[8, 1].ToString();
            end10.Text = sequenceRange[9, 1].ToString();
            end11.Text = sequenceRange[10, 1].ToString();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
                return;

            if (textBox.Name.StartsWith("start"))
            {
                string num = textBox.Name.Substring("start".Length);
                int index = System.Convert.ToInt32(num) - 1;
                sequenceRange[index, 0] = System.Convert.ToInt32(textBox.Text);
            }
            else if (textBox.Name.StartsWith("end"))
            {
                string num = textBox.Name.Substring("end".Length);
                int index = System.Convert.ToInt32(num) - 1;
                sequenceRange[index, 1] = System.Convert.ToInt32(textBox.Text);
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserHelper folderBrowserDialog = new FolderBrowserHelper();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                savePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            string path = "";
            if (checkBoxSource.Checked || string.IsNullOrEmpty(savePath.Text))
            {
                path = Path.GetDirectoryName(srcFilePath) + "/" + Path.GetFileNameWithoutExtension(srcFilePath);
            }
            else
            {
                path = savePath.Text + "/" + Path.GetFileNameWithoutExtension(srcFilePath);
            }

            FileStream fs = new FileStream("ThingsConfig.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < sequenceNum; i++)
            {
                sw.WriteLine(sequenceRange[i, 0] + "," + sequenceRange[i, 1]);
            }
            sw.WriteLine(savePath.Text);
            sw.WriteLine(checkBoxSource.Checked.ToString());
            sw.Flush();
            sw.Close();
            fs.Close();

            ThingsHandler things = new ThingsHandler();
            things.ToExcel(content, sequenceRange, path);

            Close();
        }
    }
}
