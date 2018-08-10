using System;
using System.ComponentModel.DataAnnotations;

namespace Examination.Models.View
{
	public class CreateProductView
	{
		[Required(ErrorMessage = "Please insert your product name.")]
		public string Name { get; set; }
		[Required]
		[Range(1, int.MaxValue, ErrorMessage = "Stock amount must be at least 1.")]
		public int Stock { get; set; }
		[Required]
		[Range(5, 100, ErrorMessage = "Price must be in the range [5-100].")]
		public int Price { get; set; }
		[Required]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime ImportAt { get; set; }
	}
}