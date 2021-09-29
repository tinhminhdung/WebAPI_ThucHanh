using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.MSinhVien;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApp.Service;

namespace WebApp.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly ISinhVienApiClient _sinhVienApiClient;

        public SinhVienController(ISinhVienApiClient sinhVienApiClient)
        {
            _sinhVienApiClient = sinhVienApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _sinhVienApiClient.GetAll();

            var model = JsonConvert.DeserializeObject<List<SinhVienViewModel>>(response);

            return View(model);
        }

        // GET: api/<SinhVienController>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // GET: api/<SinhVienController>
        [HttpPost]
        public async Task<IActionResult> Create(SinhVienViewModel request)
        {
            try
            {
                // TODO: Add insert logic here 
                var response = await _sinhVienApiClient.Create(request);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var response = await _sinhVienApiClient.GetById(id);
            var model = JsonConvert.DeserializeObject<SinhVienViewModel>(response);
            return View(model);
        }

        // GET: api/<SinhVienController>
        [HttpPost]
        public async Task<IActionResult> Edit(SinhVienViewModel request)
        {
            try
            {
                // TODO: Add insert logic here 
                var response = await _sinhVienApiClient.Update(request);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _sinhVienApiClient.GetById(id);
            var model = JsonConvert.DeserializeObject<List<SinhVienViewModel>>(response);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _sinhVienApiClient.Delete(id);
            //if (result.Count() > 0)
            //   return BadRequest();
            return RedirectToAction("Index", "sinhvien");
        }

        //[HttpDelete]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var result = await _sinhVienApiClient.Delete(id);
        //    if (result.Count() > 0)
        //        return BadRequest();
        //    return View("/SinhVien/index");
        //}


    }
}
