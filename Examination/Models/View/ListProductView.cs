using System;

namespace Examination.Models.View
{
	public class ListProductView
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Stock { get; set; }
		public int Price { get; set; }
		public DateTime ImportAt { get; set; }
		public DateTime UpdateAt { get; set; }
	}
}