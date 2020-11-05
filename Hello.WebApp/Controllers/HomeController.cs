﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_product;
using Hello.WebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hello.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITbl_productApiClient _nhanSuApiClient;

        public HomeController(ITbl_productApiClient sinhVienApiClient)
        {
            _nhanSuApiClient = sinhVienApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _nhanSuApiClient.GetAll();

            var model = JsonConvert.DeserializeObject<List<Tbl_productResponse>>(response);

            return View(model);
        }
        
    }
}