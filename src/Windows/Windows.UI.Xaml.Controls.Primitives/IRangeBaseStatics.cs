using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(RangeBase)), Guid(1743722465u, 65079, 18255, 158, 151, 59, 94, 11, 48, 242, 224), Version(100794368u), WebHostHidden]
	internal interface IRangeBaseStatics
	{
		DependencyProperty LargeChangeProperty
		{
			get;
		}
		DependencyProperty MaximumProperty
		{
			get;
		}
		DependencyProperty MinimumProperty
		{
			get;
		}
		DependencyProperty SmallChangeProperty
		{
			get;
		}
		DependencyProperty ValueProperty
		{
			get;
		}
	}
}
