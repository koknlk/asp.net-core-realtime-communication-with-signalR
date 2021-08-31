using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationChatBasicApp.Models
{
    public class AppUser: IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }

        //One to many relations.
        public virtual ICollection<Message> Messages { get; set; }
    }
}
