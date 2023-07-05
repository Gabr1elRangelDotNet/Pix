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
    public class TransacaoMapping : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.DataTransacao)
                .IsRequired()
                .HasColumnType("date");

            builder.HasOne(p => p.Recebedor)
                .WithMany(p => p.Transacoes)
                .IsRequired();

            builder.HasOne(p => p.Pagador)
                .WithMany(p => p.Transacoes)
                .IsRequired();

            builder.ToTable("Transacoes");



        }
    }


}
