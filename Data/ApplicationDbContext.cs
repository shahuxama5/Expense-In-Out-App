﻿using ExpenseInAndOut.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseInAndOut.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Expense> Expenses { get; set; }
    }
}
