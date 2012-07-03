using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(AppBar)), Guid(4026787042u, 31503, 20298, 151, 13, 174, 138, 14, 170, 155, 112), Version(100794368u), WebHostHidden]
	internal interface IAppBarOverrides
	{
		void OnClosed([In] object e);
		void OnOpened([In] object e);
	}
}
