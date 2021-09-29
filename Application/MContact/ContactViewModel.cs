using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.MContact
{
	public class ContactViewModel 
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Content { get; set; }
        public DateTime Createdate { get; set; }
        public int Status { get; set; }
    }
}