using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Page)), Guid(929947249u, 63269, 18141, 141, 128, 238, 234, 247, 218, 116, 229), Version(100794368u), WebHostHidden]
	internal interface IPageStatics
	{
		DependencyProperty BottomAppBarProperty
		{
			get;
		}
		DependencyProperty FrameProperty
		{
			get;
		}
		DependencyProperty TopAppBarProperty
		{
			get;
		}
	}
}
