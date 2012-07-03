using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Printing
{
	[ExclusiveTo(typeof(GetPreviewPageEventArgs)), Guid(2755489853u, 57001, 19958, 167, 237, 53, 4, 156, 212, 133, 199), Version(100794368u), WebHostHidden]
	internal interface IGetPreviewPageEventArgs
	{
		int PageNumber
		{
			get;
		}
	}
}
