using DesafioNet.Business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNet.Data.Context.Mapping
{
    public class ChaveMapping : IEntityTypeConfiguration<Chave>
    {
        public void Configure(EntityTypeBuilder<Chave> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Descricao).
                IsRequired().HasColumnType("varchar(1000)");
            builder.ToTable("Chaves");
        }
    }
}
