using Microsoft.EntityFrameworkCore;
using Practice_Project.Models;

namespace Practice_Project.Data
{
	public class MelangePurchaseContext :DbContext
	{
		public MelangePurchaseContext (DbContextOptions<MelangePurchaseContext> options)
		:base(options)
		{

		}
		public DbSet<MelangePurchase> MelangePurchase {get; set;}
	}
}

