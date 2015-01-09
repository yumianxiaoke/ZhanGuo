namespace sg2toxml
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonToXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonToXML
            // 
            this.ButtonToXML.Location = new System.Drawing.Point(57, 53);
            this.ButtonToXML.Name = "ButtonToXML";
            this.ButtonToXML.Size = new System.Drawing.Size(148, 54);
            this.ButtonToXML.TabIndex = 1;
            this.ButtonToXML.Text = "INI转XML";
            this.ButtonToXML.UseVisualStyleBackColor = true;
            this.ButtonToXML.Click += new System.EventHandler(this.ButtonToXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 161);
            this.Controls.Add(this.ButtonToXML);
            this.Name = "Form1";
            this.Text = "SG2转换器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonToXML;
    }
}

