using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Navigation
{
	[ExclusiveTo(typeof(NavigationEventArgs)), Guid(3064633396u, 26257, 17617, 189, 247, 88, 130, 12, 39, 176, 208), Version(100794368u), WebHostHidden]
	internal interface INavigationEventArgs
	{
		object Content
		{
			get;
		}
		NavigationMode NavigationMode
		{
			get;
		}
		object Parameter
		{
			get;
		}
		TypeName SourcePageType
		{
			get;
		}
		Uri Uri
		{
			get;
			set;
		}
	}
}
