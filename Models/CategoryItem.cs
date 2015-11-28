using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSV.Models
{
    public class CategoryItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Id: {1}", Name, Id);
        }
    }
}