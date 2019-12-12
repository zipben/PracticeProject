using System;
using System.ComponentModel.DataAnnotations;

namespace Practice_Project.Models{
	public class MelangePurchase
	{

		public int Id { get; set; }
		public string MerchantName { get; set; }

		[DataType(DataType.Date)]
		public DateTime PurchaseDate { get; set; }
		public int Kilos { get; set; }
		public decimal Price { get; set; }
	}
}