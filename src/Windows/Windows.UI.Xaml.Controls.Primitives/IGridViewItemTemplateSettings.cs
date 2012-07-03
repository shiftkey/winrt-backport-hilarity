using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(GridViewItemTemplateSettings)), Guid(2653993647u, 5725, 16999, 164, 94, 26, 67, 167, 87, 6, 172), Version(100794368u), WebHostHidden]
	internal interface IGridViewItemTemplateSettings
	{
		int DragItemsCount
		{
			get;
		}
	}
}
