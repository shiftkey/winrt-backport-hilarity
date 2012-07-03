using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class WindowSizeChangedEventArgs : IWindowSizeChangedEventArgs, ICoreWindowEventArgs
	{
		public extern Size Size
		{
			get;
		}
		public extern bool Handled
		{
			get;
			set;
		}
	}
}
