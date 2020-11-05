﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_order;
using Hello.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hello.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Tbl_orderController : ControllerBase
	{	
		private readonly ITbl_orderService _nhanSuSerive;

		public Tbl_orderController(ITbl_orderService tbl_orderService)
		{
			_nhanSuSerive = tbl_orderService;
		}

		// GET: api/<Tbl_orderController>
		//[HttpGet]
		//public async Task<IActionResult> Index(int id)
		//{
		//	return Ok(await _nhanSuSerive.GetAll());
		//}

		[HttpGet("GetOrder/{id}")]
		public async Task<IActionResult> GetOrder(int id)
		{
			return Ok(await _nhanSuSerive.GetOrder(id));
		}


		// POST: api/Tbl_order/Create
		[HttpPost("Create")]
		public async Task<IActionResult> Create([FromBody]Tbl_orderRequest request)
		{
			return Ok(await _nhanSuSerive.Create(request));
		}

		// POST: api/Tbl_order/Update
		[HttpPost("Update")]
		public async Task<IActionResult> Update([FromBody]Tbl_orderRequest request)
		{
			return Ok(await _nhanSuSerive.Update(request));
		}

		// POST: api/Tbl_order/Delete
		[HttpPost("Delete")]
		public async Task<IActionResult> Delete([FromBody]Tbl_orderRequest request)
		{
			return Ok(await _nhanSuSerive.Delete(request));
		}



	}
}
