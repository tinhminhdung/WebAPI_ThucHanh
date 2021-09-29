using AppDatabase.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDatabase.Database.Entities;

namespace Application.MContact
{
    public class ContactService : IContactService
    {
        private readonly DatabaseDbContext _context;
        public ContactService(DatabaseDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ContactViewModel obj)
        {
            var Contact = new Contact()
            {
                HoVaTen = obj.HoVaTen,
                DienThoai = obj.DienThoai,
                Email = obj.Email,
                DiaChi = obj.DiaChi,
                Content = obj.Content,
                Createdate = obj.Createdate,
                Status = obj.Status
            };
            _context.Contacts.Add(Contact);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Delete(int id)
        {
            var productImage = await _context.Contacts.FindAsync(id);
            if (productImage != null)
                _context.Contacts.Remove(productImage);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Update(ContactViewModel obj)
        {
            var Contact = new Contact()
            {
                ID = obj.ID,
                HoVaTen = obj.HoVaTen,
                DienThoai = obj.DienThoai,
                Email = obj.Email,
                DiaChi = obj.DiaChi,
                Content = obj.Content,
                Createdate = obj.Createdate,
                Status = obj.Status
            };
            _context.Contacts.Update(Contact);
            return await _context.SaveChangesAsync();
        }
        public async Task<List<ContactViewModel>> GetAll()
        {
            return await _context.Contacts
                .Select(x => new ContactViewModel()
                {
                    ID = x.ID,
                    HoVaTen = x.HoVaTen,
                    DienThoai = x.DienThoai,
                    Email = x.Email,
                    DiaChi = x.DiaChi,
                    Content = x.Content,
                    Createdate = x.Createdate,
                    Status = x.Status
                }).ToListAsync();
        }
        public async Task<ContactViewModel> GetById(int id)
        {
            var x = await _context.Contacts.FindAsync(id);
            var ContactViewModel = new ContactViewModel()
            {
                ID = x.ID,
                HoVaTen = x.HoVaTen,
                DienThoai = x.DienThoai,
                Email = x.Email,
                DiaChi = x.DiaChi,
                Content = x.Content,
                Createdate = x.Createdate,
                Status = x.Status
            };
            return ContactViewModel;
        }
    }
}
