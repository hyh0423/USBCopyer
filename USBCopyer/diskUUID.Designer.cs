﻿namespace USBCopyer
{
    partial class diskUUID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diskList = new System.Windows.Forms.ListBox();
            this.thisDiskID = new System.Windows.Forms.TextBox();
            this.thisDiskDescription = new System.Windows.Forms.TextBox();
            this.thisDiskFileSystem = new System.Windows.Forms.TextBox();
            this.thisDiskName = new System.Windows.Forms.TextBox();
            this.thisDiskSer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reloadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // diskList
            // 
            this.diskList.FormattingEnabled = true;
            this.diskList.ItemHeight = 15;
            this.diskList.Location = new System.Drawing.Point(16, 15);
            this.diskList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diskList.Name = "diskList";
            this.diskList.Size = new System.Drawing.Size(107, 319);
            this.diskList.TabIndex = 1;
            this.diskList.SelectedIndexChanged += new System.EventHandler(this.diskList_SelectedIndexChanged);
            // 
            // thisDiskID
            // 
            this.thisDiskID.Location = new System.Drawing.Point(263, 15);
            this.thisDiskID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thisDiskID.Name = "thisDiskID";
            this.thisDiskID.ReadOnly = true;
            this.thisDiskID.Size = new System.Drawing.Size(213, 25);
            this.thisDiskID.TabIndex = 2;
            // 
            // thisDiskDescription
            // 
            this.thisDiskDescription.Location = new System.Drawing.Point(263, 116);
            this.thisDiskDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thisDiskDescription.Name = "thisDiskDescription";
            this.thisDiskDescription.ReadOnly = true;
            this.thisDiskDescription.Size = new System.Drawing.Size(436, 25);
            this.thisDiskDescription.TabIndex = 4;
            // 
            // thisDiskFileSystem
            // 
            this.thisDiskFileSystem.Location = new System.Drawing.Point(263, 150);
            this.thisDiskFileSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thisDiskFileSystem.Name = "thisDiskFileSystem";
            this.thisDiskFileSystem.ReadOnly = true;
            this.thisDiskFileSystem.Size = new System.Drawing.Size(436, 25);
            this.thisDiskFileSystem.TabIndex = 5;
            // 
            // thisDiskName
            // 
            this.thisDiskName.Location = new System.Drawing.Point(263, 82);
            this.thisDiskName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thisDiskName.Name = "thisDiskName";
            this.thisDiskName.ReadOnly = true;
            this.thisDiskName.Size = new System.Drawing.Size(436, 25);
            this.thisDiskName.TabIndex = 6;
            // 
            // thisDiskSer
            // 
            this.thisDiskSer.Location = new System.Drawing.Point(263, 49);
            this.thisDiskSer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thisDiskSer.Name = "thisDiskSer";
            this.thisDiskSer.ReadOnly = true;
            this.thisDiskSer.Size = new System.Drawing.Size(436, 25);
            this.thisDiskSer.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "磁盘盘符";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "磁盘序列号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "磁盘卷标";
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(135, 289);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(151, 46);
            this.reloadButton.TabIndex = 11;
            this.reloadButton.Text = "刷新 (&R)";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "磁盘文件系统";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "磁盘描述";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel4.Location = new System.Drawing.Point(312, 304);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(79, 15);
            this.linkLabel4.TabIndex = 25;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "USBCopyer";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 305);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "//";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(544, 305);
            this.version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(71, 15);
            this.version.TabIndex = 23;
            this.version.Text = "Version.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(412, 304);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 15);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "作者：Kenvix";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "磁盘序列号可用于 USBCopyer 黑白名单";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "若磁盘文件系统一栏为空，表该驱动器是空的";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "部分磁盘的卷无法获取序列号";
            // 
            // diskUUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 346);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.version);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thisDiskSer);
            this.Controls.Add(this.thisDiskName);
            this.Controls.Add(this.thisDiskFileSystem);
            this.Controls.Add(this.thisDiskDescription);
            this.Controls.Add(this.thisDiskID);
            this.Controls.Add(this.diskList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "diskUUID";
            this.Text = "查看磁盘信息";
            this.Load += new System.EventHandler(this.diskUUID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox diskList;
        private System.Windows.Forms.TextBox thisDiskID;
        private System.Windows.Forms.TextBox thisDiskDescription;
        private System.Windows.Forms.TextBox thisDiskFileSystem;
        private System.Windows.Forms.TextBox thisDiskName;
        private System.Windows.Forms.TextBox thisDiskSer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}