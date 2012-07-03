using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ToggleSwitch)), Guid(490148991u, 38879, 16934, 146, 202, 221, 244, 83, 215, 253, 90), Version(100794368u), WebHostHidden]
	internal interface IToggleSwitchStatics
	{
		DependencyProperty HeaderProperty
		{
			get;
		}
		DependencyProperty HeaderTemplateProperty
		{
			get;
		}
		DependencyProperty IsOnProperty
		{
			get;
		}
		DependencyProperty OffContentProperty
		{
			get;
		}
		DependencyProperty OffContentTemplateProperty
		{
			get;
		}
		DependencyProperty OnContentProperty
		{
			get;
		}
		DependencyProperty OnContentTemplateProperty
		{
			get;
		}
	}
}
