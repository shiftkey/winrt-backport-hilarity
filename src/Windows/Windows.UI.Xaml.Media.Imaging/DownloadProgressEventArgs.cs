using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DownloadProgressEventArgs : IDownloadProgressEventArgs
	{
		public extern int Progress
		{
			get;
			set;
		}
	}
}
