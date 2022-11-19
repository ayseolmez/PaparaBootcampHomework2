using AutoMapper;
using Member.Data.Abstract;
using Member.Service.Abstracts;
using Member.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;



namespace Member.Service.Concretes
{
    using Member.Domain.Entities;
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public MemberService(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task Add(MemberDto memberDto)
        {
            var member = _mapper.Map<Member>(memberDto);
            await _memberRepository.Add(member);
        }

        public async Task Delete(int id)
        {
            var member = await _memberRepository.GetById(id);
            await _memberRepository.Delete(id);
        }

        public async Task<List<MemberDto>> GetAll()
        {
            var member = await _memberRepository.GetAll();
            var memberDto = _mapper.Map<List<MemberDto>>(member);
            return memberDto;
        }

        public async Task<MemberDto> GetById(int id)
        {
            var member = await _memberRepository.GetById(id);
            if (member is null)
            {
                throw new Exception("not found");
            }
            var memberDto = _mapper.Map<MemberDto>(member);
            return memberDto;
        }

        public async Task Update(MemberDto memberDto, int id)
        {
            var member = await _memberRepository.GetById(id);
            var updateMember = _mapper.Map<Member>(memberDto);
            updateMember.Id = id;
            await _memberRepository.Update(updateMember, updateMember.Id);
        }
    }
}
