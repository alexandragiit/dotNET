using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFstudii;

public class ModelSelfRefrences : DbContext
{
    public ModelSelfRefrences()
    : base("ModelSelfRefrences")
    {
    }
    public virtual DbSet<SelfReference> SelfReferences { get; set; }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<SelfReference>()
        .HasMany(m => m.References)
        .WithOptional(m => m.ParentSelfReference);
    }
}
