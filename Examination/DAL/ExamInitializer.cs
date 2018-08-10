using Examination.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Examination.DAL
{
	public class ExamInitializer : DropCreateDatabaseIfModelChanges<ExamContext>
	{
		protected override void Seed(ExamContext context)
		{
			try
			{
				context.Products.AddRange(new List<Product>
				{
					new Product
					{
						Name = "Test Product 1",
						Price = 200,
						Stock = 10,
						ImportAt = DateTime.Now,
						CreatedAt = DateTime.Now,
						UpdatedAt = DateTime.Now
					},
					new Product
					{
						Name = "Test Product 2",
						Price = 400,
						Stock = 20,
						ImportAt = DateTime.Now,
						CreatedAt = DateTime.Now,
						UpdatedAt = DateTime.Now
					}
				});
				context.SaveChanges();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}