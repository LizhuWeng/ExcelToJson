namespace ExcelToJson
{
    partial class ExcelToJsonForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelToJsonForm));
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenSavePath = new System.Windows.Forms.Button();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textJsonInfo = new System.Windows.Forms.TextBox();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelAll = new System.Windows.Forms.CheckBox();
            this.cbIsDat = new System.Windows.Forms.CheckBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenCsharpPath = new System.Windows.Forms.Button();
            this.txtCSPath = new System.Windows.Forms.TextBox();
            this.cbIsCsFile = new System.Windows.Forms.CheckBox();
            this.checkBoxShowOutput = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(14, 15);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(149, 29);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Select Excel Folder";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.SelctFolder_ClickEvent);
            // 
            // btnOpenSavePath
            // 
            this.btnOpenSavePath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSavePath.Location = new System.Drawing.Point(14, 51);
            this.btnOpenSavePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenSavePath.Name = "btnOpenSavePath";
            this.btnOpenSavePath.Size = new System.Drawing.Size(149, 29);
            this.btnOpenSavePath.TabIndex = 3;
            this.btnOpenSavePath.Text = "Save Json To";
            this.btnOpenSavePath.UseVisualStyleBackColor = true;
            this.btnOpenSavePath.Click += new System.EventHandler(this.SelctFolder_ClickEvent);
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.AllowDrop = true;
            this.txtExcelPath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcelPath.Location = new System.Drawing.Point(170, 16);
            this.txtExcelPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(417, 21);
            this.txtExcelPath.TabIndex = 4;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Font = new System.Drawing.Font("Arial", 9F);
            this.txtSavePath.Location = new System.Drawing.Point(170, 52);
            this.txtSavePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(417, 21);
            this.txtSavePath.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(623, 22);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(175, 80);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Generate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // textJsonInfo
            // 
            this.textJsonInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.textJsonInfo.Location = new System.Drawing.Point(436, 311);
            this.textJsonInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textJsonInfo.Multiline = true;
            this.textJsonInfo.Name = "textJsonInfo";
            this.textJsonInfo.ReadOnly = true;
            this.textJsonInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textJsonInfo.Size = new System.Drawing.Size(522, 250);
            this.textJsonInfo.TabIndex = 7;
            // 
            // listFiles
            // 
            this.listFiles.AllowDrop = true;
            this.listFiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 15;
            this.listFiles.Location = new System.Drawing.Point(14, 182);
            this.listFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listFiles.Name = "listFiles";
            this.listFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listFiles.Size = new System.Drawing.Size(398, 379);
            this.listFiles.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Excel Files [Press Ctrl key for multiple choice]";
            // 
            // cbSelAll
            // 
            this.cbSelAll.AutoSize = true;
            this.cbSelAll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelAll.Location = new System.Drawing.Point(357, 145);
            this.cbSelAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSelAll.Name = "cbSelAll";
            this.cbSelAll.Size = new System.Drawing.Size(75, 19);
            this.cbSelAll.TabIndex = 11;
            this.cbSelAll.Text = "Select All";
            this.cbSelAll.UseVisualStyleBackColor = true;
            this.cbSelAll.CheckedChanged += new System.EventHandler(this.cbSelAll_CheckedChanged);
            // 
            // cbIsDat
            // 
            this.cbIsDat.AutoSize = true;
            this.cbIsDat.Font = new System.Drawing.Font("Arial", 9F);
            this.cbIsDat.Location = new System.Drawing.Point(833, 22);
            this.cbIsDat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIsDat.Name = "cbIsDat";
            this.cbIsDat.Size = new System.Drawing.Size(99, 19);
            this.cbIsDat.TabIndex = 12;
            this.cbIsDat.Text = "Compressed";
            this.cbIsDat.UseVisualStyleBackColor = true;

            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.txtInfo.Location = new System.Drawing.Point(433, 191);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(525, 96);
            this.txtInfo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Json Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Log output";
            // 
            // btnOpenCsharpPath
            // 
            this.btnOpenCsharpPath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCsharpPath.Location = new System.Drawing.Point(14, 86);
            this.btnOpenCsharpPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenCsharpPath.Name = "btnOpenCsharpPath";
            this.btnOpenCsharpPath.Size = new System.Drawing.Size(149, 29);
            this.btnOpenCsharpPath.TabIndex = 3;
            this.btnOpenCsharpPath.Text = "Save C# To";
            this.btnOpenCsharpPath.UseVisualStyleBackColor = true;
            this.btnOpenCsharpPath.Click += new System.EventHandler(this.SelctFolder_ClickEvent);
            // 
            // txtCSPath
            // 
            this.txtCSPath.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCSPath.Location = new System.Drawing.Point(170, 89);
            this.txtCSPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCSPath.Name = "txtCSPath";
            this.txtCSPath.Size = new System.Drawing.Size(417, 21);
            this.txtCSPath.TabIndex = 5;
            // 
            // cbIsCsFile
            // 
            this.cbIsCsFile.AutoSize = true;
            this.cbIsCsFile.Font = new System.Drawing.Font("Arial", 9F);
            this.cbIsCsFile.Location = new System.Drawing.Point(833, 60);
            this.cbIsCsFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIsCsFile.Name = "cbIsCsFile";
            this.cbIsCsFile.Size = new System.Drawing.Size(93, 19);
            this.cbIsCsFile.TabIndex = 22;
            this.cbIsCsFile.Text = "Export Code";
            this.cbIsCsFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowOutput
            // 
            this.checkBoxShowOutput.AutoSize = true;
            this.checkBoxShowOutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowOutput.Location = new System.Drawing.Point(833, 94);
            this.checkBoxShowOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxShowOutput.Name = "checkBoxShowOutput";
            this.checkBoxShowOutput.Size = new System.Drawing.Size(126, 19);
            this.checkBoxShowOutput.TabIndex = 23;
            this.checkBoxShowOutput.Text = "Show Json Result";
            this.checkBoxShowOutput.UseVisualStyleBackColor = true;
            // 
            // ExcelToJsonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 578);
            this.Controls.Add(this.checkBoxShowOutput);
            this.Controls.Add(this.cbIsCsFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.cbIsDat);
            this.Controls.Add(this.cbSelAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.textJsonInfo);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCSPath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.txtExcelPath);
            this.Controls.Add(this.btnOpenCsharpPath);
            this.Controls.Add(this.btnOpenSavePath);
            this.Controls.Add(this.btnOpenFile);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(989, 865);
            this.MinimumSize = new System.Drawing.Size(989, 615);
            this.Name = "ExcelToJsonForm";
            this.Text = "ExcelToJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenSavePath;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textJsonInfo;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSelAll;
        private System.Windows.Forms.CheckBox cbIsDat;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenCsharpPath;
        private System.Windows.Forms.TextBox txtCSPath;
        private System.Windows.Forms.CheckBox cbIsCsFile;
        private System.Windows.Forms.CheckBox checkBoxShowOutput;
    }
}

