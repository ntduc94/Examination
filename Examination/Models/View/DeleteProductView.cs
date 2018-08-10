using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examination.Models.View
{
	public class DeleteProductView
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Stock { get; set; }
		public int Price { get; set; }
		public DateTime ImportAt { get; set; }
		public DateTime UpdateAt { get; set; }
	}
}