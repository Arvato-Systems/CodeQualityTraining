using System;
using System.Collections.Generic;

namespace Polymorphism.IgnoringPolymorphism
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

		public double ComputeSalary()
		{
			if (this is SeasonalEmployee)
			{
				return Math.Round(WorkingHoursLastMonth * HourlyWage * 0.8);
			}
			if (this is Worker)
			{
				return WorkingHoursLastMonth * HourlyWage;
			}
			if (this is Manager)
			{
				return WorkingHoursLastMonth * HourlyWage;
			}
			else
			{
				return Math.Round(WorkingHoursLastMonth * HourlyWage * 0.6);
			}
		}
	}

	public abstract class SeasonalEmployee : PayableEmployee
	{
		public DateTime QuitDate { get; set; }
	}

	public abstract class SalariedEmployee : PayableEmployee
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
