using Application.MContact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Service
{
    public interface IContactApiClient
    {
        public Task<string> GetAll();
        public Task<string> Create(ContactViewModel request);
        public Task<string> Update(ContactViewModel request);
        public Task<string> GetById(int id);
        public Task<string> Delete(int id);
    }
}
