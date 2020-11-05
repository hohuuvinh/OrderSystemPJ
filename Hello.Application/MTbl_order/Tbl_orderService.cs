using Hello.Application.MTbl_order;
using Hello.Data;
using Hello.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocDotNet.Application.MTbl_order
{
	public class Tbl_orderService : ITbl_orderService
	{
		private readonly HelloDbContext _context;

		public Tbl_orderService(HelloDbContext context)
		{
			_context = context;
		}

		public async Task<int> Create(Tbl_orderRequest tbl_orderRequest)
		{
			var tbl_order = new tbl_order()
			{
				fee = tbl_orderRequest.fee,
				total = tbl_orderRequest.total
			};
			_context.tbl_orders.Add(tbl_order);

			return await _context.SaveChangesAsync();
		}

		public async Task<int> Delete(Tbl_orderRequest tbl_orderRequest)
		{
			var tbl_order = new tbl_order()
			{
				id = tbl_orderRequest.id
			};
			_context.tbl_orders.Remove(tbl_order);

			return await _context.SaveChangesAsync();
		}


		public async Task<int> Update(Tbl_orderRequest tbl_orderRequest)
		{
			var tbl_order = new tbl_order()
			{
				id = tbl_orderRequest.id,
				fee = tbl_orderRequest.fee,
				total = tbl_orderRequest.total
			};
			_context.tbl_orders.Update(tbl_order);

			return await _context.SaveChangesAsync();
		}
		public async Task<List<Tbl_orderResponse>> GetOrder()
		{
			int maxId = _context.tbl_orders.Max(u => u.id);
			var query = from or in _context.tbl_orders
						join it in _context.tbl_items on or.id equals it.idorder
						join pr in _context.tbl_products on it.idproduct equals pr.id
						where or.id == maxId
						select new { or, it , pr };
			return await query.Select(x => new Tbl_orderResponse()
			{
				id = x.pr.id,
				discount = x.it.discount,
				quanlity = x.it.quanlity,
				name = x.pr.name,
				price = x.pr.price,
				image= x.pr.image,
				category = x.pr.category
			}).ToListAsync();
		}
	}
}
