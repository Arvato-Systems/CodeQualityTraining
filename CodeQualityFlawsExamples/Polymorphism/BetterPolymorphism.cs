using System;
using System.Collections.Generic;

namespace Polymorphism.BetterPolymorphism
{
	public abstract class Employee
	{
		public string Name { get; set; }
		public DateTime Birthday { get; set; }
		public string Deparment { get; set; } // using string for sake of clarity
	}

	public abstract class PayableEmployee : Employee
	{
		public int WorkingHoursLastMonth { get; set; }
		public int HourlyWage { get; set; }

		public virtual double ComputeSalary()
		{
			return Math.Round(WorkingHoursLastMonth * HourlyWage * 0.6);
		}
	}

	public abstract class SeasonalEmployee : PayableEmployee
	{
		public DateTime QuitDate { get; set; }

		public override double ComputeSalary()
		{
			return Math.Round(WorkingHoursLastMonth * HourlyWage * 0.8);
		}
	}

	public abstract class SalariedEmployee : PayableEmployee
	{
		public override double ComputeSalary()
		{
			return WorkingHoursLastMonth * HourlyWage;
		}
	}

	public class Worker : SalariedEmployee
	{
	}

	public class Manager : SalariedEmployee
	{
		public IList<Employee> Subordinates;
	}
}
