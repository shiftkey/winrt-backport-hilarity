using System;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;
namespace Windows.UI.Xaml.Input
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class KeyRoutedEventArgs : RoutedEventArgs, IKeyRoutedEventArgs
	{
		public extern bool Handled
		{
			get;
			set;
		}
		public extern VirtualKey Key
		{
			get;
		}
		public extern CorePhysicalKeyStatus KeyStatus
		{
			get;
		}
	}
}
