using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Auth
{
    public class ResponseDto
    {
        public string? Email { get; set; }
        public string? Username { get; set; }
        public int? StatusCode { get; set; }
        public string? Token { get; set; }

    }
}