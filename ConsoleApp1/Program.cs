using System;
using ConsoleApp1.Models;
using ConsoleApp1.ViewModels;
using AutoMapper;
using System.Globalization;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Mapper.Initialize(config =>
			{
				config.CreateMap<RegistrationData, RegistrationViewModel>().ReverseMap();
			});

			var vm = new RegistrationViewModel()
			{
				OrganizationName = "Dev Organization",
				Experience = 7,
				Gender = "female",
				Ethnicity = "native",
				BirthdayDay = 1,
				BirthdayMonth = "January",
				BirthdayYear = 1970
			};

			var regData = Mapper.Map<RegistrationData>(vm);

			Console.WriteLine($"Org Name : {regData.OrganizationName}");
			Console.WriteLine($"Grade    : {regData.Experience}");
			Console.WriteLine($"Gender   : {regData.Gender}");
			Console.WriteLine($"Ethnicity: {regData.Ethnicity}");

			Console.ReadKey();
		}
	}
}
