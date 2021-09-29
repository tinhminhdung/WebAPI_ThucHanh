using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.MContact;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApp.Service;

namespace WebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactApiClient _ContactApiClient;

        public ContactController(IContactApiClient ContactApiClient)
        {
            _ContactApiClient = ContactApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _ContactApiClient.GetAll();

            var model = JsonConvert.DeserializeObject<List<ContactViewModel>>(response);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactViewModel request)
        {
            try
            {
                var response = await _ContactApiClient.Create(request);

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
            var response = await _ContactApiClient.GetById(id);
            var model = JsonConvert.DeserializeObject<ContactViewModel>(response);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ContactViewModel request)
        {
            try
            {
                var response = await _ContactApiClient.Update(request);
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
            var response = await _ContactApiClient.GetById(id);
            var model = JsonConvert.DeserializeObject<List<ContactViewModel>>(response);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _ContactApiClient.Delete(id);
            //if (result.Count() > 0)
            //   return BadRequest();
            return RedirectToAction("Index", "Contact");
        }


    }
}
