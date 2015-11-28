using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSV.Models
{
    public class MenuItemViewModel
    {
        public string Caption { get; set; }

        public string Url { get; set; }

        public override string ToString()
        {
            return string.Format("Caption: {0}, Url: {1}", Caption, Url);
        }
    }
}