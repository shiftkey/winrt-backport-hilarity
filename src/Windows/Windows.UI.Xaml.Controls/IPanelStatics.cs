using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Panel)), Guid(4064111453u, 33584, 18342, 160, 70, 37, 245, 9, 178, 82, 50), Version(100794368u), WebHostHidden]
	internal interface IPanelStatics
	{
		DependencyProperty BackgroundProperty
		{
			get;
		}
		DependencyProperty ChildrenTransitionsProperty
		{
			get;
		}
		DependencyProperty IsItemsHostProperty
		{
			get;
		}
	}
}
