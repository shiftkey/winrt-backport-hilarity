using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Printing
{
	[ExclusiveTo(typeof(PrintDocument)), Guid(4254534204u, 45394, 18912, 166, 189, 106, 166, 71, 126, 67, 199), Version(100794368u), WebHostHidden]
	internal interface IPrintDocumentStatics
	{
		DependencyProperty DocumentSourceProperty
		{
			get;
		}
	}
}
