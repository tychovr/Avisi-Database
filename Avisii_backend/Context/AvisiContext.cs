using Avisi_backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Avisii_backend.Context
{
    public class AvisiContext : DbContext
    {
        public AvisiContext([NotNullAttribute] DbContextOptions options): base(options)
        {
            

        }

        DbSet<User> User { get; set; }

        

    }
}
