namespace WindowsFormsApp1
{
    partial class FormAdvancedSetting
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExtension = new System.Windows.Forms.TextBox();
            this.tbTargetDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetTarget = new System.Windows.Forms.Button();
            this.fbdSetTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExtensionExample = new System.Windows.Forms.Button();
            this.opdExtensionExample = new System.Windows.Forms.OpenFileDialog();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lboxSetting = new System.Windows.Forms.ListBox();
            this.contextMenuSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(242, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "副檔名:";
            // 
            // tbExtension
            // 
            this.tbExtension.Location = new System.Drawing.Point(89, 25);
            this.tbExtension.Name = "tbExtension";
            this.tbExtension.Size = new System.Drawing.Size(98, 22);
            this.tbExtension.TabIndex = 3;
            // 
            // tbTargetDirectory
            // 
            this.tbTargetDirectory.Location = new System.Drawing.Point(89, 53);
            this.tbTargetDirectory.Name = "tbTargetDirectory";
            this.tbTargetDirectory.Size = new System.Drawing.Size(210, 22);
            this.tbTargetDirectory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "儲存位置:";
            // 
            // btnSetTarget
            // 
            this.btnSetTarget.Location = new System.Drawing.Point(319, 51);
            this.btnSetTarget.Name = "btnSetTarget";
            this.btnSetTarget.Size = new System.Drawing.Size(75, 23);
            this.btnSetTarget.TabIndex = 6;
            this.btnSetTarget.Text = "選擇位置";
            this.btnSetTarget.UseVisualStyleBackColor = true;
            this.btnSetTarget.Click += new System.EventHandler(this.btnSetTarget_Click);
            // 
            // btnExtensionExample
            // 
            this.btnExtensionExample.Location = new System.Drawing.Point(319, 22);
            this.btnExtensionExample.Name = "btnExtensionExample";
            this.btnExtensionExample.Size = new System.Drawing.Size(75, 23);
            this.btnExtensionExample.TabIndex = 7;
            this.btnExtensionExample.Text = "副檔名範例";
            this.btnExtensionExample.UseVisualStyleBackColor = true;
            this.btnExtensionExample.Click += new System.EventHandler(this.btnExtensionExample_Click);
            // 
            // opdExtensionExample
            // 
            this.opdExtensionExample.FileName = "openFileDialog1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(319, 81);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lboxSetting
            // 
            this.lboxSetting.ContextMenuStrip = this.contextMenuSetting;
            this.lboxSetting.FormattingEnabled = true;
            this.lboxSetting.ItemHeight = 12;
            this.lboxSetting.Location = new System.Drawing.Point(29, 122);
            this.lboxSetting.Name = "lboxSetting";
            this.lboxSetting.Size = new System.Drawing.Size(365, 208);
            this.lboxSetting.TabIndex = 9;
            this.lboxSetting.SelectedIndexChanged += new System.EventHandler(this.lboxSetting_SelectedIndexChanged);
            // 
            // contextMenuSetting
            // 
            this.contextMenuSetting.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移除ToolStripMenuItem});
            this.contextMenuSetting.Name = "contextMenuSetting";
            this.contextMenuSetting.Size = new System.Drawing.Size(99, 26);
            this.contextMenuSetting.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuSetting_ItemClicked);
            // 
            // 移除ToolStripMenuItem
            // 
            this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            this.移除ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.移除ToolStripMenuItem.Text = "移除";
            // 
            // FormAdvancedSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 371);
            this.Controls.Add(this.lboxSetting);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnExtensionExample);
            this.Controls.Add(this.btnSetTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTargetDirectory);
            this.Controls.Add(this.tbExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FormAdvancedSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定";
            this.contextMenuSetting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExtension;
        private System.Windows.Forms.TextBox tbTargetDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetTarget;
        private System.Windows.Forms.FolderBrowserDialog fbdSetTarget;
        private System.Windows.Forms.Button btnExtensionExample;
        private System.Windows.Forms.OpenFileDialog opdExtensionExample;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox lboxSetting;
        private System.Windows.Forms.ContextMenuStrip contextMenuSetting;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem;
    }
}