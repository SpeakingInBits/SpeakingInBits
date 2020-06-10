using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpeakingInBits.Models;

namespace SpeakingInBits.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VideoLesson> VideoLessons { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
