using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.ViewModels
{
    public class RegistrationViewModel
    {
		[Required]
		[Display(Name = "Organization")]
		public string OrganizationName { get; set; }

		public List<string> Organizations { get; set; }

		[StringLength(20, MinimumLength = 1)]
		public string Gender { get; set; }

		[Required]
		[Display(Name = "Month")]
		public string BirthdayMonth { get; set; }

		[Required]
		[Display(Name = "Day")]
		public int BirthdayDay { get; set; }

		[Required]
		[Display(Name = "Year")]
		public int BirthdayYear { get; set; }

		[Required]
		public int Experience { get; set; }

		[Required]
		public string Ethnicity { get; set; }
	}
}
