using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.DTOs
{
    public class ErrorDto
    {
        public ErrorDto() 
        {
            Errors = Errors ?? new List<string>();
        }
        public List<string> Errors { get; set; }
        public int Status { get; set; }
    }
}
