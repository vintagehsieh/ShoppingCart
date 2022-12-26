using BookStore.Site.Models.DTOs;
using BookStore.Site.Models.Infrastructures.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Site.Models.Infrastructures.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public void Create(RegisterDTO dto)
        {
            throw new NotImplementedException();
        }

        public bool IsExists(string account)
        {
            throw new NotImplementedException();
        }
    }
}