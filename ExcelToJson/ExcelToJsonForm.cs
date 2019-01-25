using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LitJson;

namespace ExcelToJson
{
    public partial class ExcelToJsonForm : Form
    {
        public string fileName = "default";
        public string csFileName = "default";
        public ExcelToJsonForm()
        {
            InitializeComponent();
            ReadPathConfig();
        }

        /// <summary>
        /// Select excel folder
        /// </summary>
        private void SelctFolder_ClickEvent(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (sender == this.btnOpenFile)
                fbd.SelectedPath = this.txtExcelPath.Text;
            else if (sender == this.btnOpenSavePath)
                fbd.SelectedPath = this.txtSavePath.Text;
            else if (sender == this.btnOpenCsharpPath)
                fbd.SelectedPath = this.txtCSPath.Text;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (sender == this.btnOpenFile)
                {
                    this.txtExcelPath.Text = fbd.SelectedPath;
                    UpdateExcelFolderFiles();
                }
                else if (sender == this.btnOpenSavePath)
                {
                    this.txtSavePath.Text = fbd.SelectedPath;
                }
                else if (sender == this.btnOpenCsharpPath)
                {
                    this.txtCSPath.Text = fbd.SelectedPath;
                }
            }
        }


        /// <summary>
        /// Get all the excel files under current folder
        /// </summary>
        private void UpdateExcelFolderFiles()
        {
            if (this.txtExcelPath.Text == "")
                return;

            DirectoryInfo di = new DirectoryInfo(this.txtExcelPath.Text);
            FileInfo[] files = di.GetFiles("*.xls*"); 
            this.listFiles.Items.Clear();
            foreach (FileInfo fileinfo in files)
            {
                if(fileinfo.Extension.ToLower()==".xls"||fileinfo.Extension.ToLower()==".xlsx")
                    this.listFiles.Items.Add(fileinfo.Name);
            }
        }


        /// <summary>
        /// Convert excel to json
        /// </summary>
        /// <param name="path">Source path</param>
        /// <param name="isSaveCsFile">export code or not</param>
        /// <returns>result</returns>
        public string ExcelToJsonStr(string path, bool isSaveCsFile = false)
        {
            try
            {
                string extension = Path.GetExtension(path);
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @path + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
                if(extension.ToLower()==".xlsx")
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @path + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";

                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                strExcel = "select * from [sheet1$]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                DataTable table = new DataTable();
                myCommand.Fill(table);

                string csFile = "public class " + csFileName + " : EasyGame.IConfig\n{\n\n";
                csFile += "\tpublic int UniqueID { get; }\n";
                bool csFileDone = false;

                JsonWriter jsonW = new JsonWriter();
                jsonW.WriteArrayStart();

                DataRow attributeRow = table.Rows[0]; 
                for(int i = 1; i< table.Rows.Count; i++)
                {
                   
                    DataRow dr = table.Rows[i];
                    if (dr.ItemArray[0].ToString() == "")
                        continue;

                    jsonW.WriteObjectStart();
                    for(int j = 0; j< table.Columns.Count; j++)
                    {
                         DataColumn dc = table.Columns[j];
                        
                        string attributeName = attributeRow.ItemArray[j].ToString();
                        if(attributeName == "" || attributeName.Contains("["))
                        {
                            continue;
                        }

                        jsonW.WritePropertyName(attributeName);
                        jsonW.Write(dr[j].ToString());
                        string a = dr[j].ToString();

                        Regex r=new Regex(@"^\d+(\.)?\d*$");
                        string valueType = "string";
                        if(r.IsMatch(a))
                        {
                            if (a.Contains("."))
                                valueType = "float";
                             else
                                 valueType = "int";
                        }
                        else if (a.Contains(","))
                        {
                            valueType = "int[]";
                        }

                        if (!csFileDone)
                        {
                            csFile += "\t/// <summary>\n";
                            string annotation = dc.ColumnName.Replace("_","\n\t/// ");
                            csFile += "\t/// " + annotation + "\n";
                            csFile += "\t/// </summary>\n";
                            csFile += "\tpublic " + valueType + " " + attributeName + ";\n" + "\n";
                           
                        }
                   }
                    csFileDone = true;
                    jsonW.WriteObjectEnd();
                }
                csFile += "}";

                if (isSaveCsFile)
                {
                    FileStream myFs = new FileStream(this.txtCSPath.Text + "\\" + csFileName + ".cs", FileMode.Create);
                    StreamWriter mySw = new StreamWriter(myFs);
                    mySw.Write(csFile);
                    mySw.Close();
                }

                jsonW.WriteArrayEnd();
                return Regex.Unescape(jsonW.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + ex.StackTrace.ToString());
            }
            return null;
        }


        /// <summary>
        /// Create json
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.listFiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose an Excel file!");
                return;
            }
            if (this.txtSavePath.Text == string.Empty)
            {
                MessageBox.Show("Please specify target folder for JSON files!");
                return;
            }
            if (this.cbIsCsFile.Checked && this.txtCSPath.Text == string.Empty)
            {
                MessageBox.Show("Please specify target folder for C# files!");
                return;
            }
            textJsonInfo.Text = string.Empty;
            txtInfo.Text = string.Empty;
            if (!Directory.Exists(this.txtSavePath.Text))
            {
                Directory.CreateDirectory(this.txtSavePath.Text);
            }

            SavePathConfig();

            for (int i = 0; i < this.listFiles.SelectedItems.Count; i++)
            {
                CreateJsonFile(this.txtExcelPath.Text + "\\" + this.listFiles.SelectedItems[i].ToString(), this.txtSavePath.Text);
            }

            txtInfo.Text += "Finished all !";
           
        }
        /// <summary>
        /// Create json file
        /// </summary>
        private void CreateJsonFile(string path, string savePath)
        {
            csFileName = Path.GetFileNameWithoutExtension(path);
            fileName = csFileName  + ".json";
            //if (!cbIsDat.Checked)
            //    fileName = "__" + fileName;

            bool showOutput = checkBoxShowOutput.Checked;
            string strJson = ExcelToJsonStr(path,cbIsCsFile.Checked);
            if (strJson != string.Empty && strJson!=null)
            {
                savePath = savePath  +"\\"+ fileName;
                string writeStr = string.Empty;
                if (cbIsDat.Checked)
                    writeStr = CompressTool.Compress(strJson);
                else
                {
                    writeStr = strJson;
                }
                FileStream fs = new FileStream(savePath, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(writeStr);
                sw.Close();
                txtInfo.Text += "Generated: " + fileName + "\r\n";
                if (showOutput)
                    textJsonInfo.Text += "Json: " + fileName + "\r\n" + strJson + "\r\n\r\n";
            }
            else
            {
                txtInfo.Text += fileName + " not generated ERROR\r\n";
                textJsonInfo.Text += fileName + " not generated ERROR\r\n";
            }

            if (showOutput)
            {
                this.textJsonInfo.Select(this.textJsonInfo.TextLength, 0);
                this.textJsonInfo.ScrollToCaret();
                this.txtInfo.Select(this.textJsonInfo.TextLength, 0);
                this.txtInfo.ScrollToCaret();
            }
        }

        string pathConfigFile =  System.Environment.CurrentDirectory + @"\PathConfig.txt";
        /// <summary>
        /// Path config to txt
        /// </summary>
        private void SavePathConfig()
        {
            FileStream myFs = new FileStream(pathConfigFile, FileMode.Create);
            StreamWriter mySw = new StreamWriter(myFs);
            mySw.WriteLine(this.txtExcelPath.Text);
            mySw.WriteLine(this.txtSavePath.Text);
            mySw.WriteLine(this.txtCSPath.Text);
            mySw.Close();
            myFs.Close();
        }

        /// <summary>
        /// Read path config
        /// </summary>
        private void ReadPathConfig()
        {
            if (File.Exists(pathConfigFile))
            {
                FileStream fs = new FileStream(pathConfigFile, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string path1 = sr.ReadLine();
                string path2 = sr.ReadLine();
                string path3 = sr.ReadLine();
                fs.Close();
                sr.Close();
                if (Directory.Exists(Path.GetDirectoryName(pathConfigFile)))
                {
                    this.txtExcelPath.Text = path1;
                    UpdateExcelFolderFiles();
                }

                if(Directory.Exists(Path.GetDirectoryName(pathConfigFile)))
                    this.txtSavePath.Text = path2;

                if (Directory.Exists(Path.GetDirectoryName(pathConfigFile)))
                    this.txtCSPath.Text = path3;

            }
        }

        /// <summary>
        /// Select all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSelAll_CheckedChanged(object sender, EventArgs e)
        {
            for(int i=0;i<this.listFiles.Items.Count;i++)
            {
                this.listFiles.SetSelected(i,this.cbSelAll.Checked);
            }
        }
    }
}