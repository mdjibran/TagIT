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

        List<Control> formCtrls;
        List<FormControlLoc> ctrlLocsORG = new List<FormControlLoc>();
        List<string> tags;
        List<string> ignore;
        ResizeElements resizeEls = new ResizeElements();
        private Size formOriginalSize;


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

        private void Search_Load(object sender, EventArgs e)
        {
            StartResizing();
        }

        private void Search_Resize(object sender, EventArgs e)
        {
            foreach (var item in ctrlLocsORG)
            {
                resizeEls.resizeControls(item._frmRectangle, item._frmControl, this, formOriginalSize);
            }
        }
    }
}
