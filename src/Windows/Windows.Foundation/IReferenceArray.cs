namespace Windows.Foundation
{
	public interface IReferenceArray<T> : IPropertyValue
	{
		T[] Value { get; }
	}
}
