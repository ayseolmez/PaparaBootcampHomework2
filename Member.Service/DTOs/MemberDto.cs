using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Service.DTOs
{
    public class MemberDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your e-mail address")]
        public string Email { get; set; }
    }
}
