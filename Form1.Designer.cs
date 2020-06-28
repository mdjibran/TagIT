namespace TagIT
{
    partial class Form1
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
            this._txtBoxURL = new System.Windows.Forms.TextBox();
            this._btnStart = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this._lblWord = new System.Windows.Forms.Label();
            this._btnTag = new System.Windows.Forms.Button();
            this._btnIgnore = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._lblNewWordCount = new System.Windows.Forms.Label();
            this._LstNewWords = new System.Windows.Forms.ListBox();
            this._lblTagsCount = new System.Windows.Forms.Label();
            this._LstTags = new System.Windows.Forms.ListBox();
            this._lblIgnoreCount = new System.Windows.Forms.Label();
            this._LstIgnore = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _txtBoxURL
            // 
            this._txtBoxURL.Location = new System.Drawing.Point(15, 12);
            this._txtBoxURL.Name = "_txtBoxURL";
            this._txtBoxURL.Size = new System.Drawing.Size(614, 22);
            this._txtBoxURL.TabIndex = 0;
            this._txtBoxURL.Text = "http://www.reachbeyondngo.com/";
            // 
            // _btnStart
            // 
            this._btnStart.Location = new System.Drawing.Point(643, 14);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(62, 23);
            this._btnStart.TabIndex = 1;
            this._btnStart.Text = "Start";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser1.Location = new System.Drawing.Point(720, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(690, 510);
            this.webBrowser1.TabIndex = 2;
            // 
            // _lblWord
            // 
            this._lblWord.AutoSize = true;
            this._lblWord.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblWord.Location = new System.Drawing.Point(86, 37);
            this._lblWord.Name = "_lblWord";
            this._lblWord.Size = new System.Drawing.Size(76, 31);
            this._lblWord.TabIndex = 3;
            this._lblWord.Text = "label1";
            // 
            // _btnTag
            // 
            this._btnTag.Location = new System.Drawing.Point(186, 175);
            this._btnTag.Name = "_btnTag";
            this._btnTag.Size = new System.Drawing.Size(75, 23);
            this._btnTag.TabIndex = 5;
            this._btnTag.Text = "Tag";
            this._btnTag.UseVisualStyleBackColor = true;
            this._btnTag.Click += new System.EventHandler(this._btnTag_Click);
            // 
            // _btnIgnore
            // 
            this._btnIgnore.Location = new System.Drawing.Point(267, 175);
            this._btnIgnore.Name = "_btnIgnore";
            this._btnIgnore.Size = new System.Drawing.Size(75, 23);
            this._btnIgnore.TabIndex = 6;
            this._btnIgnore.Text = "Ignore";
            this._btnIgnore.UseVisualStyleBackColor = true;
            this._btnIgnore.Click += new System.EventHandler(this._btnIgnore_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(168, 299);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(192, 23);
            this._btnSave.TabIndex = 9;
            this._btnSave.Text = "Update Grammer";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _lblNewWordCount
            // 
            this._lblNewWordCount.AutoSize = true;
            this._lblNewWordCount.Location = new System.Drawing.Point(369, 71);
            this._lblNewWordCount.Name = "_lblNewWordCount";
            this._lblNewWordCount.Size = new System.Drawing.Size(57, 17);
            this._lblNewWordCount.TabIndex = 10;
            this._lblNewWordCount.Text = "Words: ";
            // 
            // _LstNewWords
            // 
            this._LstNewWords.FormattingEnabled = true;
            this._LstNewWords.ItemHeight = 16;
            this._LstNewWords.Location = new System.Drawing.Point(372, 91);
            this._LstNewWords.Name = "_LstNewWords";
            this._LstNewWords.Size = new System.Drawing.Size(169, 404);
            this._LstNewWords.TabIndex = 15;
            // 
            // _lblTagsCount
            // 
            this._lblTagsCount.AutoSize = true;
            this._lblTagsCount.Location = new System.Drawing.Point(10, 62);
            this._lblTagsCount.Name = "_lblTagsCount";
            this._lblTagsCount.Size = new System.Drawing.Size(57, 17);
            this._lblTagsCount.TabIndex = 12;
            this._lblTagsCount.Text = "Words: ";
            // 
            // _LstTags
            // 
            this._LstTags.FormattingEnabled = true;
            this._LstTags.ItemHeight = 16;
            this._LstTags.Location = new System.Drawing.Point(12, 82);
            this._LstTags.Name = "_LstTags";
            this._LstTags.Size = new System.Drawing.Size(150, 420);
            this._LstTags.TabIndex = 14;
            // 
            // _lblIgnoreCount
            // 
            this._lblIgnoreCount.AutoSize = true;
            this._lblIgnoreCount.Location = new System.Drawing.Point(544, 71);
            this._lblIgnoreCount.Name = "_lblIgnoreCount";
            this._lblIgnoreCount.Size = new System.Drawing.Size(57, 17);
            this._lblIgnoreCount.TabIndex = 11;
            this._lblIgnoreCount.Text = "Words: ";
            // 
            // _LstIgnore
            // 
            this._LstIgnore.FormattingEnabled = true;
            this._LstIgnore.ItemHeight = 16;
            this._LstIgnore.Location = new System.Drawing.Point(547, 91);
            this._LstIgnore.Name = "_LstIgnore";
            this._LstIgnore.Size = new System.Drawing.Size(158, 404);
            this._LstIgnore.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 510);
            this.Controls.Add(this._LstIgnore);
            this.Controls.Add(this._LstNewWords);
            this.Controls.Add(this._LstTags);
            this.Controls.Add(this._lblTagsCount);
            this.Controls.Add(this._lblIgnoreCount);
            this.Controls.Add(this._lblNewWordCount);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnIgnore);
            this.Controls.Add(this._btnTag);
            this.Controls.Add(this._lblWord);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._txtBoxURL);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtBoxURL;
        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label _lblWord;
        private System.Windows.Forms.Button _btnTag;
        private System.Windows.Forms.Button _btnIgnore;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label _lblNewWordCount;
        private System.Windows.Forms.ListBox _LstNewWords;
        private System.Windows.Forms.Label _lblTagsCount;
        private System.Windows.Forms.ListBox _LstTags;
        private System.Windows.Forms.Label _lblIgnoreCount;
        private System.Windows.Forms.ListBox _LstIgnore;
    }
}

