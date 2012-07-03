using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ListViewItemTemplateSettings)), Guid(1739556031u, 33401, 18054, 147, 38, 205, 24, 159, 39, 87, 93), Version(100794368u), WebHostHidden]
	internal interface IListViewItemTemplateSettings
	{
		int DragItemsCount
		{
			get;
		}
	}
}
