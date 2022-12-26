using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace BookStore.Site.Models.DTOs
{
    public class RegisterDTO
    {
        public string Account { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }
    }
}