using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PlayToSourceRequest : IPlayToSourceRequest
	{
		public extern DateTime Deadline
		{
			get;
		}
		public extern void DisplayErrorString([In] string errorString);
		public extern PlayToSourceDeferral GetDeferral();
		public extern void SetSource([In] PlayToSource value);
	}
}
