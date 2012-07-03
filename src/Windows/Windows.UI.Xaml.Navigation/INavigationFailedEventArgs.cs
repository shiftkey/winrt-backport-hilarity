using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Navigation
{
	[ExclusiveTo(typeof(NavigationFailedEventArgs)), Guid(297918455u, 14018, 16642, 178, 239, 2, 23, 169, 114, 137, 179), Version(100794368u), WebHostHidden]
	internal interface INavigationFailedEventArgs
	{
		HResult Exception
		{
			get;
		}
		bool Handled
		{
			get;
			set;
		}
		TypeName SourcePageType
		{
			get;
		}
	}
}
