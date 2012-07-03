using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ToggleSwitch)), Guid(857575168u, 50681, 18085, 182, 200, 237, 229, 57, 48, 69, 103), Version(100794368u), WebHostHidden]
	internal interface IToggleSwitch
	{
		event RoutedEventHandler Toggled;
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
		bool IsOn
		{
			get;
			set;
		}
		object OffContent
		{
			get;
			set;
		}
		DataTemplate OffContentTemplate
		{
			get;
			set;
		}
		object OnContent
		{
			get;
			set;
		}
		DataTemplate OnContentTemplate
		{
			get;
			set;
		}
		ToggleSwitchTemplateSettings TemplateSettings
		{
			get;
		}
	}
}
