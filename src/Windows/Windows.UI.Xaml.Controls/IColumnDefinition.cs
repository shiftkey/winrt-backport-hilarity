using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ColumnDefinition)), Guid(4159812137u, 61476, 18047, 151, 10, 126, 112, 86, 21, 219, 123), Version(100794368u), WebHostHidden]
	internal interface IColumnDefinition
	{
		double ActualWidth
		{
			get;
		}
		double MaxWidth
		{
			get;
			set;
		}
		double MinWidth
		{
			get;
			set;
		}
		GridLength Width
		{
			get;
			set;
		}
	}
}
