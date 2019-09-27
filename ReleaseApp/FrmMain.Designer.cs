namespace ReleaseApp
{
    partial class FrmMain
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
            this.btnCheckFileList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileList = new System.Windows.Forms.TextBox();
            this.btnRelease = new System.Windows.Forms.Button();
            this.txtReleaseFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownVer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReleasePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.linkLabelDesktop = new System.Windows.Forms.LinkLabel();
            this.linkLabelCurrent = new System.Windows.Forms.LinkLabel();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabelGotoCurrentPath = new System.Windows.Forms.LinkLabel();
            this.txtAppBasePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckFileList
            // 
            this.btnCheckFileList.Location = new System.Drawing.Point(14, 197);
            this.btnCheckFileList.Name = "btnCheckFileList";
            this.btnCheckFileList.Size = new System.Drawing.Size(115, 23);
            this.btnCheckFileList.TabIndex = 0;
            this.btnCheckFileList.Text = "检查文件清单";
            this.btnCheckFileList.UseVisualStyleBackColor = true;
            this.btnCheckFileList.Click += new System.EventHandler(this.btnCheckFileList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件清单";
            // 
            // txtFileList
            // 
            this.txtFileList.Location = new System.Drawing.Point(12, 28);
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.Size = new System.Drawing.Size(389, 21);
            this.txtFileList.TabIndex = 2;
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(137, 197);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(115, 23);
            this.btnRelease.TabIndex = 3;
            this.btnRelease.Text = "发布";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // txtReleaseFileName
            // 
            this.txtReleaseFileName.Location = new System.Drawing.Point(12, 166);
            this.txtReleaseFileName.Name = "txtReleaseFileName";
            this.txtReleaseFileName.Size = new System.Drawing.Size(389, 21);
            this.txtReleaseFileName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "压缩包文件名";
            // 
            // numericUpDownVer
            // 
            this.numericUpDownVer.Location = new System.Drawing.Point(409, 166);
            this.numericUpDownVer.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownVer.Name = "numericUpDownVer";
            this.numericUpDownVer.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownVer.TabIndex = 6;
            this.numericUpDownVer.ValueChanged += new System.EventHandler(this.numericUpDownVer_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "版本";
            // 
            // txtReleasePath
            // 
            this.txtReleasePath.Location = new System.Drawing.Point(12, 119);
            this.txtReleasePath.Name = "txtReleasePath";
            this.txtReleasePath.Size = new System.Drawing.Size(389, 21);
            this.txtReleasePath.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "发布路径";
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(409, 119);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(59, 23);
            this.btnSelectDir.TabIndex = 10;
            this.btnSelectDir.Text = "选择...";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // linkLabelDesktop
            // 
            this.linkLabelDesktop.AutoSize = true;
            this.linkLabelDesktop.Location = new System.Drawing.Point(315, 104);
            this.linkLabelDesktop.Name = "linkLabelDesktop";
            this.linkLabelDesktop.Size = new System.Drawing.Size(29, 12);
            this.linkLabelDesktop.TabIndex = 11;
            this.linkLabelDesktop.TabStop = true;
            this.linkLabelDesktop.Text = "桌面";
            this.linkLabelDesktop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDesktop_LinkClicked);
            // 
            // linkLabelCurrent
            // 
            this.linkLabelCurrent.AutoSize = true;
            this.linkLabelCurrent.Location = new System.Drawing.Point(350, 104);
            this.linkLabelCurrent.Name = "linkLabelCurrent";
            this.linkLabelCurrent.Size = new System.Drawing.Size(53, 12);
            this.linkLabelCurrent.TabIndex = 12;
            this.linkLabelCurrent.TabStop = true;
            this.linkLabelCurrent.Text = "当前路径";
            this.linkLabelCurrent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCurrent_LinkClicked);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(407, 28);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(59, 23);
            this.btnSelectFile.TabIndex = 13;
            this.btnSelectFile.Text = "选择...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // linkLabelGotoCurrentPath
            // 
            this.linkLabelGotoCurrentPath.AutoSize = true;
            this.linkLabelGotoCurrentPath.Location = new System.Drawing.Point(350, 59);
            this.linkLabelGotoCurrentPath.Name = "linkLabelGotoCurrentPath";
            this.linkLabelGotoCurrentPath.Size = new System.Drawing.Size(53, 12);
            this.linkLabelGotoCurrentPath.TabIndex = 17;
            this.linkLabelGotoCurrentPath.TabStop = true;
            this.linkLabelGotoCurrentPath.Text = "当前路径";
            this.linkLabelGotoCurrentPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGotoCurrentPath_LinkClicked);
            // 
            // txtAppBasePath
            // 
            this.txtAppBasePath.Location = new System.Drawing.Point(12, 74);
            this.txtAppBasePath.Name = "txtAppBasePath";
            this.txtAppBasePath.Size = new System.Drawing.Size(389, 21);
            this.txtAppBasePath.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "程序文件路径";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "选择...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabelGotoCurrentPath);
            this.Controls.Add(this.txtAppBasePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.linkLabelCurrent);
            this.Controls.Add(this.linkLabelDesktop);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.txtReleasePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownVer);
            this.Controls.Add(this.txtReleaseFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.txtFileList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckFileList);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "应用程序发布工具";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckFileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileList;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.TextBox txtReleaseFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReleasePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.LinkLabel linkLabelDesktop;
        private System.Windows.Forms.LinkLabel linkLabelCurrent;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabelGotoCurrentPath;
        private System.Windows.Forms.TextBox txtAppBasePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

