namespace English
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.lblShow = new System.Windows.Forms.Label();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTranslate = new System.Windows.Forms.Label();
            this.pbxSpeak = new System.Windows.Forms.PictureBox();
            this.pbxTransalte = new System.Windows.Forms.PictureBox();
            this.ckbAuto = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTransalte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShow.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(0, 0);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(582, 262);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "txt";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCorrect
            // 
            this.btnCorrect.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCorrect.Location = new System.Drawing.Point(184, 292);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(90, 40);
            this.btnCorrect.TabIndex = 2;
            this.btnCorrect.Text = "✔";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnWrong
            // 
            this.btnWrong.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWrong.ForeColor = System.Drawing.Color.Red;
            this.btnWrong.Location = new System.Drawing.Point(297, 292);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(90, 40);
            this.btnWrong.TabIndex = 3;
            this.btnWrong.Text = "✖";
            this.btnWrong.UseVisualStyleBackColor = true;
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbAuto);
            this.panel1.Controls.Add(this.lblShow);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 262);
            this.panel1.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblError.ForeColor = System.Drawing.Color.Tomato;
            this.lblError.Location = new System.Drawing.Point(456, 289);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(116, 44);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "錯誤: 0";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTranslate
            // 
            this.lblTranslate.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTranslate.ForeColor = System.Drawing.Color.Gray;
            this.lblTranslate.Location = new System.Drawing.Point(0, 206);
            this.lblTranslate.Name = "lblTranslate";
            this.lblTranslate.Size = new System.Drawing.Size(583, 68);
            this.lblTranslate.TabIndex = 1;
            this.lblTranslate.Text = "txt";
            this.lblTranslate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSpeak
            // 
            this.pbxSpeak.Image = ((System.Drawing.Image)(resources.GetObject("pbxSpeak.Image")));
            this.pbxSpeak.Location = new System.Drawing.Point(56, 300);
            this.pbxSpeak.Name = "pbxSpeak";
            this.pbxSpeak.Size = new System.Drawing.Size(25, 25);
            this.pbxSpeak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSpeak.TabIndex = 1;
            this.pbxSpeak.TabStop = false;
            this.pbxSpeak.Click += new System.EventHandler(this.pbxSpeak_Click);
            // 
            // pbxTransalte
            // 
            this.pbxTransalte.Image = ((System.Drawing.Image)(resources.GetObject("pbxTransalte.Image")));
            this.pbxTransalte.Location = new System.Drawing.Point(17, 300);
            this.pbxTransalte.Name = "pbxTransalte";
            this.pbxTransalte.Size = new System.Drawing.Size(25, 25);
            this.pbxTransalte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTransalte.TabIndex = 6;
            this.pbxTransalte.TabStop = false;
            this.pbxTransalte.Click += new System.EventHandler(this.pbxTransalte_Click);
            // 
            // ckbAuto
            // 
            this.ckbAuto.AutoSize = true;
            this.ckbAuto.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckbAuto.Location = new System.Drawing.Point(483, 0);
            this.ckbAuto.Name = "ckbAuto";
            this.ckbAuto.Size = new System.Drawing.Size(88, 23);
            this.ckbAuto.TabIndex = 1;
            this.ckbAuto.Text = "自動朗讀";
            this.ckbAuto.UseVisualStyleBackColor = true;
            // 
            // Quiz
            // 
            this.AcceptButton = this.btnCorrect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pbxTransalte);
            this.Controls.Add(this.pbxSpeak);
            this.Controls.Add(this.lblTranslate);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.btnCorrect);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "測驗";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTransalte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnWrong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTranslate;
        private System.Windows.Forms.PictureBox pbxSpeak;
        private System.Windows.Forms.PictureBox pbxTransalte;
        private System.Windows.Forms.CheckBox ckbAuto;
    }
}