using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDatabase.Database.Entities
{
	[Table("Lop")]
	public class Lop
	{
		//[Key]
		public int id { get; set; }

		public string name { get; set; }

	}
}