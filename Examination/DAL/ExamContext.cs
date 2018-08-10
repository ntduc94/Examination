using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Examination.Models.Data;

namespace Examination.DAL
{
	public class ExamContext : DbContext
	{
		public ExamContext() : base("ExamContext")
		{
			
		}

		public DbSet<Product> Products { get; set; }

	}
}