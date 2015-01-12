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
                            ThingsConfig form = new ThingsConfig();

                            form.bytes = utf8;
                            form.srcFilePath = fName;
                            form.ShowDialog(this);


                            //ThingsToXML things = new ThingsToXML();
                            //things.ToExcel(utf8, Path.GetDirectoryName(fName) + "/" + fileName);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //IMEX：只有是0才能成功更新，1或2都有错误提示，操作必须使用一个可更新的查询，2也有奇怪？
            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"E:\Workspace\Project\ZhanGuo\Tools\sg2toxml\成绩表2013.xlsx" + ";Extended Properties='Excel 12.0;HDR=False;IMEX=0'";
            //string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:/成绩表2013.xlsx;Extended Properties='Excel 12.0;HDR=YES;IMEX=0'";
            OleDbConnection myConn = new OleDbConnection(strCon);
            string strCom = "SELECT * FROM [Sheet1$]";
            myConn.Open();
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strCom, myConn);
            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "[Sheet1$]");
            myConn.Close();
            DataTable dt = myDataSet.Tables[0]; //初始化DataTable实例
            dt.PrimaryKey = new DataColumn[] { dt.Columns["学生"] };//创建索引列
            DataRow myRow = dt.NewRow();
            myRow["学生"] = "小蟹";
            myRow["英语"] = 82;
            myRow["数学"] = 93;
            myRow["自然"] = 39;
            myRow["美术"] = 39;
            dt.Rows.Add(myRow);
            OleDbCommandBuilder odcb = new OleDbCommandBuilder(myDataAdapter);
            odcb.QuotePrefix = "[";   //用于搞定INSERT INTO 语句的语法错误
            odcb.QuoteSuffix = "]";
            myDataAdapter.Update(myDataSet, "[Sheet1$]"); //更新数据集对应的表
        }

        private void ExcelToXML_Click(object sender, EventArgs e)
        {
            
        }
    }
}
