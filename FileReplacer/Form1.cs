using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FileReplacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 批量替换图纸

        List<string> desFilePath = new List<string>();

        private void GetFileName(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    return;
                }
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] fi = di.GetFiles();
                foreach (FileInfo fiTemp in fi)
                {
                    desFilePath.Add(fiTemp.FullName);
                    Debug.WriteLine(fiTemp.FullName);
                }
                DirectoryInfo[] subDirList = di.GetDirectories();
                if (subDirList.Length > 0)
                {
                    for (int i = 0; i < subDirList.Length; i++)
                    {
                        GetFileName(subDirList[i].FullName);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            int deleteCount=0;
            int replaceCount=0;

            //listBox1.Items.Clear();
            //listBox1.Items.Add(@"C:\Users\Mao\Desktop\C#\FileReplacer\FileReplacer\bin\Debug\参照图框\4-（四级图框）zg.dwg");
            //listBox1.Items.Add(@"C:\Users\Mao\Desktop\C#\FileReplacer\FileReplacer\bin\Debug\参照图框\5-（五级图框）zg.dwg");
            //listBox1.Items.Add(@"C:\Users\Mao\Desktop\C#\FileReplacer\FileReplacer\bin\Debug\参照图框\图框(渝湘复线高速-四级).dwg");
            //listBox1.Items.Add(@"C:\Users\Mao\Desktop\C#\FileReplacer\FileReplacer\bin\Debug\参照图框\图框(渝湘复线高速-五级).dwg");
            //textBox1.Text = @"C:\Users\Mao\Desktop\C#\FileReplacer\FileReplacer\bin\Debug\武两路初设";

            // 获取指定要替换的文件列表
            List<string> sourceFilePath = new List<string>();
            foreach (string str in listBox1.Items)
            {
                sourceFilePath.Add(str);
            }
            // 获取文件夹下的所有文件
            GetFileName(textBox1.Text);
            // 遍历目标文件夹下的所有文件
            foreach (string item in desFilePath)
            {
                string desFileName = Path.GetFileName(item);
                string extensionName = Path.GetExtension(item);
                for (int i = 0; i < sourceFilePath.Count; i++)
                {
                    string filename = Path.GetFileName(sourceFilePath[i]);
                    if (desFileName == filename)
                    {
                        try
                        {
                            // 替换图框文件
                            if (sourceFilePath[i] == item) continue;
                            File.Copy(sourceFilePath[i], item, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                            replaceCount++;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.ToString());
                        }
                    }
                    try
                    {
                        // 清除fas文件
                        if (extensionName == ".fas" && cbDleteFas.Checked)
                        {
                            deleteCount++;
                            File.Delete(item);
                        }

                        // 清除bak文件
                        if (extensionName == ".bak" && cbDleteBak.Checked)
                        {
                            deleteCount++;
                            File.Delete(item);
                        }

                        // 清除ini文件
                        if (extensionName == ".ini" && cbDeleteIni.Checked)
                        {
                            deleteCount++;
                            File.Delete(item);
                        }

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                    }
                }
            }
            MessageBox.Show($"完成！已替换{replaceCount}个文件，删除{deleteCount}个文件");
        }


        // 拖拽相关代码
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (listBox1.Items[0].ToString() == "使用说明：") listBox1.Items.Clear();
            foreach (string filepath in (System.Array)e.Data.GetData(DataFormats.FileDrop))
            {
                listBox1.Items.Add(filepath);
            }
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (textBox1.Text != "") textBox1.Clear();
            foreach (string filepath in (System.Array)e.Data.GetData(DataFormats.FileDrop))
            {
                textBox1.Text = filepath;
            }
        }


        private void btnGetParentPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Txt所在文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void btnGetReplaceFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (listBox1.Items[0].ToString() == "使用说明：")
                {
                    listBox1.Items.Clear();
                }
                foreach (string s in ofd.FileNames)
                {
                    listBox1.Items.Add(s);
                }
            }
        }

        #region UselessCode
        //private void test()
        //{
        //string sourceFile = @"C:\Users\Mao\Desktop\C#\FileReplacer\FileReplacer\bin\Debug\文件1.txt";
        //string path = @"C:\Users\Mao\Desktop\C#\FileReplacer\FileReplacer\bin\Debug\Test";

        //DirectoryInfo TheFolder = new DirectoryInfo(path);

        ////遍历文件夹
        //foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
        //{
        //    MessageBox.Show(NextFolder.FullName);
        //    Console.WriteLine("");
        //}

        ////遍历文件
        //foreach (FileInfo NextFile in TheFolder.GetFiles())
        //{
        //    MessageBox.Show(NextFile.Name);

        //}

        //var res = Directory.GetFiles(path);
        //DirectoryInfo root = new DirectoryInfo(path);
        //DirectoryInfo[] dics = root.GetDirectories();


        ////获取当前程序所在的文件路径
        //String rootPath = Directory.GetCurrentDirectory();
        //string parentPath = Directory.GetParent(rootPath).FullName;//上级目录
        //string topPath = Directory.GetParent(parentPath).FullName;//上上级目录
        //StreamWriter sw = null;
        //try
        //{
        //    //创建输出流，将得到文件名子目录名保存到txt中
        //    sw = new StreamWriter(new FileStream("fileList.txt", FileMode.Append));
        //    sw.WriteLine("根目录：" + topPath);
        //    getDirectory(sw, topPath, 2);
        //}
        //catch (IOException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    if (sw != null)
        //    {
        //        sw.Close();
        //        Console.WriteLine("完成");
        //    }
        //}
        //}


        //public void Director(string dir, List<string> list)
        //{
        //    DirectoryInfo d = new DirectoryInfo(dir);
        //    FileInfo[] files = d.GetFiles();//文件
        //    DirectoryInfo[] directs = d.GetDirectories();//文件夹
        //    foreach (FileInfo f in files)
        //    {
        //        list.Add(f.Name);//添加文件名到列表中  
        //    }
        //    //获取子文件夹内的文件列表，递归遍历  
        //    foreach (DirectoryInfo dd in directs)
        //    {
        //        Director(dd.FullName, list);
        //    }
        //}




        /////
        ///// Copy文件夹
        /////
        ///// 源文件夹路径
        ///// 目的文件夹路径
        ///// <<SPAN class=FBlue>returns>完成状态：success-完成；其他-报错</<SPAN class=FBlue>returns>
        //public string CopyFolder(string sPath, string dPath)
        //{
        //    string flag = "success";
        //    try
        //    {
        //        // 创建目的文件夹
        //        if (!Directory.Exists(dPath))
        //        {
        //            Directory.CreateDirectory
        //            (dPath);
        //        }
        //        // 拷贝文件
        //        DirectoryInfo sDir = new DirectoryInfo(sPath);
        //        FileInfo[] fileArray = sDir.GetFiles();
        //        foreach (FileInfo file in fileArray)
        //        {
        //            file.CopyTo(dPath + "\\" + file.Name, true);
        //        }
        //        // 循环子文件夹
        //        DirectoryInfo dDir = new DirectoryInfo(dPath);
        //        DirectoryInfo[] subDirArray = sDir.GetDirectories();
        //        foreach (DirectoryInfo subDir in subDirArray)
        //        {
        //            CopyFolder(subDir.FullName, dPath + "//" + subDir.Name);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        flag = ex.ToString();
        //    }
        //    return flag;
        //}


        //private void CopyTo(string sourceFile, string destinationFile)
        //{
        //    //string sourceFile = @"c:\temp\New Text Document.txt";
        //    //string destinationFile = @"c:\temp\test.txt";
        //    FileInfo file = new FileInfo(sourceFile);
        //    if (file.Exists)
        //    {
        //        // true is overwrite 
        //        file.CopyTo(destinationFile, true);
        //    }
        //}


        ///// <summary>
        ///// 获得指定路径下所有文件名
        ///// </summary>
        ///// <param name="sw">文件写入流</param>
        ///// <param name="path">文件写入流</param>
        ///// <param name="indent">输出时的缩进量</param>
        //public static void getFileName(StreamWriter sw, string path, int indent)
        //{
        //    DirectoryInfo root = new DirectoryInfo(path);
        //    foreach (FileInfo f in root.GetFiles())
        //    {
        //        for (int i = 0; i < indent; i++)
        //        {
        //            sw.Write("  ");
        //        }
        //        sw.WriteLine(f.Name);
        //    }
        //}

        ///// <summary>
        ///// 获得指定路径下所有子目录名
        ///// </summary>
        ///// <param name="sw">文件写入流</param>
        ///// <param name="path">文件夹路径</param>
        ///// <param name="indent">输出时的缩进量</param>
        //public static void getDirectory(StreamWriter sw, string path, int indent)
        //{
        //    getFileName(sw, path, indent);
        //    DirectoryInfo root = new DirectoryInfo(path);
        //    foreach (DirectoryInfo d in root.GetDirectories())
        //    {
        //        for (int i = 0; i < indent; i++)
        //        {
        //            sw.Write("  ");
        //        }
        //        sw.WriteLine("文件夹：" + d.Name);
        //        getDirectory(sw, d.FullName, indent + 2);
        //        sw.WriteLine();
        //    }
        //}
        #endregion

        #endregion

        #region 批量修改图纸
        private void btnGetCADPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择CAD安装文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label3.Text = dialog.SelectedPath;
            }
        }

        private void btnGetDwgsPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择图纸路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label4.Text = dialog.SelectedPath;
            }
        }

        private void btnStartEdit_Click(object sender, EventArgs e)
        {
            //label3.Text = @"C:\Program Files\Autodesk\AutoCAD 2020";
            //label4.Text = @"C:\Users\Mao\Desktop\C#\FileReplacer\FileReplacer\bin\Debug\武两路初设7.8-backup";
            //textBox2.Text = "0.7";
            //textBox3.Text = "0.7";
            //textBox4.Text = "0.7";

            string cadFolder = label3.Text;
            string dwgsPath = label4.Text;

            double QMTextFactor = double.Parse(textBox2.Text);
            double TMTextFactor = double.Parse(textBox3.Text);
            double THTextFactor = double.Parse(textBox4.Text);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // 获取accoreconsole.exe路径
            string consolePath = cadFolder + "\\accoreconsole.exe";
            // 处理控制台不存在的情况
            if (!File.Exists(consolePath))
            {
                MessageBox.Show("请检查路径是否输入有误，并更新AutoCAD版本至2013以上");
                return;
            }

            // 根据用户选择的路径判断CAD版本号
            DirectoryInfo pathInfo = new DirectoryInfo(cadFolder);
            string CadVersion = pathInfo.Name;
            string dllPath = workPath;
            if (CadVersion == "AutoCAD 2020")
            {
                dllPath += "\\Dll\\2020\\MaoToolsFor20.dll";
            }
            else if (CadVersion == "AutoCAD 2014")
            {
                dllPath += "\\Dll\\2014\\MaoToolsFor14.dll";
            }
            else
            {
                MessageBox.Show("目前本程序仅支持2014和2020版本，如果需要增加支持版本，请联系作者Q1048493621");
                return;
            }

            // 初始化desFilePath
            desFilePath.Clear();
            GetFileName(dwgsPath);
            // 遍历目标文件夹下的所有文件
            foreach (string path in desFilePath)
            {
                // 忽略非dwg文件
                if (Path.GetExtension(path) != ".dwg") continue;
                // 修改当前dwg文件的指定块宽度
                BatchEditBlockText(QMTextFactor, TMTextFactor, THTextFactor, cadFolder, path, dllPath);
            }
            sw.Stop(); 
            MessageBox.Show($"完成！共耗时：{sw.ElapsedMilliseconds/1000} s");
        }

        // 工作路径
        private string workPath = Directory.GetCurrentDirectory();

        /// <summary>
        /// 使用cadFolder下的accoreconsole后台修改Dwg中的指定块宽度
        /// </summary>
        /// <param name="QMTextFactor">桥名宽度</param>
        /// <param name="TMTextFactor">图名宽度</param>
        /// <param name="THTextFactor">图号宽度</param>
        /// <param name="cadFolder">cad安装根目录</param>
        /// <param name="dwgPath">Dwg路径</param>
        private void BatchEditBlockText(double QMTextFactor,double TMTextFactor,double THTextFactor,string cadFolder,string dwgPath,string dllPath)
        {
            //DirectoryInfo directoryInfo = new DirectoryInfo(dwgPath);

            // 生成scr文件
            string ScrCommand = "secureload 0" + Environment.NewLine + "cmdecho 0" + Environment.NewLine
                 + "netload \"" + dllPath + "\"" + Environment.NewLine + "filedia" + Environment.NewLine + "0"
                 + Environment.NewLine + "(if (= (getvar \"WRITESTAT\") 0) (Command \"close\"))" + Environment.NewLine
                 + "(command \"ChangeBlockTextWidth\" \"" + QMTextFactor + "\" \"" + TMTextFactor + "\" \"" + THTextFactor + "\") "
                 + Environment.NewLine + "1" + Environment.NewLine + "save" + Environment.NewLine
                 + Environment.NewLine + "Y" + Environment.NewLine +"quit"+ Environment.NewLine + " ";
            string ScrPath = $"{Path.GetDirectoryName(dwgPath)}\\{Path.GetFileNameWithoutExtension(dwgPath)}.scr";
            try
            {
                // 写入scr文件
                File.WriteAllText(ScrPath, ScrCommand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 创建并执行CMD脚本
            using (Process pro = new Process())
            {
                // 执行CMD命令调用src
                string cmdStr = "cd " + cadFolder + Environment.NewLine + "c:" + Environment.NewLine + "cls" + Environment.NewLine + 
                    "accoreconsole.exe /i \"" +dwgPath+"\" /s \""+ ScrPath + "\" /l en-US" + Environment.NewLine + "@exit";
                File.WriteAllText($"{Path.GetDirectoryName(dwgPath)}\\{Path.GetFileNameWithoutExtension(dwgPath)}.bat",cmdStr,Encoding.Default);
                // 设置命令行、参数"
                pro.StartInfo.FileName = "cmd.exe";
                // c ：执行后自动退出
                pro.StartInfo.Arguments = " / c";
                pro.StartInfo.UseShellExecute = false;
                pro.StartInfo.RedirectStandardInput = true;
                pro.StartInfo.RedirectStandardOutput = true;
                pro.StartInfo.RedirectStandardError = true;
                // 不显示窗口
                pro.StartInfo.CreateNoWindow = true;
                // 启动CMD
                pro.Start();
                // 运行命令
                pro.StandardInput.WriteLine(cmdStr);
                // 等待程序执行完退出进程
                pro.StandardOutput.ReadToEnd();
                pro.WaitForExit();
                // pro.Close();
                pro.Close();
            }
            File.Delete(ScrPath);
            File.Delete($"{Path.GetDirectoryName(dwgPath)}\\{Path.GetFileNameWithoutExtension(dwgPath)}.bat");
        }

        private void label3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void label3_DragDrop(object sender, DragEventArgs e)
        {
            label3.Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void label4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void label4_DragDrop(object sender, DragEventArgs e)
        {
            label4.Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        #endregion
    }
}
