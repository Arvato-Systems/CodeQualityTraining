using System;
using System.Collections.Generic;

namespace Inheritance.CompositionOverInheritance
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

		protected IEmployeePayrollService employeePayrollService;
		protected IEmployeeVacationCalculationService employeeVacationCalculationService;

		protected CompanyEmployee(IEmployeePayrollService employeePayrollService, IEmployeeVacationCalculationService employeeVacationCalculationService)
		{
			this.employeePayrollService = employeePayrollService;
			this.employeeVacationCalculationService = employeeVacationCalculationService;
		}
	}

	public abstract class SeasonalEmployee : CompanyEmployee
	{
		public DateTime QuitDate { get; set; }

		protected SeasonalEmployee(IEmployeePayrollService employeePayrollService, IEmployeeVacationCalculationService employeeVacationCalculationService)
			: base(employeePayrollService, employeeVacationCalculationService)
		{
		}
	}

	public abstract class SalariedEmployee : CompanyEmployee
	{
		protected SalariedEmployee(IEmployeePayrollService employeePayrollService, IEmployeeVacationCalculationService employeeVacationCalculationService)
			: base(employeePayrollService, employeeVacationCalculationService)
		{
		}
	}

	public class Worker : SalariedEmployee
	{
		public Worker(IEmployeePayrollService employeePayrollService, IEmployeeVacationCalculationService employeeVacationCalculationService)
			: base(employeePayrollService, employeeVacationCalculationService)
		{
		}
	}

	public class Manager : SalariedEmployee
	{
		public IList<Employee> Subordinates { get; set; }

		public Manager(IEmployeePayrollService employeePayrollService, IEmployeeVacationCalculationService employeeVacationCalculationService)
			: base(employeePayrollService, employeeVacationCalculationService)
		{
		}
	}



	/*
	 * 
	 * 
	 *  Interfaces and Dummy Services for solution illustration.
	 * 
	 * 
	 */
	public interface IEmployeeVacationCalculationService
	{
	}

	public interface IEmployeePayrollService
	{
	}


}
