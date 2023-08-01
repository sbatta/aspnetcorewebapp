using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class MvcWebAppDbContext : DbContext
{
    public MvcWebAppDbContext(DbContextOptions<MvcWebAppDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products {get; set;}
}