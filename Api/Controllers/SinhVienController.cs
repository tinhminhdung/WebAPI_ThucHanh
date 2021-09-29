using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.MSinhVien;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly ISinhVienService _sinhVienSerive;
        public SinhVienController(ISinhVienService sinhVienService)
        {
            _sinhVienSerive = sinhVienService;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _sinhVienSerive.GetAll());
        }

        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _sinhVienSerive.Delete(id));
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
              return Ok(await _sinhVienSerive.GetById(id));
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Post([FromBody] SinhVienViewModel request)
        {
            return Ok(await _sinhVienSerive.Create(request));
        }
        
        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] SinhVienViewModel request)
        {
            return Ok(await _sinhVienSerive.Update(request));
        }
    }
}
