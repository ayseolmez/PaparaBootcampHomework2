using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace Member.Data.Configurations
{
    using Member.Domain.Entities;
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {

        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.ToTable("Members");
        }
    }
}
