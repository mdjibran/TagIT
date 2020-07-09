namespace TagIT
{
    partial class Search
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("11");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("343");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("6");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("7");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("8");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("9");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("sdhjhjsjcsjsjjsjcsdjdsjsjdkjsjshkjdhkjshdkjhskjdhskjhdkjshkjdhskjds");
            this._chkBoxLstSelectedTags = new System.Windows.Forms.CheckedListBox();
            this._lstAllTags = new System.Windows.Forms.ListView();
            this._btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lstShowLinks = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _chkBoxLstSelectedTags
            // 
            this._chkBoxLstSelectedTags.FormattingEnabled = true;
            this._chkBoxLstSelectedTags.Location = new System.Drawing.Point(12, 46);
            this._chkBoxLstSelectedTags.Name = "_chkBoxLstSelectedTags";
            this._chkBoxLstSelectedTags.Size = new System.Drawing.Size(189, 395);
            this._chkBoxLstSelectedTags.TabIndex = 0;
            // 
            // _lstAllTags
            // 
            this._lstAllTags.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this._lstAllTags.CheckBoxes = true;
            this._lstAllTags.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lstAllTags.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            this._lstAllTags.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this._lstAllTags.Location = new System.Drawing.Point(207, 46);
            this._lstAllTags.Name = "_lstAllTags";
            this._lstAllTags.Size = new System.Drawing.Size(581, 361);
            this._lstAllTags.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this._lstAllTags.TabIndex = 1;
            this._lstAllTags.UseCompatibleStateImageBehavior = false;
            this._lstAllTags.View = System.Windows.Forms.View.SmallIcon;
            this._lstAllTags.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this._lstAllTags_ItemChecked);
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(680, 417);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(108, 23);
            this._btnSearch.TabIndex = 2;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available Tags";
            // 
            // _lstShowLinks
            // 
            this._lstShowLinks.FormattingEnabled = true;
            this._lstShowLinks.ItemHeight = 16;
            this._lstShowLinks.Location = new System.Drawing.Point(207, 46);
            this._lstShowLinks.Name = "_lstShowLinks";
            this._lstShowLinks.Size = new System.Drawing.Size(581, 356);
            this._lstShowLinks.TabIndex = 5;
            this._lstShowLinks.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Open All Links";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._lstShowLinks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnSearch);
            this.Controls.Add(this._lstAllTags);
            this.Controls.Add(this._chkBoxLstSelectedTags);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.Resize += new System.EventHandler(this.Search_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox _chkBoxLstSelectedTags;
        private System.Windows.Forms.ListView _lstAllTags;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox _lstShowLinks;
        private System.Windows.Forms.Button button1;
    }
}