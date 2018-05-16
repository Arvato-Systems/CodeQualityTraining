namespace InterfaceSegregation
{
	public interface ITooBigInterface
	{
		void GetSomething(int a);
		void Method2(string a);
		void Method3(double a);
	}

	public class ViolateInterfaceSegregation : ITooBigInterface
	{
		private int field;

		public void GetSomething(int a)
		{
			field = a;
		}

		public void Method2(string a)
		{
			throw new System.NotSupportedException();
		}

		public void Method3(double a)
		{
			throw new System.NotImplementedException();
		}
	}
}
