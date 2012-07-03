using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(DownloadProgressEventArgs)), Guid(1930551508u, 65172, 20080, 155, 144, 205, 212, 122, 194, 58, 251), Version(100794368u), WebHostHidden]
	internal interface IDownloadProgressEventArgs
	{
		int Progress
		{
			get;
			set;
		}
	}
}
