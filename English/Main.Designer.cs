namespace English
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnTest;
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnOld = new System.Windows.Forms.Button();
            this.btnImportTxT = new System.Windows.Forms.Button();
            this.listWord = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnTest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btnTest.ForeColor = System.Drawing.Color.White;
            btnTest.Location = new System.Drawing.Point(251, 383);
            btnTest.Name = "btnTest";
            btnTest.Size = new System.Drawing.Size(90, 73);
            btnTest.TabIndex = 5;
            btnTest.Text = "測驗";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInput.Location = new System.Drawing.Point(25, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 33);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(251, 40);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(90, 33);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "輸入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(251, 116);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(90, 40);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "系統參數";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnOld
            // 
            this.btnOld.Location = new System.Drawing.Point(251, 162);
            this.btnOld.Name = "btnOld";
            this.btnOld.Size = new System.Drawing.Size(90, 40);
            this.btnOld.TabIndex = 7;
            this.btnOld.Text = "舊資料";
            this.btnOld.UseVisualStyleBackColor = true;
            this.btnOld.Click += new System.EventHandler(this.btnOld_Click);
            // 
            // btnImportTxT
            // 
            this.btnImportTxT.Location = new System.Drawing.Point(251, 208);
            this.btnImportTxT.Name = "btnImportTxT";
            this.btnImportTxT.Size = new System.Drawing.Size(90, 40);
            this.btnImportTxT.TabIndex = 8;
            this.btnImportTxT.Text = "匯入";
            this.btnImportTxT.UseVisualStyleBackColor = true;
            this.btnImportTxT.Click += new System.EventHandler(this.btnImportTxT_Click);
            // 
            // listWord
            // 
            this.listWord.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listWord.FormattingEnabled = true;
            this.listWord.ItemHeight = 24;
            this.listWord.Location = new System.Drawing.Point(25, 116);
            this.listWord.Name = "listWord";
            this.listWord.Size = new System.Drawing.Size(200, 340);
            this.listWord.TabIndex = 2;
            this.listWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listWord_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(251, 254);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 40);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "匯出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnImport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 484);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImportTxT);
            this.Controls.Add(this.btnOld);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(btnTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listWord);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtInput);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主畫面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnOld;
        private System.Windows.Forms.Button btnImportTxT;
        private System.Windows.Forms.ListBox listWord;
        private System.Windows.Forms.Button btnExport;
    }
}

