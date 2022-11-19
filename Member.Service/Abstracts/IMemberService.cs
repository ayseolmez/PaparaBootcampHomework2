using Member.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Service.Abstracts
{
    public interface IMemberService
    {
        Task Add(MemberDto memberDto);
        Task Delete(int id);
        Task Update(MemberDto memberDto, int id);
        Task<List<MemberDto>> GetAll();
        Task<MemberDto> GetById(int id);
    }
}
