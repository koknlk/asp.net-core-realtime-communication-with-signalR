using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationChatBasicApp.Models;

namespace WebApplicationChatBasicApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Code implementation NB
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
        //Messaging model
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                .HasOne<AppUser>(a => a.Sender)
                .WithMany(k => k.Messages)
            .HasForeignKey(j => j.UserID);
        }

        public DbSet<Message> Messages { get; set; }
    }
}
