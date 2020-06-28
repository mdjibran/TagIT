using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagIT
{
    public partial class Form1 : Form
    {
        List<Control> formCtrls;
        List<FormControlLoc> ctrlLocsORG = new List<FormControlLoc>();

        private Size formOriginalSize;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(_txtBoxURL.Text);
            string txt = getText(webBrowser1.DocumentText);
            foreach (string wrd in txt.Split())
            {
                if (wrd != "" && !(_LstNewWords.Items.Contains(wrd)))
                {
                    _LstNewWords.Items.Add(wrd);
                }
            }
            SetCount();
            
        }

        private string getText(string html)
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(html);

            //var root = htmlDoc.DocumentNode.SelectSingleNode("//body");
            var sb = new StringBuilder();
            foreach(HtmlNode node in htmlDoc.DocumentNode.SelectNodes("//text()"))
            {
                string wrd = node.InnerText.Trim();
                if (wrd.Trim() != "")
                {
                    sb.AppendLine(wrd);
                }
            }

            return sb.ToString();
        }

        private void SetCount()
        {
            _lblNewWordCount.Text = "Words: " + _LstNewWords.Items.Count.ToString();
            _lblIgnoreCount.Text = "Words: " + _LstIgnore.Items.Count.ToString();
            _lblTagsCount.Text = "Words: " + _LstTags.Items.Count.ToString();
            //_LstNewWords.SetItemChecked(0, true);
            _lblWord.Text = _LstNewWords.Items[0].ToString();
        }
        private void resizeControls(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)this.Width / (float)formOriginalSize.Width;
            float yRatio = (float)this.Height / (float)formOriginalSize.Height;

            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);
            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Size = new Size(newWidth, newHeight);
            control.Location = new Point(newX, newY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;
            formCtrls = new List<Control>();
            formCtrls = EnumerateChildren(this);
            ctrlLocsORG = new List<FormControlLoc>();

            Rectangle r;

            foreach (var item in formCtrls)
            {
                r = new Rectangle(item.Location.X, item.Location.Y, item.Width, item.Height);
                ctrlLocsORG.Add(new FormControlLoc { _frmControl = item, _frmRectangle = r });
            }
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (var item in ctrlLocsORG)
            {
                resizeControls(item._frmRectangle, item._frmControl);
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


        public List<Control> EnumerateChildren(Control root)
        {
            List<Control> formCtrls = new List<Control>();
            foreach (Control control in root.Controls)
            {
                formCtrls.Add(control);
                if (control.Controls != null)
                {
                    EnumerateChildren(control);
                }
            }

            return formCtrls;
        }
    }
}
