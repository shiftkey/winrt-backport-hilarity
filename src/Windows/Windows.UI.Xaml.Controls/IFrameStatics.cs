using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Frame)), Guid(3584880873u, 55655, 18203, 132, 89, 200, 175, 67, 65, 81, 27), Version(100794368u), WebHostHidden]
	internal interface IFrameStatics
	{
		DependencyProperty BackStackDepthProperty
		{
			get;
		}
		DependencyProperty CacheSizeProperty
		{
			get;
		}
		DependencyProperty CanGoBackProperty
		{
			get;
		}
		DependencyProperty CanGoForwardProperty
		{
			get;
		}
		DependencyProperty CurrentSourcePageTypeProperty
		{
			get;
		}
		DependencyProperty SourcePageTypeProperty
		{
			get;
		}
	}
}
