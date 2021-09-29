using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.MSinhVien
{
	public class SinhVienViewModel
	{
		public int id { get; set; }
		public string name { get; set; }
		public string address { get; set; }
	}
}