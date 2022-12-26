using BookStore.Site.Models.DTOs;
using BookStore.Site.Models.EFModels;
using BookStore.Site.Models.Infrastructures.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Site.Models.Infrastructures.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private AppDbContext db = new AppDbContext();
        public void Create(RegisterDTO dto)
        {
            Member member = new Member
            {
                Account = dto.Account,
                EncryptedPassword = dto.EncryptedPassword,
                Email = dto.Email,
                Name = dto.Name,
                Mobile = dto.Mobile,
                IsConfirmed = false, //預設為未確認的會員
                ConfirmCode = dto.ConfirmCode
            };

            db.Members.Add(member);
            db.SaveChanges();
        }

        public bool IsExists(string account)
        {
            //SingleOrDefault會找兩筆
            //var entity = db.Members.SingleOrDefault(x => x.Account == account);
            var entity = db.Members.FirstOrDefault(x => x.Account == account);
            return (entity != null);
        }

        public MemberDTO Load(int memberId)
        {
            Member entity = db.Members.SingleOrDefault(x => x.Id == memberId);

            if (entity == null) return null;

            MemberDTO result = new MemberDTO
            {
                Id = entity.Id,
                Account = entity.Account,
                EncryptedPassword = entity.EncryptedPassword,
                Email = entity.Email,
                Name = entity.Name,
                Mobile = entity.Mobile,
                IsConfirmed = entity.IsConfirmed,
                ConfirmCode = entity.ConfirmCode
            };

            return result;
        }

        public void ActiveRegister(int memberId)
        {
            var member = db.Members.Find(memberId);
            member.IsConfirmed = true;
            member.ConfirmCode = null;
            db.SaveChanges();
        }

        
        
    }
}