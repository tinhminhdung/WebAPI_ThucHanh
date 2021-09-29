using AppDatabase.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDatabase.Database.Entities;

namespace Application.MSinhVien
{
    public class SinhVienService : ISinhVienService
    {
        private readonly DatabaseDbContext _context;
        public SinhVienService(DatabaseDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(SinhVienViewModel SinhVienViewModel)
        {
            var sinhVien = new SinhVien()
            {
                name = SinhVienViewModel.name,
                address = SinhVienViewModel.address
            };
            _context.SinhViens.Add(sinhVien);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Delete(int id)
        {
            var productImage = await _context.SinhViens.FindAsync(id);
            if (productImage != null)
            _context.SinhViens.Remove(productImage);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Update(SinhVienViewModel SinhVienViewModel)
        {
            var sinhVien = new SinhVien()
            {
                id = SinhVienViewModel.id,
                name = SinhVienViewModel.name,
                address = SinhVienViewModel.address
            };
            _context.SinhViens.Update(sinhVien);

            return await _context.SaveChangesAsync();
        }
        public async Task<List<SinhVienViewModel>> GetAll()
        {
            return await _context.SinhViens
                .Select(x => new SinhVienViewModel()
                {
                    id = x.id,
                    name = x.name,
                    address = x.address
                }).ToListAsync();
        }
        public async Task<SinhVienViewModel> GetById(int id)
        {
            var product = await _context.SinhViens.FindAsync(id);
            var productViewModel = new SinhVienViewModel()
            {
                id = product.id,
                name = product.name,
            };
            return productViewModel;
        }
    }
}
