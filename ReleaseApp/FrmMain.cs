﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ReleaseApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            txtReleasePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtFileList.Text = @"d:\FileList.txt";
            txtAppBasePath.Text = @"D:\SVNRoot\src\Client\win\teacher\zntbkt\bin\Debug";
        }

        private void numericUpDownVer_ValueChanged(object sender, EventArgs e)
        {
            txtReleaseFileName.Text = $"{txtReleasePath.Text}\\Teacher.{DateTime.Now.ToString("yyyyMMdd")}.v{numericUpDownVer.Value}.zip";
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtReleasePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void linkLabelDesktop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtReleasePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void linkLabelCurrent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtReleasePath.Text = Application.StartupPath;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileList.Text = openFileDialog1.FileName;
            }
        }

        private void btnCheckFileList_Click(object sender, EventArgs e)
        {
            var frm = new FrmCheckList();
            frm.FileListName = txtFileList.Text;
            frm.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(txtFileList.Text);
            var tmpDirName = $@"{Application.StartupPath}\Teacher";
            if (!Directory.Exists(tmpDirName))
            {
                Directory.CreateDirectory(tmpDirName);
            }
            foreach (var line in lines)
            {
                var sourceFile = Path.Combine(txtAppBasePath.Text, line);
                var targetFile = Path.Combine(tmpDirName, line);
                var fi = new FileInfo(targetFile);
                if (!Directory.Exists(fi.DirectoryName))
                {
                    Directory.CreateDirectory(fi.DirectoryName);
                }
                File.Copy(sourceFile, targetFile, true);
            }
            var cmd = $"a -tzip {txtReleaseFileName.Text} -w {tmpDirName}";
            var p = Process.Start("7z.exe", cmd);
            p.WaitForExit();

            /*
                        System.Diagnostics.Process p = new System.Diagnostics.Process();
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
                        p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                        p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                        p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                        p.StartInfo.CreateNoWindow = true;//不显示程序窗口
                        p.Start();//启动程序
                        var zipApp = $@"{Application.StartupPath}\7z.exe";
                        p.StandardInput.WriteLine($"cd {txtAppBasePath.Text}");
                        p.StandardInput.AutoFlush = true;
                        p.StandardInput.WriteLine($"d:");

                        foreach (var line in lines)
                        {
                            string str = Console.ReadLine();

                            //向cmd窗口发送输入信息
                            p.StandardInput.WriteLine($@"{zipApp} a {txtReleaseFileName.Text} -w D:\SVNRoot\src\Client\win\teacher\zntbkt\bin\Debug ");

                            //string ddd = p.StandardOutput.ReadToEnd();
                            break;
                            //p.StandardInput.WriteLine("exit");
                            //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
                            //同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令




                            //var cmd = $"7z a -tzip {txtReleaseFileName.Text} -w {txtAppBasePath.Text} {line}";
                            //var p = Process.Start("7z.exe", cmd);
                            //p.WaitForExit();
                        }
                        p.StandardInput.WriteLine("exit");
                        //获取cmd窗口的输出信息
                        string output = p.StandardOutput.ReadToEnd();
                        MessageBox.Show(output);

                        p.WaitForExit();//等待程序执行完退出进程
                        p.Close();
            */
        }

        private void linkLabelGotoCurrentPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtAppBasePath.Text = Application.StartupPath;
        }
    }
}