using Encapsulation;
using InterfaceSegregation;

namespace SampleApp
{
	public class Program
	{
		public static void Main(string[] args)
		{

			ViolateEncapsulation();

			ViolateShallowIneritanceHierarchy();

			IgnorePolymorphism();

		}

		public static void ViolateEncapsulation()
		{
			var encapViolator = new ViolateEncapsulation();
			encapViolator.field = null;
			System.Console.WriteLine(
				 encapViolator.ProvideStringLength()
				 );
		}

		public static void ViolateShallowIneritanceHierarchy()
		{
			var hans = new Inheritance.ViolateDeepInheritanceHierarchy.Worker()
			{
				Name = "Hans Wurst"
			};
		}

		public static void IgnorePolymorphism()
		{
			var worker = new Polymorphism.IgnoringPolymorphism.Worker()
			{
				Name = "Max Mustermann",
				HourlyWage = 15,
				WorkingHoursLastMonth = 260
			};
		}

		public static void ViolateInterfaceSegregation()
		{
			var test = new ViolateInterfaceSegregation();
		}
	}
}
