using BookStore.Site.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Site.Models.Infrastructures.Services
{
    public interface IMemberRepository
    {
        bool IsExists(string account);
        void Create(RegisterDTO dto);
        MemberDTO Load(int memberId);
        void ActiveRegister(int memberId);

    }
}
