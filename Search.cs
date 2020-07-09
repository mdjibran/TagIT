using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void _lstShowLinks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chkBoxLstSelectedTags.Items.Clear();
            foreach (var item in _lstAllTags.SelectedItems.)
            {
                _chkBoxLstSelectedTags.Items.Add(item.ToString());
            }
        }
    }
}
