using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class CoreWindowPopupShowingEventArgs : ICoreWindowPopupShowingEventArgs
	{
		public extern void SetDesiredSize([In] Size value);
	}
}
