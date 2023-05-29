using RelacaoMuitosPMuitos.Models;
using Microsoft.EntityFrameworkCore;

namespace RelacaoMuitosPMuitos.Data
{
    public class RelacaoMPMContext : DbContext
    {   
        public RelacaoMPMContext(DbContextOptions<RelacaoMPMContext> options) : base(options)
        {
        }

        public DbSet<Post>? Posts { get; set; }
        public DbSet<Tag>? Tags { get; set; }

        public DbSet<PostTag>? PostTags { get; set; }
    }
}
