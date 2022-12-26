using BookStore.Site.Models.Infrastructures;
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

        /// <summary>
        /// 加密之後的密碼
        /// </summary>
        public string EncryptedPassword
        {
            get
            {
                string salt = "!@#$$DGTEGYT";
                string result = HashUtility.TOSHA256(this.Password, salt);
                return result;
            }
        }
        public string Email { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }
    }
}