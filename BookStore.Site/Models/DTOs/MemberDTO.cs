using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BookStore.Site.Models.EFModels;

namespace BookStore.Site.Models.DTOs
{
    public class MemberDTO
    {
        public int Id { get; set; }

        public string Account { get; set; }

        public string EncryptedPassword { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public bool? IsConfirmed { get; set; }

        public string ConfirmCode { get; set; }
    }

    public static class MemberExtensions
    {
        public static MemberDTO ToDTO(this Member entity)
        {
            if (entity == null) return null;

            return new MemberDTO
            {
                Id = entity.Id,
                Account = entity.Account,
                EncryptedPassword = entity.EncryptedPassword,
                Email = entity.Email,
                Name = entity.Name,
                Mobile = entity.Mobile,
                IsConfirmed = entity.IsConfirmed,
            };
        }
    }
}