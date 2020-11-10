using Hello.Application.MTbl_user;
using Hello.Data;
using Hello.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocDotNet.Application.MTbl_user
{
	public class Tbl_userService : ITbl_userService
	{
		private readonly HelloDbContext _context;

		public Tbl_userService(HelloDbContext context)
		{
			_context = context;
		}

		public async Task<int> Create(Tbl_userRequest tbl_userRequest)
		{
			var tbl_user = new tbl_user()
			{
				name = tbl_userRequest.name,
				address = tbl_userRequest.address,
				phone = tbl_userRequest.phone,
			};
			_context.tbl_users.Add(tbl_user);

			return await _context.SaveChangesAsync();
		}

		public async Task<int> Delete(Tbl_userRequest tbl_userRequest)
		{
			var tbl_user = new tbl_user()
			{
				id = tbl_userRequest.id
			};
			_context.tbl_users.Remove(tbl_user);

			return await _context.SaveChangesAsync();
		}


		public async Task<int> Update(Tbl_userRequest tbl_userRequest)
		{
			var tbl_user = new tbl_user()
			{	
				id= tbl_userRequest.id,
				name = tbl_userRequest.name,
				address = tbl_userRequest.address,
				phone = tbl_userRequest.phone,
			};
			_context.tbl_users.Update(tbl_user);

			return await _context.SaveChangesAsync();
		}

		public async Task<List<Tbl_userResponse>> GetAll()
		{
			return await _context.tbl_users
				.Select(x => new Tbl_userResponse()
				{
					id = x.id,
					name = x.name,
					address = x.address,
					phone = x.phone,

				}).ToListAsync();
		}

	}
}
