using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(GridViewItem)), Guid(2107179505u, 59329, 20099, 180, 112, 201, 214, 215, 189, 169, 245), Version(100794368u), WebHostHidden]
	internal interface IGridViewItem
	{
		GridViewItemTemplateSettings TemplateSettings
		{
			get;
		}
	}
}
