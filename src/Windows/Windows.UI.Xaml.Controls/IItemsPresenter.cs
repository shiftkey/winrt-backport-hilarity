using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ItemsPresenter)), Guid(3262207643u, 28106, 20011, 142, 20, 197, 81, 54, 176, 42, 113), Version(100794368u), WebHostHidden]
	internal interface IItemsPresenter
	{
		object Header
		{
			get;
			set;
		}
		DataTemplate HeaderTemplate
		{
			get;
			set;
		}
		TransitionCollection HeaderTransitions
		{
			get;
			set;
		}
		Thickness Padding
		{
			get;
			set;
		}
	}
}
