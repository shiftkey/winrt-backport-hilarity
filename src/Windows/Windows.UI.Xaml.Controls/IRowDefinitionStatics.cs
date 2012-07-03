using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RowDefinition)), Guid(1524580325u, 8278, 18212, 148, 214, 228, 129, 43, 2, 46, 200), Version(100794368u), WebHostHidden]
	internal interface IRowDefinitionStatics
	{
		DependencyProperty HeightProperty
		{
			get;
		}
		DependencyProperty MaxHeightProperty
		{
			get;
		}
		DependencyProperty MinHeightProperty
		{
			get;
		}
	}
}
