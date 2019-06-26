using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoList.ApplicationCore.Entities;

namespace TodoList.Infrastructure.EntityConfig
{
    public class TaskMap : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.Property(e => e.Description)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
