using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[Guid(2684221429u, 47305, 20208, 183, 210, 29, 230, 38, 86, 31, 200), Version(100794368u), WebHostHidden]
	public interface ICoreAcceleratorKeys
	{
		event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> AcceleratorKeyActivated;
	}
}
