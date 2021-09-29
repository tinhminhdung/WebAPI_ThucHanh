using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.MContact;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactSerive;
        public ContactController(IContactService ContactService)
        {
            _ContactSerive = ContactService;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _ContactSerive.GetAll());
        }

        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _ContactSerive.Delete(id));
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
              return Ok(await _ContactSerive.GetById(id));
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Post([FromBody] ContactViewModel request)
        {
            return Ok(await _ContactSerive.Create(request));
        }
        
        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] ContactViewModel request)
        {
            return Ok(await _ContactSerive.Update(request));
        }
    }
}
