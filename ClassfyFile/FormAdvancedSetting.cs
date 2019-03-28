using ClassfyFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class FormAdvancedSetting : Form
    {
        public List<FileSetting> fileSettings ;

        public FormAdvancedSetting()
        {
            InitializeComponent();
            Init();
        }
        //Todo 設定ListBox顯示格式
        public void  SetListBoxShow()
        {
            this.lboxSetting.Items.Clear();
            if (fileSettings != null && fileSettings.Count > 0)
            {
                foreach (var property in fileSettings)
                {
                    this.lboxSetting.Items.Add(property.ToListShow());
                }
            }
        }
        public void Init()
        {
            fileSettings = JsonConvert.DeserializeObject<List<FileSetting>>(ClassfyFile.Properties.Settings.Default[ConstValue.PROPERTY_NORMALSETTING].ToString()) ?? new List<FileSetting>();
            SetListBoxShow();
        }

        public void AddToSetting(FileSetting fileSetting)
        {
            var querySettings = fileSettings.FindAll(x => string.Equals(x.Extension, fileSetting.Extension));
            if (querySettings != null && querySettings.Count > 0)
            {
                querySettings.FirstOrDefault().DirectoryPath = fileSetting.DirectoryPath;
            }
            else
            {
                fileSettings.Add(fileSetting);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var jsonSetting = JsonConvert.SerializeObject(fileSettings);
            ClassfyFile.Properties.Settings.Default.NormalSetting = jsonSetting;
            ClassfyFile.Properties.Settings.Default.Save();
            
            this.Close();
        }

        private void btnSetTarget_Click(object sender, EventArgs e)
        {
            if (this.fbdSetTarget.ShowDialog() == DialogResult.OK)
            {
                this.tbTargetDirectory.Text = fbdSetTarget.SelectedPath;
            }
        }

        private void btnExtensionExample_Click(object sender, EventArgs e)
        {
            if (this.opdExtensionExample.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(opdExtensionExample.FileName);
                this.tbExtension.Text = extension;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbExtension.Text) && !string.IsNullOrEmpty(tbTargetDirectory.Text))
            {
                FileSetting fileSetting = new FileSetting() {
                    DirectoryPath = tbTargetDirectory.Text,
                    Extension = tbExtension.Text,
                };

                AddToSetting(fileSetting);
                SetListBoxShow();
            }
            else
            {
                MessageBox.Show("請輸入正確副檔名及檔案預儲存位置");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lboxSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).SelectedIndex != -1)
            {
                 string[] item = lboxSetting.Items[(sender as ListBox).SelectedIndex].ToString().Split('\t');
                tbTargetDirectory.Text = item[1].Trim(' ');
                tbExtension.Text = item[0].Trim(' ');
            }
        }

        private void contextMenuSetting_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = this.lboxSetting.SelectedIndex;
            string[] item = lboxSetting.Items[index].ToString().Split('\t');

            if (index != -1)
            {
                switch (e.ClickedItem.Text)
                {
                    case "移除":
                        int indexSetting = fileSettings.FindIndex(x => string.Equals(x.Extension, item[0]) && string.Equals(x.DirectoryPath, item[1]));
                        fileSettings.RemoveAt(indexSetting);
                        break;
                    default:
                        break;
                }
            }
            SetListBoxShow();

        }
    }
}
