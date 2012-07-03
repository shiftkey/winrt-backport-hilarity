using System;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;
namespace Windows.UI.Xaml.Printing
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PaginateEventArgs : IPaginateEventArgs
	{
		public extern int CurrentPreviewPageNumber
		{
			get;
		}
		public extern PrintTaskOptions PrintTaskOptions
		{
			get;
		}
		public extern PaginateEventArgs();
	}
}
