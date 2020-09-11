using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerApp.Shared.Models
{
    public class UserManagerResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
        //public UserInfo UserInfo { get; set; }       
        public DateTime? ExpireDate { get; set; }
        public Dictionary<string, string> UserInfo { get; set; }
    }
}
