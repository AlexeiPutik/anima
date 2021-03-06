using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Entities
{
    public class Author: IdentityUser
    {
        public byte[] ProfilePicture { get; set; }
    }
}
