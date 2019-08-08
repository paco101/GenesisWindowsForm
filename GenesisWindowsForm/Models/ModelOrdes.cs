namespace Genesis.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class ModelOrdes : DbContext
	{
		public ModelOrdes()
			: base("name=ModelOrdes")
		{
			this.Configuration.LazyLoadingEnabled = false;
		}

		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Order> Orders { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>()
				.HasMany(e => e.Orders)
				.WithRequired(e => e.Customer)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.OrderValue)
				.HasPrecision(18, 7);
		}
	}
}
