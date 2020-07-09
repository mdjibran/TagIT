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


    }
}
