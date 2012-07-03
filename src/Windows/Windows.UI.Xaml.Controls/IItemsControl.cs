using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ItemsControl)), Guid(4104723928u, 55673, 17281, 134, 82, 189, 160, 52, 42, 118, 94), Version(100794368u), WebHostHidden]
	internal interface IItemsControl
	{
		string DisplayMemberPath
		{
			get;
			set;
		}
		IObservableVector<GroupStyle> GroupStyle
		{
			get;
		}
		GroupStyleSelector GroupStyleSelector
		{
			get;
			set;
		}
		bool IsGrouping
		{
			get;
		}
		ItemContainerGenerator ItemContainerGenerator
		{
			get;
		}
		Style ItemContainerStyle
		{
			get;
			set;
		}
		StyleSelector ItemContainerStyleSelector
		{
			get;
			set;
		}
		TransitionCollection ItemContainerTransitions
		{
			get;
			set;
		}
		DataTemplate ItemTemplate
		{
			get;
			set;
		}
		DataTemplateSelector ItemTemplateSelector
		{
			get;
			set;
		}
		ItemCollection Items
		{
			get;
		}
		ItemsPanelTemplate ItemsPanel
		{
			get;
			set;
		}
		object ItemsSource
		{
			get;
			set;
		}
	}
}
