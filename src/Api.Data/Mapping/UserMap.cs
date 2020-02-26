using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");  //Criando a tabela
            builder.HasKey(p => p.Id);  //Definindo a chaveprimária
            builder.HasIndex(p => p.Email).IsUnique(); //Definindo o index

            //Colunas da tabela
            builder.Property(u => u.Name).IsRequired().HasMaxLength(60);
            builder.Property(u => u.Email).HasMaxLength(100);
        }
    }
}
