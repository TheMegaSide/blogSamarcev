using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace blogSamarcev.Domain.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User :IdentityUser<int>
    {
        public Employee Employee { get; set; }
    }
}
