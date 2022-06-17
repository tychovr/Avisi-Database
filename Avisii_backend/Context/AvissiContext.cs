using Avisii_backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Avisii_backend.Context
{
    public class AvissiContext : DbContext
    {
        public AvissiContext([NotNullAttribute] DbContextOptions options): base(options)
        {
            
        }

        DbSet<User> User { get; set; }
        

    }
}
