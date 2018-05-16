using System;
using System.Collections.Generic;

namespace Inheritance.ViolateDeepInheritanceHierarchy
{
	public abstract class HumanResource
	{
		public string Name { get; set; }
		public DateTime Birthday { get; set; }

	}

	public abstract class Employee : HumanResource
	{
		public void QuitEmploymentRelationship(string reason)
		{
			// fire employee
		}
	}

	public class ExternalEmployee : Employee
	{
		public string LeasingCompany { get; set; } // using string for sake of clarity
	}

	public abstract class CompanyEmployee : Employee
	{
		public string Deparment { get; set; } // using string for sake of clarity
	}

	public abstract class PayableEmployee : CompanyEmployee
	{
		public int WorkingHoursLastMonth { get; set; }
		public int HourlyWage { get; set; }

		public int ComputeSalary()
		{
			return WorkingHoursLastMonth * HourlyWage;
		}
	}

	public abstract class VacationEligibleEmployee : PayableEmployee
	{
		public int EligibleBaseVacationDays { get; set; }

		private double _fractionEmployedThisYear;
		public double EmployedFractionOfCurrentYear
		{
			get => _fractionEmployedThisYear;
			set => _fractionEmployedThisYear = Math.Min(value, 1.0);
		}

		public int ComputeVacationDays()
		{
			return Convert.ToInt32(Math.Floor(EligibleBaseVacationDays * EmployedFractionOfCurrentYear));
		}
	}

	public abstract class SeasonalEmployee : VacationEligibleEmployee
	{
		public DateTime QuitDate { get; set; }
	}

	public abstract class SalariedEmployee : VacationEligibleEmployee
	{
	}

	public class Worker : SalariedEmployee
	{
	}

	public class Manager : SalariedEmployee
	{
		public IList<Employee> Subordinates;
	}
}
