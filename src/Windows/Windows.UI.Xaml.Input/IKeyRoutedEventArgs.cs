using System;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(KeyRoutedEventArgs)), Guid(3570220542u, 16505, 17129, 163, 154, 48, 149, 211, 240, 73, 198), Version(100794368u), WebHostHidden]
	internal interface IKeyRoutedEventArgs
	{
		bool Handled
		{
			get;
			set;
		}
		VirtualKey Key
		{
			get;
		}
		CorePhysicalKeyStatus KeyStatus
		{
			get;
		}
	}
}
