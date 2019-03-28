using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassfyFile
{
    public partial class Form : System.Windows.Forms.Form
    {
        public List<FileSetting> fileSettings;
        public Form()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {          
            fileSettings = JsonConvert.DeserializeObject<List<FileSetting>>(ClassfyFile.Properties.Settings.Default[ConstValue.PROPERTY_NORMALSETTING].ToString()) ?? new List<FileSetting>();
            this.tbSetTarget.Text = Properties.Settings.Default.TargetPath;
            if (!string.IsNullOrEmpty(this.tbSetTarget.Text))
            {
                ShowTargetFile(this.tbSetTarget.Text);
            }
            

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Properties.Settings.Default.TargetPath;
            if (!string.IsNullOrEmpty(watcher.Path))
            {
                watcher.EnableRaisingEvents = true;
                watcher.Created += Watcher_Created;            
            }
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            string directPath = e.FullPath;
            string extension = Path.GetExtension(directPath);

            var query = fileSettings.FindAll(x => string.Equals(x.Extension, extension));
            if (query != null && query.Count > 0)
            {
                MoveFileToTargetPath(query.FirstOrDefault(), e.FullPath, e.Name);
            }
        }
        public void MoveFileToTargetPath(FileSetting fileSetting,string fullPath,string fileName)
        {
            string fileTarget = fileSetting.DirectoryPath;
            if (!Directory.Exists(fileTarget))
            {
                Directory.CreateDirectory(fileTarget);
            }
            fileTarget = fileTarget + "\\" + fileName;
            int num = 1;
            while (File.Exists(fileTarget))
            {
                Regex regexFileName =new Regex(@"\(\d*\)");
               
                string extension = Path.GetExtension(fileTarget);
                string name = Path.GetFileNameWithoutExtension(fileTarget);
                string changeName;
                if (regexFileName.IsMatch(name))
                {
                    changeName = Regex.Replace(name, @"\(\d*\)", "("+num+")");
                }
                else
                {
                    changeName = name + "(" + num + ")";
                }
                changeName = changeName + extension;
                fileTarget =  Path.Combine(fileSetting.DirectoryPath,changeName);
                num++;
            }
            File.Move(fullPath, fileTarget);
        }
        private void ShowTargetFile(string path)
        {
            this.lboxTargetFile.Items.Clear();
            int num = 1;
            var files = System.IO.Directory.GetFiles(path);
            var directorys = System.IO.Directory.GetDirectories(path);
            this.lboxTargetFile.Items.Add("檔案或連結");
            foreach (var file in files)
            {              
                string filelist = file.Replace(path + "\\",num.ToString()+"."+string.Empty);
                this.lboxTargetFile.Items.Add(filelist);
                num++;
            }
            num = 1;
            this.lboxTargetFile.Items.Add(string.Empty);
            this.lboxTargetFile.Items.Add("資料夾");
            foreach (var directory in directorys)
            {
                string filelist = directory.Replace(path + "\\", num.ToString()+"."+string.Empty);
                this.lboxTargetFile.Items.Add(filelist);
                num++;
            }
        }

        private void btnSetTarget_Click(object sender, EventArgs e)
        {
            if (this.fbdSetTarget.ShowDialog() == DialogResult.OK)
            {
                this.tbSetTarget.Text = fbdSetTarget.SelectedPath;
                ShowTargetFile(fbdSetTarget.SelectedPath);
            }
        }

        private void btnAdvancedSetting_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.FormAdvancedSetting form = new WindowsFormsApp1.FormAdvancedSetting();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Init();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.FormAdvancedSetting form = new WindowsFormsApp1.FormAdvancedSetting();
            var jsonSetting = JsonConvert.SerializeObject(form.fileSettings);
            ClassfyFile.Properties.Settings.Default.NormalSetting = jsonSetting;
            if (!string.IsNullOrEmpty(this.tbSetTarget.Text))
            {
                Properties.Settings.Default.TargetPath = this.tbSetTarget.Text;
            }
            else
            {
                MessageBox.Show("請輸入目標位置");
            }
            ClassfyFile.Properties.Settings.Default.Save();
            Init();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCLassfySelft_Click(object sender, EventArgs e)
        {
            string targetPath = Properties.Settings.Default.TargetPath;
            fileSettings = JsonConvert.DeserializeObject<List<FileSetting>>(ClassfyFile.Properties.Settings.Default[ConstValue.PROPERTY_NORMALSETTING].ToString()) ?? new List<FileSetting>();

            var files = Directory.GetFiles(targetPath);
            foreach (var file in files)
            {
                var query = fileSettings.Find(x=>string.Equals(x.Extension,Path.GetExtension(file)));
                if (query != null)
                {
                    MoveFileToTargetPath(query,Path.GetFullPath(file),Path.GetFileName(file));
                }
            }
            ShowTargetFile(targetPath);
            MessageBox.Show("整理結束");                       
        }
    }
}
