using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDatabase.Database
{
		class DatabaseDbContextFactory : IDesignTimeDbContextFactory<DatabaseDbContext>
		{
			public DatabaseDbContext CreateDbContext(string[] args)
			{
				var optionsBuilder = new DbContextOptionsBuilder<DatabaseDbContext>();
				optionsBuilder.UseSqlServer("Server=.;Database=WebAPI_ThucHanh;Trusted_Connection=True;");

				return new DatabaseDbContext(optionsBuilder.Options);
			}
		}
}
