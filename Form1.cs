using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagIT.CustomClasses;

namespace TagIT
{
    public partial class Form1 : Form
    {
        List<Control> formCtrls;
        List<FormControlLoc> ctrlLocsORG = new List<FormControlLoc>();
        List<string> tags;
        List<string> ignore;
        ResizeElements resizeEls = new ResizeElements();
        private Size formOriginalSize;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {           
            webBrowser1.Navigate(_txtBoxURL.Text);

            getPageText(_txtBoxURL.Text);
        }


        private void getPageText(string url)
        {
            CleaningInput input = new CleaningInput();

            string txt = input.getText(url);
            foreach (string wrd in txt.Split())
            {
                string cleanWrd = cleanWord(wrd);
                if (isNewWord(cleanWrd))
                {
                    _LstNewWords.Items.Add(cleanWrd);
                }
            }
            SetCount();
        }
       private bool isNewWord(string word)
        {
            if (word == "")
            {
                return false;
            }
            else if (_LstNewWords.Items.Contains(word))
            {
                return false;
            }
            else if(ignore.Contains(word))
            {
                if (!(_LstIgnore.Items.Contains(word)))
                {
                    _LstIgnore.Items.Add(word);
                }
                return false;
            }
            
            else if (tags.Contains(word))
            {
                if (!(_LstTags.Items.Contains(word)))
                {
                    _LstTags.Items.Add(word);
                }
                return false;
            }
             

                     
            return true;
        }


        private string cleanWord(string word)
        {
            return Regex.Replace(word, "[^0-9a-zA-Z]+", "");
        }
        private void SetCount()
        {
            _lblNewWordCount.Text = "Words: " + _LstNewWords.Items.Count.ToString();
            _lblIgnoreCount.Text = "Words: " + _LstIgnore.Items.Count.ToString();
            _lblTagsCount.Text = "Words: " + _LstTags.Items.Count.ToString();
            _lblWord.Text = _LstNewWords.Items[0].ToString();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            StartResizing();

            PrepareThings();
        }

        private void StartResizing()
        {
            formOriginalSize = this.Size;
            formCtrls = new List<Control>();
            formCtrls = resizeEls.EnumerateChildren(this);
            ctrlLocsORG = new List<FormControlLoc>();

            Rectangle r;

            foreach (var item in formCtrls)
            {
                r = new Rectangle(item.Location.X, item.Location.Y, item.Width, item.Height);
                ctrlLocsORG.Add(new FormControlLoc { _frmControl = item, _frmRectangle = r });
            }
        }

        private void PrepareThings()
        {
            tags = new List<string>();
            ignore = new List<string>();            

            string[] oldTagLines = File.ReadAllLines("tags.txt");
            string[] ignoreLines = File.ReadAllLines("Ignore.txt");

            foreach (var line in oldTagLines)
            {
                foreach (var word in line.Split(','))
                {
                    tags.Add(word);
                }
            }

            foreach (var line in ignoreLines)
            {
                foreach (var word in line.Split(','))
                {
                    ignore.Add(word);
                }
            }

            _LstNewWords.Items.Clear();
            _LstTags.Items.Clear();
            _LstIgnore.Items.Clear();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (var item in ctrlLocsORG)
            {
               resizeEls.resizeControls(item._frmRectangle, item._frmControl, this, formOriginalSize);
            }
        }

        private void _btnTag_Click(object sender, EventArgs e)
        {
            string wrd = _lblWord.Text;
            _LstTags.Items.Add(wrd);
            _LstNewWords.Items.Remove(wrd);            
            SetCount();
        }

        private void _btnIgnore_Click(object sender, EventArgs e)
        {
            string wrd = _lblWord.Text;
            _LstIgnore.Items.Add(wrd);
            _LstNewWords.Items.Remove(wrd);
            SetCount();
        }


        private void _btnSave_Click(object sender, EventArgs e)
        {
            string newtags = "", ignore = "";
            foreach (var item in _LstTags.Items)
            {
                if(!tags.Contains(item.ToString()))
                    newtags += item.ToString() + ",";        
            }

            foreach (var item in _LstIgnore.Items)
            {
                if (!ignore.Contains(item.ToString()))
                    ignore += item.ToString() + ",";
            }

            using (StreamWriter file = new StreamWriter("Ignore.txt", true))
            {
                file.WriteLine(ignore);
            }

            using (StreamWriter file = new StreamWriter("tags.txt", true))
            {
                file.WriteLine(newtags);
            }
            ReDoThings();
        }

        private void ReDoThings()
        {
            PrepareThings();
            getPageText(_txtBoxURL.Text);
        }

        private void _btnSave_Click_1(object sender, EventArgs e)
        {
            string url = _txtBoxURL.Text.Trim();
            string tagsList = "";
            StringBuilder sb = new StringBuilder();
            foreach (var item in _LstTags.Items)
            {
                sb.Append(item.ToString().Trim()+", ");                
            }
            tagsList = sb.ToString();
            string line = url + " : " + tagsList;

            try
            {
                using (StreamWriter file = new StreamWriter("db.csv", true))
                {
                    file.WriteLine(line);
                }
                ShowSuccessBox();
            }
            catch(Exception ex)
            {
                ShowExceptionBox(ex);
            }

        }

        private void ShowExceptionBox(Exception ex)
        {
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessBox()
        {
            MessageBox.Show("Process Completed Successfully!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
