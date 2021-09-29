using Application.MSinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Service
{
    public interface ISinhVienApiClient
    {
        public Task<string> GetAll();
        public Task<string> Create(SinhVienViewModel request);
        public Task<string> Update(SinhVienViewModel request);
        public Task<string> GetById(int id);
        public Task<string> Delete(int id);
    }
}
