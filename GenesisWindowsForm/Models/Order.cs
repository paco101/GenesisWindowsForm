namespace Genesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string ReferenceNumber { get; set; }

        public decimal OrderValue { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }

		[NotMapped]
		public string FullName
		{
			get { return Customer.FirstName + " " + Customer.LastName; }
		}
    }
}
