using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.MContact
{
    public interface IContactService
    {
        public Task<List<ContactViewModel>> GetAll();
        public Task<ContactViewModel> GetById(int id);
        public Task<int> Create(ContactViewModel ContactViewModel);
        public Task<int> Update(ContactViewModel ContactViewModel);
        Task<int> Delete(int id);
    }
}
