using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace C.V.ResumeWPF.Model
{
    public partial class BasicInfo
    {
        public string ImagePath
        {
            get
            {
                string AddImage;
                if (Pic != null)
                {
                    AddImage = "..\\Assets\\Images\\SelectedImages\\" + Pic.Trim();
                }
                else
                {
                    AddImage = "";
                }
                return AddImage;
            }
        }
    }
}
