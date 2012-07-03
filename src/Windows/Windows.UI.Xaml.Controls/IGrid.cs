using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Grid)), Guid(4245701728u, 11797, 19363, 139, 143, 250, 105, 58, 65, 97, 233), Version(100794368u), WebHostHidden]
	internal interface IGrid
	{
		ColumnDefinitionCollection ColumnDefinitions
		{
			get;
		}
		RowDefinitionCollection RowDefinitions
		{
			get;
		}
	}
}
