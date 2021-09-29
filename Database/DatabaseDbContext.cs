using AppDatabase.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDatabase.Database
{
	public class DatabaseDbContext : DbContext
	{
		public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options)
		{
		}

		public DbSet<SinhVien> SinhViens { get; set; }
		public DbSet<Lop> Lops { get; set; }
		public DbSet<Contact> Contacts { get; set; }
	}
}
