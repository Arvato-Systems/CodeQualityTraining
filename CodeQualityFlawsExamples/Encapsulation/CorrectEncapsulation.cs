using System;

namespace Encapsulation
{
	public class CorrectEncapsulation
	{
		private string _backingField;
		public string Field
		{
			get => _backingField;

			set => _backingField = value ?? throw new ArgumentNullException($"{nameof(Field)} must be a non-zero length string.");
		}

		public CorrectEncapsulation()
		{
			Field = "Initial value";
		}

		public int ProvideStringLength()
		{
			return Field.Length;
		}
	}
}
