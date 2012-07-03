using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ColumnDefinition)), Guid(112252712u, 53316, 16582, 148, 46, 174, 96, 234, 199, 72, 81), Version(100794368u), WebHostHidden]
	internal interface IColumnDefinitionStatics
	{
		DependencyProperty MaxWidthProperty
		{
			get;
		}
		DependencyProperty MinWidthProperty
		{
			get;
		}
		DependencyProperty WidthProperty
		{
			get;
		}
	}
}
