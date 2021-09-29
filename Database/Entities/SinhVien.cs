using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDatabase.Database.Entities
{
	[Table("SinhVien")]
	public class SinhVien
	{
		//[ForeignKey]
		public int id { get; set; }

		public string name { get; set; }

		public string address { get; set; }
	}
}