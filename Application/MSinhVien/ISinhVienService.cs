using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.MSinhVien
{
    public interface ISinhVienService
    {
        public Task<List<SinhVienViewModel>> GetAll();
        public Task<SinhVienViewModel> GetById(int id);
        public Task<int> Create(SinhVienViewModel SinhVienViewModel);
        public Task<int> Update(SinhVienViewModel SinhVienViewModel);
        Task<int> Delete(int id);
    }
}
