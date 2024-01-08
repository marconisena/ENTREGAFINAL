using Agencia.Model;
using Microsoft.EntityFrameworkCore;

namespace Agencia.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Usuario entity
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Nome).IsRequired().HasMaxLength(255);
                entity.Property(u => u.Cpf).IsRequired().HasMaxLength(11);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(255);
                entity.Property(u => u.Senha).IsRequired().HasMaxLength(255);
                entity.Property(u => u.Telefone).HasMaxLength(20);
                entity.Property(u => u.Destino).HasMaxLength(255);

                // Seed initial data
                entity.HasData(
                    new Usuario
                    {
                        Id = 1,
                        Nome = "marconi",
                        Cpf = "123456",
                        Email = "marconi@",
                        Senha = "123",
                        Telefone = "123-456-7890",
                        Destino = "Rio de Janeiro",
                        // Add other properties as needed
                    },
                    new Usuario
                    {
                        Id = 2,
                        Nome = "marcos",
                        Cpf = "98765432101",
                        Email = "marco.doe@.com",
                        Senha = "456",
                        Telefone = "987-654-3210",
                        Destino = "São Paulo",
                        // Add other properties as needed
                    }
                    // Add more seed data as needed
                );
            });
        }
    }
}
