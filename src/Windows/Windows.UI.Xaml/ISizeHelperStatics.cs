using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(SizeHelper)), Guid(1652999602u, 53112, 18709, 170, 64, 118, 0, 74, 22, 95, 94), Version(100794368u), WebHostHidden]
	internal interface ISizeHelperStatics
	{
		Size Empty
		{
			get;
		}
		Size FromDimensions([In] float width, [In] float height);
		bool GetIsEmpty([In] Size target);
		bool Equals([In] Size target, [In] Size value);
	}
}
