using System;
using System.Collections.Generic;

#nullable disable

namespace Dev_Community.Models
{
    public partial class UserAccount
    {
        public int Seq { get; set; }
        public string UsrName { get; set; }
        public DateTime Created { get; set; } 
    }
}
