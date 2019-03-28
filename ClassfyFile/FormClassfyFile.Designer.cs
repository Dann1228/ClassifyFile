namespace ClassfyFile
{
    partial class Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetTarget = new System.Windows.Forms.Button();
            this.gbNormalSetting = new System.Windows.Forms.GroupBox();
            this.btnAdvancedSetting = new System.Windows.Forms.Button();
            this.tbSetTarget = new System.Windows.Forms.TextBox();
            this.lbSetTarget = new System.Windows.Forms.Label();
            this.fbdSetTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.lboxTargetFile = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCLassfySelft = new System.Windows.Forms.Button();
            this.gbNormalSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetTarget
            // 
            this.btnSetTarget.Location = new System.Drawing.Point(269, 49);
            this.btnSetTarget.Name = "btnSetTarget";
            this.btnSetTarget.Size = new System.Drawing.Size(75, 23);
            this.btnSetTarget.TabIndex = 0;
            this.btnSetTarget.Text = "選擇位置";
            this.btnSetTarget.UseVisualStyleBackColor = true;
            this.btnSetTarget.Click += new System.EventHandler(this.btnSetTarget_Click);
            // 
            // gbNormalSetting
            // 
            this.gbNormalSetting.Controls.Add(this.btnAdvancedSetting);
            this.gbNormalSetting.Controls.Add(this.tbSetTarget);
            this.gbNormalSetting.Controls.Add(this.lbSetTarget);
            this.gbNormalSetting.Controls.Add(this.btnSetTarget);
            this.gbNormalSetting.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbNormalSetting.Location = new System.Drawing.Point(36, 12);
            this.gbNormalSetting.Name = "gbNormalSetting";
            this.gbNormalSetting.Size = new System.Drawing.Size(362, 111);
            this.gbNormalSetting.TabIndex = 1;
            this.gbNormalSetting.TabStop = false;
            this.gbNormalSetting.Text = "一般設定";
            // 
            // btnAdvancedSetting
            // 
            this.btnAdvancedSetting.Location = new System.Drawing.Point(269, 78);
            this.btnAdvancedSetting.Name = "btnAdvancedSetting";
            this.btnAdvancedSetting.Size = new System.Drawing.Size(75, 23);
            this.btnAdvancedSetting.TabIndex = 3;
            this.btnAdvancedSetting.Text = "設定";
            this.btnAdvancedSetting.UseVisualStyleBackColor = true;
            this.btnAdvancedSetting.Click += new System.EventHandler(this.btnAdvancedSetting_Click);
            // 
            // tbSetTarget
            // 
            this.tbSetTarget.Location = new System.Drawing.Point(29, 51);
            this.tbSetTarget.Name = "tbSetTarget";
            this.tbSetTarget.Size = new System.Drawing.Size(234, 22);
            this.tbSetTarget.TabIndex = 2;
            // 
            // lbSetTarget
            // 
            this.lbSetTarget.AutoSize = true;
            this.lbSetTarget.Location = new System.Drawing.Point(27, 32);
            this.lbSetTarget.Name = "lbSetTarget";
            this.lbSetTarget.Size = new System.Drawing.Size(77, 12);
            this.lbSetTarget.TabIndex = 1;
            this.lbSetTarget.Text = "選擇目標位置";
            // 
            // lboxTargetFile
            // 
            this.lboxTargetFile.FormattingEnabled = true;
            this.lboxTargetFile.ItemHeight = 12;
            this.lboxTargetFile.Location = new System.Drawing.Point(36, 129);
            this.lboxTargetFile.Name = "lboxTargetFile";
            this.lboxTargetFile.Size = new System.Drawing.Size(362, 196);
            this.lboxTargetFile.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCLassfySelft
            // 
            this.btnCLassfySelft.Location = new System.Drawing.Point(36, 351);
            this.btnCLassfySelft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCLassfySelft.Name = "btnCLassfySelft";
            this.btnCLassfySelft.Size = new System.Drawing.Size(92, 23);
            this.btnCLassfySelft.TabIndex = 5;
            this.btnCLassfySelft.Text = "手動整理";
            this.btnCLassfySelft.UseVisualStyleBackColor = true;
            this.btnCLassfySelft.Click += new System.EventHandler(this.btnCLassfySelft_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(429, 407);
            this.Controls.Add(this.btnCLassfySelft);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lboxTargetFile);
            this.Controls.Add(this.gbNormalSetting);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassfyFile";
            this.gbNormalSetting.ResumeLayout(false);
            this.gbNormalSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetTarget;
        private System.Windows.Forms.GroupBox gbNormalSetting;
        private System.Windows.Forms.TextBox tbSetTarget;
        private System.Windows.Forms.Label lbSetTarget;
        private System.Windows.Forms.FolderBrowserDialog fbdSetTarget;
        private System.Windows.Forms.Button btnAdvancedSetting;
        private System.Windows.Forms.ListBox lboxTargetFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCLassfySelft;
    }
}

