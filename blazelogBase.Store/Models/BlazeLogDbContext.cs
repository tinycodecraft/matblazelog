﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using blazelogBase.Store.Setup;
using Microsoft.EntityFrameworkCore;

namespace blazelogBase.Store.Models;

public partial class BlazeLogDbContext : DbContext, IBlazeLogDbContext
{
    public BlazeLogDbContext(DbContextOptions<BlazeLogDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CoreSetting> CoreSettings { get; set; }

    public virtual DbSet<CoreUser> CoreUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CoreUser>(entity =>
        {
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}