using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
	[WebHostHidden]
	public interface IGetActivationFactory
	{
		object GetActivationFactory(string activatableClassId);
	}
}
