using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(AppBar)), Guid(2064630355u, 34469, 19267, 152, 114, 11, 138, 98, 52, 183, 75), Version(100794368u), WebHostHidden]
	internal interface IAppBar
	{
		event EventHandler<object> Closed;
		event EventHandler<object> Opened;
		bool IsOpen
		{
			get;
			set;
		}
		bool IsSticky
		{
			get;
			set;
		}
	}
}
