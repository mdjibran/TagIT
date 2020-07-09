using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using HtmlAgilityPack;


using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Text.RegularExpressions;
using TagIT.CustomClasses;

namespace TagIT.CustomClasses
{
    class ResizeElements
    {
        public List<FormControlLoc> ctrlLocsORG;
        public Size formOriginalSize;
        public List<Control> formCtrls;

        public ResizeElements()
        {
            ctrlLocsORG = new List<FormControlLoc>();
        }
        public void addElement()
        {

        }

        public void setOriginalFormSize()
        {

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

        public void resizeControls(Rectangle OriginalControlRect, Control control, Form form, Size formOriginalSize)
        {
            float xRatio = (float)form.Width / (float)formOriginalSize.Width;
            float yRatio = (float)form.Height / (float)formOriginalSize.Height;

            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);
            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Size = new Size(newWidth, newHeight);
            control.Location = new Point(newX, newY);
        }


        public void SetOriginalSizes(Form form)
        {
            formOriginalSize = form.Size;
            formCtrls = new List<Control>();
            formCtrls = EnumerateChildren(form);
            ctrlLocsORG = new List<FormControlLoc>();

            Rectangle r;

            foreach (var item in formCtrls)
            {
                r = new Rectangle(item.Location.X, item.Location.Y, item.Width, item.Height);
                ctrlLocsORG.Add(new FormControlLoc { _frmControl = item, _frmRectangle = r });
            }
        }

        public void ResizeAllElements(Form form)
        {
            foreach (var item in ctrlLocsORG)
            {
                resizeControls(item._frmRectangle, item._frmControl, form, formOriginalSize);
            }
        }
    }
}
