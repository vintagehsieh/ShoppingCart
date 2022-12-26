using BookStore.Site.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Site.Models.Infrastructures.Services
{
    public class MemberService
    {
        private readonly IMemberRepository repository;

        public MemberService(IMemberRepository repo)
        {
            this.repository = repo;
        }

        //Value Tuple
        public (bool IsSuccess, string ErrorMessage) CreateNewMember(RegisterDTO dto)
        {
            //todo 判斷各欄位是否正確

            //判斷帳號是否存在
            if (repository.IsExists(dto.Account))
            {
                return (false, "帳號已存在");
            }
    

        #region 建立會員紀錄
            //建立ConfirmCode
            dto.ConfirmCode = Guid.NewGuid().ToString("N");
            #endregion
        }
    }
}