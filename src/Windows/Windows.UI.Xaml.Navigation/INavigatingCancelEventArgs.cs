using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Navigation
{
	[ExclusiveTo(typeof(NavigatingCancelEventArgs)), Guid(4246562734u, 60155, 16505, 190, 128, 109, 201, 42, 3, 174, 223), Version(100794368u), WebHostHidden]
	internal interface INavigatingCancelEventArgs
	{
		bool Cancel
		{
			get;
			set;
		}
		NavigationMode NavigationMode
		{
			get;
		}
		TypeName SourcePageType
		{
			get;
		}
	}
}
