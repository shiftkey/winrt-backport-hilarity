using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Printing
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class GetPreviewPageEventArgs : IGetPreviewPageEventArgs
	{
		public extern int PageNumber
		{
			get;
		}
		public extern GetPreviewPageEventArgs();
	}
}
