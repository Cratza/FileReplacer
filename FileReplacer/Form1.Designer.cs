
namespace FileReplacer
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetParentPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDeleteIni = new System.Windows.Forms.CheckBox();
            this.cbDleteBak = new System.Windows.Forms.CheckBox();
            this.cbDleteFas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetReplaceFiles = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStartEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbTHFactor = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbTMFactor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbQMFactor = new System.Windows.Forms.Label();
            this.btnGetDwgsPath = new System.Windows.Forms.Button();
            this.btnGetCADPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "使用说明：",
            "1、此处为模板文件，程序会自动将此List中的所有文件替换入下方指定的路径中；",
            "2、可同时拖拽多个文件到此处快速添加需要替换的文件；",
            "3、程序出错？请联系作者QQ：1048493621。"});
            this.listBox1.Location = new System.Drawing.Point(25, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(587, 220);
            this.listBox1.TabIndex = 0;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "图纸文件夹路径：";
            // 
            // btnGetParentPath
            // 
            this.btnGetParentPath.Location = new System.Drawing.Point(401, 324);
            this.btnGetParentPath.Name = "btnGetParentPath";
            this.btnGetParentPath.Size = new System.Drawing.Size(211, 49);
            this.btnGetParentPath.TabIndex = 2;
            this.btnGetParentPath.Text = "指定图纸文件夹";
            this.btnGetParentPath.UseVisualStyleBackColor = true;
            this.btnGetParentPath.Click += new System.EventHandler(this.btnGetParentPath_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(28, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(584, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "可直接拖拽图纸文件夹至此处";
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOK.Location = new System.Drawing.Point(28, 572);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(584, 49);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "替换路径下的所有对应文件";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDeleteIni);
            this.groupBox1.Controls.Add(this.cbDleteBak);
            this.groupBox1.Controls.Add(this.cbDleteFas);
            this.groupBox1.Location = new System.Drawing.Point(28, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 101);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图纸文件清理";
            // 
            // cbDeleteIni
            // 
            this.cbDeleteIni.AutoSize = true;
            this.cbDeleteIni.Checked = true;
            this.cbDeleteIni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDeleteIni.Location = new System.Drawing.Point(208, 52);
            this.cbDeleteIni.Name = "cbDeleteIni";
            this.cbDeleteIni.Size = new System.Drawing.Size(174, 28);
            this.cbDeleteIni.TabIndex = 0;
            this.cbDeleteIni.Text = "ini配置文件";
            this.cbDeleteIni.UseVisualStyleBackColor = true;
            // 
            // cbDleteBak
            // 
            this.cbDleteBak.AutoSize = true;
            this.cbDleteBak.Location = new System.Drawing.Point(404, 52);
            this.cbDleteBak.Name = "cbDleteBak";
            this.cbDleteBak.Size = new System.Drawing.Size(174, 28);
            this.cbDleteBak.TabIndex = 0;
            this.cbDleteBak.Text = "bak自动备份";
            this.cbDleteBak.UseVisualStyleBackColor = true;
            // 
            // cbDleteFas
            // 
            this.cbDleteFas.AutoSize = true;
            this.cbDleteFas.Checked = true;
            this.cbDleteFas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDleteFas.Location = new System.Drawing.Point(16, 52);
            this.cbDleteFas.Name = "cbDleteFas";
            this.cbDleteFas.Size = new System.Drawing.Size(174, 28);
            this.cbDleteFas.TabIndex = 0;
            this.cbDleteFas.Text = "fas错误日志";
            this.cbDleteFas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "图纸文件清单：";
            // 
            // btnGetReplaceFiles
            // 
            this.btnGetReplaceFiles.Location = new System.Drawing.Point(401, 27);
            this.btnGetReplaceFiles.Name = "btnGetReplaceFiles";
            this.btnGetReplaceFiles.Size = new System.Drawing.Size(211, 45);
            this.btnGetReplaceFiles.TabIndex = 6;
            this.btnGetReplaceFiles.Text = "指定替换文件";
            this.btnGetReplaceFiles.UseVisualStyleBackColor = true;
            this.btnGetReplaceFiles.Click += new System.EventHandler(this.btnGetReplaceFiles_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 701);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnGetReplaceFiles);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnOK);
            this.tabPage1.Controls.Add(this.btnGetParentPath);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "替换文件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStartEdit);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnGetDwgsPath);
            this.tabPage2.Controls.Add(this.btnGetCADPath);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改文件";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStartEdit
            // 
            this.btnStartEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStartEdit.Location = new System.Drawing.Point(26, 566);
            this.btnStartEdit.Name = "btnStartEdit";
            this.btnStartEdit.Size = new System.Drawing.Size(592, 64);
            this.btnStartEdit.TabIndex = 3;
            this.btnStartEdit.Text = "修改图纸路径中所有图纸的指定文字块宽度";
            this.btnStartEdit.UseVisualStyleBackColor = false;
            this.btnStartEdit.Click += new System.EventHandler(this.btnStartEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.lbTHFactor);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.lbTMFactor);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.lbQMFactor);
            this.groupBox2.Location = new System.Drawing.Point(26, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 259);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "块宽度参数设置";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(273, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 35);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "0.7";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTHFactor
            // 
            this.lbTHFactor.AutoSize = true;
            this.lbTHFactor.Location = new System.Drawing.Point(89, 176);
            this.lbTHFactor.Name = "lbTHFactor";
            this.lbTHFactor.Size = new System.Drawing.Size(154, 24);
            this.lbTHFactor.TabIndex = 0;
            this.lbTHFactor.Text = "图号宽度系数";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 35);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "0.7";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTMFactor
            // 
            this.lbTMFactor.AutoSize = true;
            this.lbTMFactor.Location = new System.Drawing.Point(89, 123);
            this.lbTMFactor.Name = "lbTMFactor";
            this.lbTMFactor.Size = new System.Drawing.Size(154, 24);
            this.lbTMFactor.TabIndex = 0;
            this.lbTMFactor.Text = "图名宽度系数";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 35);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0.7";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbQMFactor
            // 
            this.lbQMFactor.AutoSize = true;
            this.lbQMFactor.Location = new System.Drawing.Point(89, 66);
            this.lbQMFactor.Name = "lbQMFactor";
            this.lbQMFactor.Size = new System.Drawing.Size(154, 24);
            this.lbQMFactor.TabIndex = 0;
            this.lbQMFactor.Text = "桥名宽度系数";
            // 
            // btnGetDwgsPath
            // 
            this.btnGetDwgsPath.Location = new System.Drawing.Point(26, 189);
            this.btnGetDwgsPath.Name = "btnGetDwgsPath";
            this.btnGetDwgsPath.Size = new System.Drawing.Size(592, 45);
            this.btnGetDwgsPath.TabIndex = 1;
            this.btnGetDwgsPath.Text = "选择图纸路径";
            this.btnGetDwgsPath.UseVisualStyleBackColor = true;
            this.btnGetDwgsPath.Click += new System.EventHandler(this.btnGetDwgsPath_Click);
            // 
            // btnGetCADPath
            // 
            this.btnGetCADPath.Location = new System.Drawing.Point(26, 60);
            this.btnGetCADPath.Name = "btnGetCADPath";
            this.btnGetCADPath.Size = new System.Drawing.Size(592, 45);
            this.btnGetCADPath.TabIndex = 1;
            this.btnGetCADPath.Text = "选择CAD安装路径";
            this.btnGetCADPath.UseVisualStyleBackColor = true;
            this.btnGetCADPath.Click += new System.EventHandler(this.btnGetCADPath_Click);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "示例图纸路径 D:\\武两路初步设计";
            this.label4.DragDrop += new System.Windows.Forms.DragEventHandler(this.label4_DragDrop);
            this.label4.DragEnter += new System.Windows.Forms.DragEventHandler(this.label4_DragEnter);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "示例路径 C:\\Program Files\\Autodesk\\AutoCAD 2020";
            this.label3.DragDrop += new System.Windows.Forms.DragEventHandler(this.label3_DragDrop);
            this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.label3_DragEnter);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 701);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatchDwgAssistant";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetParentPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDleteBak;
        private System.Windows.Forms.CheckBox cbDleteFas;
        private System.Windows.Forms.CheckBox cbDeleteIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetReplaceFiles;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGetCADPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetDwgsPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbTHFactor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbTMFactor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbQMFactor;
        private System.Windows.Forms.Button btnStartEdit;
    }
}

