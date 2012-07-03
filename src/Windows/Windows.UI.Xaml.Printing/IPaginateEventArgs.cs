using System;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;
namespace Windows.UI.Xaml.Printing
{
	[ExclusiveTo(typeof(PaginateEventArgs)), Guid(3985924054u, 31147, 17079, 147, 10, 61, 110, 9, 1, 29, 33), Version(100794368u), WebHostHidden]
	internal interface IPaginateEventArgs
	{
		int CurrentPreviewPageNumber
		{
			get;
		}
		PrintTaskOptions PrintTaskOptions
		{
			get;
		}
	}
}
