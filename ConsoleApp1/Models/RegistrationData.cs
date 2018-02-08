using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Models
{
	public class RegistrationData
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public Guid UserId { get; set; }

		[Required]
		public string OrganizationName { get; set; }

		public string Gender { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime Birthday { get; set; }

		[Required]
		public int Experience { get; set; }

		[Required]
		public string Ethnicity { get; set; }

		[Required]
		public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
	}
}
