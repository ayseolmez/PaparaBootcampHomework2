using Member.Service.Abstracts;
using Member.Service.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Member.API.Controllers
{
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpPost]
        public async Task<IActionResult> AddMember(MemberDto memberDto)
        {
            await _memberService.Add(memberDto);
            return Ok();
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetCompany()
        {
            var memberList = await _memberService.GetAll();
            return Ok(memberList);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var member = await _memberService.GetById(id);
            return Ok(member);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(MemberDto memberDto, int id)
        {
            await _memberService.Update(memberDto, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _memberService.Delete(id);
            return Ok();
        }

    }
}
