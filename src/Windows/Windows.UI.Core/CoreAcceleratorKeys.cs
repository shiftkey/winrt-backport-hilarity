using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u), WebHostHidden]
	public sealed class CoreAcceleratorKeys : ICoreAcceleratorKeys
	{
		public extern event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> AcceleratorKeyActivated
		{
			add;
			remove;
		}
	}
}
