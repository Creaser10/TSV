using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSV.Infrastructure;
using BetterCms.Module.Root.ViewModels.Cms;

using System.ComponentModel.DataAnnotations;

namespace TSV.Models
{
    public class ContactFormViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Email(ErrorMessage = "Invalid Email address")]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public string EmailTo { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Email: {1}, Phone: {2}, Message: {3}", Name, Email, Message);
        }
    }
}