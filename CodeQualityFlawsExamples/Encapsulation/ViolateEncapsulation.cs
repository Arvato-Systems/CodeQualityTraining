namespace Encapsulation
{
	public class ViolateEncapsulation
	{
		public string field;

		public ViolateEncapsulation()
		{
			field = "Initial Value";
		}
		public int ProvideStringLength()
		{
			return field.Length * 3;
		}
	}
}
