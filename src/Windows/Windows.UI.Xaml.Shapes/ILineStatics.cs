using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Line)), Guid(645665341u, 28324, 19536, 139, 29, 80, 32, 122, 255, 30, 138), Version(100794368u), WebHostHidden]
	internal interface ILineStatics
	{
		DependencyProperty X1Property
		{
			get;
		}
		DependencyProperty X2Property
		{
			get;
		}
		DependencyProperty Y1Property
		{
			get;
		}
		DependencyProperty Y2Property
		{
			get;
		}
	}
}
