using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ListViewItem)), Guid(3082502917u, 15833, 17374, 168, 192, 196, 114, 240, 133, 188, 17), Version(100794368u), WebHostHidden]
	internal interface IListViewItem
	{
		ListViewItemTemplateSettings TemplateSettings
		{
			get;
		}
	}
}
