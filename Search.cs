using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagIT.CustomClasses;

namespace TagIT
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

 
        ResizeElements resizeEls = new ResizeElements();


        private void Search_Load(object sender, EventArgs e)
        {            
            resizeEls.SetOriginalSizes(this);
        }

        private void Search_Resize(object sender, EventArgs e)
        {
            resizeEls.ResizeAllElements(this);
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void _lstAllTags_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            _chkBoxLstSelectedTags.Items.Clear();
            foreach (ListViewItem item in _lstAllTags.CheckedItems)
            {
                string tag = item.Text;
                if (!_chkBoxLstSelectedTags.Items.Contains(tag))
                {
                    _chkBoxLstSelectedTags.Items.Add(item.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string link in _lstShowLinks.Items)
            {
                Process.Start(link);
            }
            
        }
    }
}
