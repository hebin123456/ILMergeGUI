using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILMergeGUI
{
    internal class ListBoxItem
    {
        public string DisplayName
        {
            get;
            set;
        }

        public string FullFileName
        {
            get;
            set;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
