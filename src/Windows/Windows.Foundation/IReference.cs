namespace Windows.Foundation
{
	public interface IReference<T> : IPropertyValue
	{
		T Value { get; }
	}
}
