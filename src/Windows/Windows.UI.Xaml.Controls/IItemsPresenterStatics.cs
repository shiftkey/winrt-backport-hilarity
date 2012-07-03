using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ItemsPresenter)), Guid(417228493u, 19052, 19246, 170, 134, 203, 18, 108, 154, 41, 32), Version(100794368u), WebHostHidden]
	internal interface IItemsPresenterStatics
	{
		DependencyProperty HeaderProperty
		{
			get;
		}
		DependencyProperty HeaderTemplateProperty
		{
			get;
		}
		DependencyProperty HeaderTransitionsProperty
		{
			get;
		}
		DependencyProperty PaddingProperty
		{
			get;
		}
	}
}
