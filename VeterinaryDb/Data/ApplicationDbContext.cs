using System;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using VeterinaryDb.Models;

namespace VeterinaryDb.Data;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Owner>? Owners { get; set; } = null!;
    public DbSet<Pet>? Pets { get; set; } = null!;



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Seed data on initial create and migrate

        modelBuilder.Entity<Owner>().HasData
            (
            new Owner { OwnerId = 1, FirstName = "Ben", LastName = "Smith", Address = "1, Apple Tree Lane" }
            );

        modelBuilder.Entity<Pet>().HasData(
        new Pet { PetId = 1, PetName = "Max", Species = "Cat", OwnerId = 1 });



        //FluentAPI Set constraints


        modelBuilder.Entity<Owner>().HasKey(a => a.OwnerId);

        modelBuilder.Entity<Owner>().Property(a => a.OwnerId)
            .IsRequired();

        modelBuilder.Entity<Pet>().HasKey(a => a.PetId);


        modelBuilder.Entity<Pet>().Property(a => a.PetId)
            .IsRequired();

        modelBuilder.Entity<Pet>().HasOne(a => a.Owner)
       .WithMany(a => a.Pet)
       .HasForeignKey(a => a.OwnerId);


    }
}